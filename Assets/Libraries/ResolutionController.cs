using UnityEngine;
using System;
using System.Linq;
using System.Collections;
using System.Runtime.InteropServices;

/// Usage Notes:
/// ------------
/// Sending display settings to the resolution controller while the IsChangingDisplay property
/// is true will result in ignored commands. GUI's should wait for the preceding display settings
/// to take place before allowing new settings to be sent.
/// 
/// Setup:
/// ------
/// Direct3D 11: 
///     No special setup is required, however "fullscreen" mode will never be exclusive.
/// 
/// Direct3D 9: 
///     >Edit/Project/Player must have "D3D9 Fullscreen Mode" set to "ExclusiveMode".
///     (see Resolution and Presentation section of the Desktop Standalone tab)
/// 
/// Determining your renderer:
///     >Edit/Project/Player will have "Use Direct3D 11" checked.
///     (see Other Settings section of the Desktop Standalone tab)

/// <summary>
/// Your game's window title is set by Unity in your "Player" settings. Since we need 
/// a reference to it, we find the window with this handle. You can supply this handle
/// however you please, though. It's only referenced once.
/// </summary>
public static class Game
{
  public static string Name = "School Game";
}

public class ResolutionController : MonoBehaviour
{
    #region Static
    // Running resolutions which do not fit within the native resolution of 
    // the monitor in non-exclusive fullscreen mode can lead to Legacy GUI
    // problems, namely that the mouse pointer will not accurately trigger
    // GUI elements when hovering over them. We can test if a resolution
    // will be problematic with the "IsAllowedResolution(resolution)" method.
    // If we cannot determine the desktop resolution, we will not be able to
    // test if a resolutoin is problematic. This can be detected with the
    // "NeedDesktopResolutionWarning" property, and the following string can 
    // be used as a warning.
    public const string UNKNOWN_DESKTOP_RESOLUTION_WARNING =
        @"Desktop resolution was not detected. In Windowed 
        and Borderless modes, resolutions which are too
        large for the monitor's native resolution may lead
        to Legacy GUI handling mouse input incorrectly.";
    
    public enum DisplayModes { Unknown, Fullscreen, Borderless, Windowed }
    #endregion

    #region Public Properties
    // The window's display mode.
    public DisplayModes CurrentDisplayMode
    {
        get { return _currentDisplayMode; }
    }

    // The window's viewport's resolution
    public Resolution CurrentResolution
    {
        get { return SortedResolutions[_currentResolutionIndex]; }
    }

    // A string representation of the current resolution and aspect ratio.
    public string CurrentResolutionString
    {
        get { return GenerateFullResolutionString(CurrentResolution); }
    }

    // The window's current override position.
    public Position CurrentOverridePosition
    {
        get { return _currentOverridePosition; }
        set { _currentOverridePosition = value; }
    }

    // Whether or not to use the override position for windowed modes.
    public bool UseOverridePosition
    {
        get { return _useOverridePosition; }
        set
        {
            // dont update if there's no change
            if (_useOverridePosition == value) return;

            ChangeUseOverridePosition(value);
        }
    }

    // Whether or not the window is in exclusive fullscreen mode.
    public bool IsExclusiveFullscreen
    {
        get { return Screen.fullScreen; }
    }

    // Whether or not the window is being changed.
    public bool IsChangingDisplay
    {
        get { return _displayModeRoutine != null || _resolutionRoutine != null; }
    }

    // Whether or not we should display the warning. Read the warning for more information.
    public bool NeedDesktopResolutionWarning
    {
        get
        {
            bool desktopResolutionDependent =
                CurrentDisplayMode == ResolutionController.DisplayModes.Windowed ||
                CurrentDisplayMode == ResolutionController.DisplayModes.Borderless;

            // if we are not desktop resolution dependent, we can test allowed resolutions because unity will stretch all resolutions to fit
            if (!desktopResolutionDependent) return true;

            // if we are desktop resolution dependent and we know the resolution, we can test resolutions properly, otherwise we cannot
            return desktopResolutionDependent && GetDesktopResolution().HasValue;
        }
    }

    // A sorted array of resolutions
    public Resolution[] SortedResolutions
    {
        get
        {
            if (_sortedResolutions == null)
            {
                _sortedResolutions = Sort(Screen.resolutions);
            }

            return _sortedResolutions;
        }
    }
    #endregion

    #region Inspector Variables
    [SerializeField] private Position _defaultOverridePosition = new Position(0, 0);
    [SerializeField] private bool _newResolutionResetsPosition = true;
    [SerializeField] private bool _guessBestDefaultResolution = true;
    #endregion

    #region Public Methods
    public bool IsCurrentResolution(Resolution resolution)
    {
        return (resolution.width == CurrentResolution.width) && (resolution.height == CurrentResolution.height);
    }

    /// <summary>
    /// Returns whether or not this resolution is safe to use. A resolution
    /// is allowed if it will fit within the desktop resolution. If
    /// the desktop resolution cannot be determined, all resolutions will
    /// be allowed, but I advise presenting the DesktopResolutionUnknownWarning.
    /// </summary>
    public bool IsAllowedResolution(Resolution resolution)
    {
        // if we are windowed or borderless, we need to fit within our desktop resolution
        if (CurrentDisplayMode == ResolutionController.DisplayModes.Windowed || CurrentDisplayMode == ResolutionController.DisplayModes.Borderless)
        {
            // if we can get the desktop resolution
            Resolution? desktopResolution = GetDesktopResolution();
            if (desktopResolution.HasValue)
            {
                // return if the resolution fits
                bool widthFits = resolution.width <= desktopResolution.Value.width;
                bool heightFits = resolution.height <= desktopResolution.Value.height;
                return widthFits && heightFits;
            }
        }

        return true;
    }

    /// <summary>
    /// Gets the desktop's resolution. The return value is a nullable type such that we
    // return null if the resolution cannot be determined.
    /// </summary>
    public Resolution? GetDesktopResolution()
    {
        Resolution? desktopResolution = null;

        // windows
        #if UNITY_STANDALONE_WIN             
        desktopResolution = _windowsHandler.GetDesktopResolution();
        #endif

        return desktopResolution;
    }

    /// <summary>
    /// Returns a string version of a resolution and its aspect ratio ("16:9: 1920x1080").
    /// </summary>
    public string GenerateFullResolutionString(Resolution resolution)
    {
        return string.Format("{0}: {1}", GenerateAspectRatioString(resolution), GenerateResolutionString(resolution));
    }

    /// <summary>
    /// Returns a string version of a resolution ("1920x1080").
    /// </summary>
    public string GenerateResolutionString(Resolution resolution)
    {
        return string.Format("{0}x{1}", resolution.width, resolution.height);
    }

    /// <summary>
    /// Generates a string version of a resolution's aspect ratio ("16:9"). Returns 
    /// "Unknown" if the aspect ratio is not recognized.
    /// </summary>
    public string GenerateAspectRatioString(Resolution resolution)
    {
        float aspect = (float)resolution.width / (float)resolution.height;

        if (Approximately(aspect, 4f / 3f, 0.1f)) return "4:3";
        else if (Approximately(aspect, 16f / 9f, 0.1f)) return "16:9";
        else if (Approximately(aspect, 16f / 10f, 0.1f)) return "16:10";
        else return "Unknown";
    }

    /// <summary>
    /// Tries to begin changing the window's resolution. Changing the resolution may take a few frames. Returns false 
    /// if the change could not be made because the controller is not initialized, index is not valid, resolution would
    /// be unchanged, or a command is being processed.
    /// </summary>
    /// <param name="desiredResolutionIndex">The index of the resolution in the SortedResolutions array property.</param>
    public bool TryChangeResolution(int desiredResolutionIndex)
    {
        // not initialized
        if (!_initialized) return false;

        // improper index
        if (desiredResolutionIndex < 0 || desiredResolutionIndex >= SortedResolutions.Length) return false;

        // already at resolution
        if (_currentResolutionIndex == desiredResolutionIndex) return false;

        // currently changing
        if (IsChangingDisplay) return false;

        // start a coroutine to change it
        _resolutionRoutine = ChangeResolutionRoutine(desiredResolutionIndex);
        StartCoroutine(_resolutionRoutine);

        return true;
    }

    /// <summary>
    /// Tries to begin changing the window's display mode. Changing the display mode may take a few frames. Returns false 
    /// if the change could not be made because the controller is not initialized, display mode would be unchanged, or
    /// a command is being processed.
    /// </summary>
    public bool TryChangeDisplayMode(DisplayModes desiredDisplayMode)
    {
        // not initialized
        if (!_initialized) return false;

        // already at display mode
        if (_currentDisplayMode == desiredDisplayMode) return false;

        // currently changing
        if (_displayModeRoutine != null) return false;

        // start a coroutine to change it
        _displayModeRoutine = ChangeDisplayModeRoutine(desiredDisplayMode);
        StartCoroutine(_displayModeRoutine);

        return true;
    }

    /// <summary>
    /// Tries to change the window's override position value. Changing the position should be instant. Returns false if
    /// the change could not be made because the window would not be moved.
    /// </summary>
    public bool TryChangeOverridePosition(Position desiredOverridePosition)
    {
        // already at override position
        if (_currentOverridePosition.X == desiredOverridePosition.X && _currentOverridePosition.Y == desiredOverridePosition.Y) return false;

        // change it
        ChangeOverridePosition(desiredOverridePosition);

        return true;
    }

    /// <summary>
    /// Toggles full screen. When switching out of fullscreen, we use the last non-fullscreen display type.
    /// </summary>
    public void ToggleFullscreen()
    {
        if (_currentDisplayMode == DisplayModes.Borderless || _currentDisplayMode == DisplayModes.Windowed)
        {
            TryChangeDisplayMode(DisplayModes.Fullscreen);
        }
        else if (_currentDisplayMode == DisplayModes.Fullscreen)
        {
            TryChangeDisplayMode(_previousDisplayMode);
        }
    }

    /// <summary>
    /// Clears any saved data used by this controller.
    /// </summary>
    public void ClearSaveData()
    {
        PlayerPrefs.DeleteKey(USE_OVERRIDE_POSITION_KEY);
        PlayerPrefs.DeleteKey(CURRENT_OVERRIDE_POSITION_X_KEY);
        PlayerPrefs.DeleteKey(CURRENT_OVERRIDE_POSITION_Y_KEY);
        PlayerPrefs.DeleteKey(CURRENT_DISPLAY_MODE_KEY);
        PlayerPrefs.DeleteKey(PREVIOUS_DISPLAY_MODE_KEY);
        PlayerPrefs.DeleteKey(CURRENT_RESOLUTION_INDEX_KEY);
    }

    /// <summary>
    /// Saves data used by this controller.
    /// </summary>
    public void Save()
    {
        SaveUseOverridePosition();
        SaveCurrentPositionOverride();
        SaveCurrentDisplayMode();
        SaveCurrentWindowPosition();
        SaveCurrentResolutionIndex();
    }
	#endregion
	
	#region Private Variables
    private Resolution[] _sortedResolutions;
    private IEnumerator _displayModeRoutine;
    private IEnumerator _resolutionRoutine;
    private bool _initialized;
    private DisplayModes _currentDisplayMode;
    private int _currentResolutionIndex; 
    private Position _currentOverridePosition;
    private Position? _currentWindowPosition;
    private bool _useOverridePosition;
    private DisplayModes _previousDisplayMode = DisplayModes.Windowed;

    // windows
    #if UNITY_STANDALONE_WIN
    #pragma warning disable 0649 // Editor compiler registers this member despite the compiler flags and throws a "never used" warning. This hides it.
    private WindowHandler _windowsHandler;
    #pragma warning restore 0649
    #endif

    #endregion

    #region Private Properties
    #endregion

    #region Private Methods
    private void Awake()
    {
        // we don't use this controller in the editor
        #if UNITY_EDITOR
            enabled = false;
            return;
        #endif

        // builds only
        #if !UNITY_EDITOR
            #if UNITY_STANDALONE_WIN
            _windowsHandler = new WindowHandler(Game.Name);
            #endif

            InitializeDisplay();
        #endif
    }

    #if UNITY_EDITOR
    private void OnEnable()
    {
        enabled = false;
        Debug.LogWarning("Resolution Controller cannot be used in the Editor. Disabled.");
    }
    #endif

    private void InitializeDisplay()
    {
        // load
        _useOverridePosition = LoadUseOverridePosition();
        _previousDisplayMode = LoadPreviousDisplayMode();
        _currentWindowPosition = TryLoadWindowPosition();

        // try to load last settings
        int? lastResolutionIndex = TryLoadResolution();
        DisplayModes? lastDisplayMode = TryLoadDisplayMode();
        Position? lastOverridePosition = TryLoadOverridePosition();

        StartCoroutine(InitializeRoutine(lastResolutionIndex, lastDisplayMode, lastOverridePosition));
    }

    private IEnumerator InitializeRoutine(int? targetResolutionIndex, DisplayModes? targetDisplayMode, Position? targetOverridePosition)
    {
        // set the override position, don't update the window yet
        ChangeOverridePosition(targetOverridePosition.HasValue ? targetOverridePosition.Value : _defaultOverridePosition, false);

        // set the resolution, don't update the window yet
        _resolutionRoutine = ChangeResolutionRoutine(targetResolutionIndex.HasValue ? targetResolutionIndex.Value : GetDefaultResolutionIndex(), false);
        yield return StartCoroutine(_resolutionRoutine);

        // set the display mode, allows window to update (finally)
        _displayModeRoutine = ChangeDisplayModeRoutine(targetDisplayMode.HasValue ? targetDisplayMode.Value : GetDefaultDisplayMode());
        yield return StartCoroutine(_displayModeRoutine);

        _initialized = true;
    }

    private int GetDefaultResolutionIndex()
    {
        // if set, we will try to use the desktop's native resolution as the default resolution,
        // unless we cannot determine it or it is (somehow) not an available resolution
        if (_guessBestDefaultResolution)
        {
            Resolution? desktopResolution = GetDesktopResolution();

            // find it
            if (desktopResolution.HasValue)
            {
                for (int i = 0; i < SortedResolutions.Length; i++)
                {
                    bool sameWidth = SortedResolutions[i].width == desktopResolution.Value.width;
                    bool sameHeight = SortedResolutions[i].height == desktopResolution.Value.height;
                    if (sameWidth && sameHeight) return i;
                }
            }
        }

        // fallback to the first sorted resolution index
        return 0;
    }

    private DisplayModes GetDefaultDisplayMode()
    {
        // default to borderless mode
        return DisplayModes.Borderless;
    }

    private void Update()
    {
        // in windowed mode, when not using an override position, it's useful if we record the 
        // window's position every frame and place the borderless window there when we toggle
        TryRecordWindowPosition();

        // it is useful to have a keybind to toggle into/out of fullscreen mode, especially if you
        // accidentally move the window off-screen in a windowed mode or with the override position
        QueryToggleFullscreen();
    }

    private bool TryRecordWindowPosition()
    {
        // don't record when the display is changing as positioning can occur over multiple frames
        if (IsChangingDisplay) return false;

        // don't record window position if we aren't strictly in windowed (bordered) mode
        if (_currentDisplayMode != DisplayModes.Windowed) return false;

        // don't record window position if we are in override position mode
        if (_useOverridePosition) return false;

        // don't record window position if it is currently centered
        #if UNITY_STANDALONE_WIN
        if (_windowsHandler.GetCenteredPosition(CurrentResolution, CurrentDisplayMode) == _windowsHandler.GetWindowPosition())
        {
            return false;
        }
        #endif

        // record it
        RecordWindowPosition();

        return true;
    }

    private void RecordWindowPosition()
    {
        // windows
        #if UNITY_STANDALONE_WIN
        _currentWindowPosition = _windowsHandler.GetWindowPosition();
        SaveCurrentWindowPosition();
        #endif
    }

    private void QueryToggleFullscreen()
    {
        // windows [LeftAlt + Enter] or [F11]
        #if UNITY_STANDALONE_WIN
        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.F11))
        {
            ToggleFullscreen();
        }
        #endif

        // osx [Command + LeftShift + F]
        #if UNITY_STANDALONE_OSX
        if (Input.GetKey(KeyCode.LeftCommand) && Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.F))
        {
            ToggleFullscreen();
        }
        #endif
    }
    
    private void UpdateWindow()
    {
        bool isWindowed = _currentDisplayMode == DisplayModes.Borderless || _currentDisplayMode == DisplayModes.Windowed;
        bool setPosition = UseOverridePosition || isWindowed && _currentWindowPosition.HasValue;
        Position? position = UseOverridePosition ? CurrentOverridePosition : _currentWindowPosition;

        // windows
        #if UNITY_STANDALONE
        _windowsHandler.TrySetDisplay(_currentDisplayMode, CurrentResolution, setPosition, position);
        #endif
    }

    private IEnumerator ChangeDisplayModeRoutine(DisplayModes targetDisplayMode, bool updateWindow = true)
    {
        // set current display mode as the previous display mode, and
        // set target display mode as the current display mode
        _previousDisplayMode = _currentDisplayMode;
        _currentDisplayMode = targetDisplayMode;

        // save
        SavePreviousDisplayMode();
        SaveCurrentDisplayMode();

        // set full/windowed, this resets the renderer
        bool rendererReset;
        switch (targetDisplayMode)
        {
            case DisplayModes.Fullscreen:
                rendererReset = Screen.fullScreen != true;
                Screen.fullScreen = true;
                break;

            case DisplayModes.Borderless:
            case DisplayModes.Windowed:
            default:
                rendererReset = Screen.fullScreen != false;
                Screen.fullScreen = false;
                break;
        }

        // wait until the next frame while the renderer resets (http://docs.unity3d.com/ScriptReference/Screen-fullScreen.html)
        if (rendererReset) yield return null;

        // update the window's frame, position, size, etc.
        if (updateWindow) UpdateWindow();

        // clear the routine handler
        _displayModeRoutine = null;
    }

    private IEnumerator ChangeResolutionRoutine(int targetResolutionIndex, bool updateWindow = true)
    {
        // set target resolution index as current resolution index
        _currentResolutionIndex = targetResolutionIndex;
        SaveCurrentResolutionIndex();

        // set resolution, if we are full screen this resets the renderer
        bool rendererReset = IsExclusiveFullscreen;
        Screen.SetResolution(CurrentResolution.width, CurrentResolution.height, IsExclusiveFullscreen);

        // wait until the next frame while the renderer resets (http://docs.unity3d.com/ScriptReference/Screen-fullScreen.html)
        if (rendererReset) yield return null;

        // reset window position if the resolution changes (no effect on override position)
        if (_newResolutionResetsPosition)
        {
            _currentWindowPosition = null;
            updateWindow &= true;
        }

        // update window, incase it changed
        if (updateWindow) UpdateWindow();

        // clear the routine handler
        _resolutionRoutine = null;
    }

    private void ChangeUseOverridePosition(bool targetUseOverridePosition, bool updateWindow = true)
    {
        // set target use override position as use override position
        _useOverridePosition = targetUseOverridePosition;

        // update window, incase it changed
        if (updateWindow) UpdateWindow();
    }

    private void ChangeOverridePosition(Position targetOverridePosition, bool updateWindow = true)
    {
        // set target override position as override position
        _currentOverridePosition.X = targetOverridePosition.X;
        _currentOverridePosition.Y = targetOverridePosition.Y;

        // update window, incase it changed
        if (updateWindow) UpdateWindow();
    }

    private bool Approximately(float f1, float f2, float diff)
    {
        return Mathf.Abs(f2 - f1) < diff;
    }

    private float Round(float f, float digits)
    {
        float factor = Mathf.Pow(10, digits);
        return Mathf.Round(f * factor) / factor;
    }

    #region Save & Load
    // Some example code for saving & loading. You will probably want to replace this code
    // with your own system.

    // Save & load _useOverridePosition
    private const string USE_OVERRIDE_POSITION_KEY = "_useOverridePosition";
    private bool LoadUseOverridePosition()
    {
        return PlayerPrefs.GetInt(USE_OVERRIDE_POSITION_KEY, 0) == 1;
    }

    private void SaveUseOverridePosition()
    {
        PlayerPrefs.SetInt(USE_OVERRIDE_POSITION_KEY, _useOverridePosition ? 1 : 0);
        PlayerPrefs.Save();
    }

    // Save & load _currentOverridePosition
    private const string CURRENT_OVERRIDE_POSITION_X_KEY = "_currentOverridePosition.Value.X";
    private const string CURRENT_OVERRIDE_POSITION_Y_KEY = "_currentOverridePosition.Value.Y";
    private Position? TryLoadOverridePosition()
    {
        if (PlayerPrefs.HasKey(CURRENT_OVERRIDE_POSITION_X_KEY) && PlayerPrefs.HasKey(CURRENT_OVERRIDE_POSITION_Y_KEY))
        {
            return new Position(PlayerPrefs.GetInt(CURRENT_OVERRIDE_POSITION_X_KEY), PlayerPrefs.GetInt(CURRENT_OVERRIDE_POSITION_Y_KEY));
        }
        else
        {
            return null;
        }
    }

    private void SaveCurrentPositionOverride()
    {
        PlayerPrefs.SetInt(CURRENT_OVERRIDE_POSITION_X_KEY, _currentOverridePosition.X);
        PlayerPrefs.SetInt(CURRENT_OVERRIDE_POSITION_Y_KEY, _currentOverridePosition.Y);
        PlayerPrefs.Save();
    }

    // Save & load _currentWindowPosition
    private const string CURRENT_WINDOW_POSITION_X_KEY = "_currentWindowPosition.Value.X";
    private const string CURRENT_WINDOW_POSITION_Y_KEY = "_currentWindowPosition.Value.Y";
    private Position? TryLoadWindowPosition()
    {
        if (PlayerPrefs.HasKey(CURRENT_WINDOW_POSITION_X_KEY) && PlayerPrefs.HasKey(CURRENT_WINDOW_POSITION_Y_KEY))
        {
            return new Position(PlayerPrefs.GetInt(CURRENT_WINDOW_POSITION_X_KEY), PlayerPrefs.GetInt(CURRENT_WINDOW_POSITION_Y_KEY));
        }
        else
        {
            return null;
        }
    }

    private void SaveCurrentWindowPosition()
    {
        if (_currentWindowPosition.HasValue)
        {
            PlayerPrefs.SetInt(CURRENT_WINDOW_POSITION_X_KEY, _currentWindowPosition.Value.X);
            PlayerPrefs.SetInt(CURRENT_WINDOW_POSITION_Y_KEY, _currentWindowPosition.Value.Y);
        }
        else
        {
            PlayerPrefs.DeleteKey(CURRENT_WINDOW_POSITION_X_KEY);
            PlayerPrefs.DeleteKey(CURRENT_WINDOW_POSITION_Y_KEY);
        }
        PlayerPrefs.Save();
    }

    // Save & load _currentDisplayMode
    private const string CURRENT_DISPLAY_MODE_KEY = "_currentDisplayMode";
    private DisplayModes? TryLoadDisplayMode()
    {
        if (PlayerPrefs.HasKey(CURRENT_DISPLAY_MODE_KEY))
        {
            return (DisplayModes)PlayerPrefs.GetInt(CURRENT_DISPLAY_MODE_KEY);
        }
        else
        {
            return null;
        }
    }

    private void SaveCurrentDisplayMode()
    {
        PlayerPrefs.SetInt(CURRENT_DISPLAY_MODE_KEY, (int)_currentDisplayMode);
        PlayerPrefs.Save();
    }

    // Save & load _previousDisplayMode
    private const string PREVIOUS_DISPLAY_MODE_KEY = "_previousDisplayMode";
    private DisplayModes LoadPreviousDisplayMode()
    {
        if (PlayerPrefs.HasKey(PREVIOUS_DISPLAY_MODE_KEY))
        {
            return (DisplayModes)PlayerPrefs.GetInt(PREVIOUS_DISPLAY_MODE_KEY);
        }
        else
        {
            // it's overkill to define a default previous display mode
            return DisplayModes.Windowed;
        }
    }

    private void SavePreviousDisplayMode()
    {
        PlayerPrefs.SetInt(PREVIOUS_DISPLAY_MODE_KEY, (int)_previousDisplayMode);
        PlayerPrefs.Save();
    }

    // Save & load _currentResolutionIndex
    private const string CURRENT_RESOLUTION_INDEX_KEY = "_currentResolutionIndex";
    private int? TryLoadResolution()
    {
        if (PlayerPrefs.HasKey(CURRENT_RESOLUTION_INDEX_KEY))
        {
            return PlayerPrefs.GetInt(CURRENT_RESOLUTION_INDEX_KEY);
        }
        else
        {
            return null;
        }
    }

    private void SaveCurrentResolutionIndex()
    {
        PlayerPrefs.SetInt(CURRENT_RESOLUTION_INDEX_KEY, _currentResolutionIndex);
        PlayerPrefs.Save();
    }
    #endregion

    /// <summary>
    /// Sorts resolutions by fattest, aspect ratio and descending resolution area.
    /// </summary>
    private Resolution[] Sort(Resolution[] resolutions)
    {
        return resolutions.OrderByDescending(r => Round((float)r.width / (float)r.height, 1)).ThenByDescending(r => r.width * r.height).ToArray();
    }
	#endregion

    #region Classes
    public struct Position
    {
        public int X;
        public int Y;

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format("{0:F1}, {1:F1}", this.X, this.Y);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Position)) return false;

            Position position = (Position)obj;

            return this.X == position.X && this.Y == position.Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        public static bool operator ==(Position position1, Position position2)
        {
            return Equals(position1, position2);
        }

        public static bool operator !=(Position position1, Position position2)
        {
            return !Equals(position1, position2);
        }
    }

    // windows
    #if UNITY_STANDALONE_WIN
    public static class Flags
    {
        public static void Set<T>(ref T mask, T flag) where T : struct
        {
            int maskValue = (int)(object)mask;
            int flagValue = (int)(object)flag;

            mask = (T)(object)(maskValue | flagValue);
        }

        public static void Unset<T>(ref T mask, T flag) where T : struct
        {
            int maskValue = (int)(object)mask;
            int flagValue = (int)(object)flag;

            mask = (T)(object)(maskValue & (~flagValue));
        }

        public static void Toggle<T>(ref T mask, T flag) where T : struct
        {
            if (Contains(mask, flag))
            {
                Unset<T>(ref mask, flag);
            }
            else
            {
                Set<T>(ref mask, flag);
            }
        }

        public static bool Contains<T>(T mask, T flag) where T : struct
        {
            return Contains((int)(object)mask, (int)(object)flag);
        }

        public static bool Contains(int mask, int flag)
        {
            return (mask & flag) != 0;
        }
    }

    public class WindowHandler
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        // import methods
        [DllImport("user32.dll", EntryPoint="SetWindowLong", SetLastError=true, CharSet=CharSet.Auto)]
        public static extern IntPtr SetWindowLongPtr(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "GetWindowLong", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError=true)]
        public static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        [DllImport("user32.dll", EntryPoint = "GetDesktopWindow", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll", EntryPoint = "SetWindowPos", SetLastError=true)]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int uFlags);

        [DllImport("user32.dll", EntryPoint = "GetWindowRect", SetLastError = true)]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT rect);

        [DllImport("user32.dll", EntryPoint = "GetClientRect", SetLastError = true)]
        public static extern bool GetClientRect(IntPtr hWnd, out RECT rect);

        // constructor
        public WindowHandler(string title)
        {
            _title = title;
        }

        public Resolution? GetDesktopResolution()
        {
            RECT desktopRect;

            if (GetWindowRect(Desktop, out desktopRect))
            {
                var resolution = new Resolution();
                resolution.width = desktopRect.Right - desktopRect.Left;
                resolution.height = desktopRect.Bottom - desktopRect.Top;
                return resolution;
            }
            else
            {
                return null;
            }
        }

        public Position? GetWindowPosition()
        {
            // window rect
            RECT windowRect;
            if (!GetWindowRect(Window, out windowRect)) return null;

            // the position
            return new Position(windowRect.Left, windowRect.Top);
        }

        public Position? GetCenteredPosition(Resolution resolution, DisplayModes displayMode)
        {
            // desktop rect
            RECT desktopRect;
            if (!GetWindowRect(Desktop, out desktopRect)) return null;
            int desktopWidth = desktopRect.Right - desktopRect.Left;
            int desktopHeight = desktopRect.Bottom - desktopRect.Top;

            // determine the centered position for the specified resolution
            int xPos, yPos;
            if (displayMode == DisplayModes.Windowed)
            {
                xPos = (desktopWidth - (resolution.width + _borderWidth * 2)) / 2;
                yPos = (desktopHeight - (resolution.height + _borderWidth * 2 + _captionHeight)) / 2;
            }
            else
            {
                xPos = (desktopWidth - resolution.width) / 2;
                yPos = (desktopHeight - resolution.height) / 2;
            }

            return new Position(xPos, yPos);
        }

        public bool TrySetDisplay(DisplayModes targetDisplayMode, Resolution targetResolution, bool setPosition, Position? position)
        {
            // setup
            int flags = (int)GetWindowLongPtr(Window, GWL_STYLE);

            // handle each target display mode separately
            switch (targetDisplayMode)
            {
                // fullscreen
                case DisplayModes.Fullscreen:
                    return true;

                // borderless
                case DisplayModes.Borderless:
                    // make borderless
                    Flags.Unset<int>(ref flags, WS_CAPTION);
                    SetWindowLongPtr(Window, GWL_STYLE, flags);

                    // if we don't have a specified position, use the centered position; its important that
                    // the window has the appropriate final framing before getting the centered position.
                    if (!(setPosition && position.HasValue)) position = GetCenteredPosition(targetResolution, targetDisplayMode);

                    // position & resize the window
                    UpdateWindowRect(Window, position.Value.X, position.Value.Y, targetResolution.width, targetResolution.height);

                    // ensures that the window is still borderless after positioning & resizing
                    SetWindowLongPtr(Window, GWL_STYLE, flags);
                    SetWindowLongPtr(Window, GWL_STYLE, flags);     //  --- READ ME, IMPORTANT ---
                    //UpdateWindowStyle(Window);                    // Problem: UpdateWindowStyle does not properly update the window 
                                                                    // here, it instead seems to cause the window styles to be reset.
                                                                    // I've found that a secondary call to SetWindowLongPtr does 
                                                                    // in fact update the window properly.
                                                                    //
                                                                    // Speculation: Unity may have hooked into some callbacks which take 
                                                                    // place after SetWindowPos() is called that control the window style.
                                                                    // http://stackoverflow.com/questions/2940689/removing-ws-border-and-ws-caption-from-windows-styles-doesnt-work

                    return true;

                // windowed
                case DisplayModes.Windowed:
                    // make bordered
                    Flags.Set<int>(ref flags, WS_CAPTION);
                    SetWindowLongPtr(Window, GWL_STYLE, flags);
                    UpdateDecorationSize(Window);

                    // if we don't have a specified position, use the centered position; its important that
                    // the window has the appropriate final framing before getting the centered position.
                    if (!(setPosition && position.HasValue)) position = GetCenteredPosition(targetResolution, targetDisplayMode);

                    // its important that the window viewport is equal to the desired resolution to avoid 
                    // stretching, so the window size includes the decoration sizes
                    int windowWidth = targetResolution.width + _borderWidth * 2;
                    int windowHeight = targetResolution.height + _captionHeight + _borderWidth * 2;

                    // position & resize the window
                    UpdateWindowRect(Window, position.Value.X, position.Value.Y, windowWidth, windowHeight);

                    return true;

                // other
                case DisplayModes.Unknown:
                default:
                    return false;
            }
        }

        // properties
        private IntPtr Window
        {
            get
            {
                return FindWindowByCaption(IntPtr.Zero, _title);
            }
        }

        private IntPtr Desktop
        {
            get
            {
                return GetDesktopWindow();
            }
        }

        // style flags
        private const int
            WS_BORDER = 0x00800000,
            WS_CAPTION = 0x00C00000,
            WS_CHILD = 0x40000000,
            WS_CHILDWINDOW = 0x40000000,
            WS_CLIPCHILDREN = 0x02000000,
            WS_CLIPSIBLINGS = 0x04000000,
            WS_DISABLED = 0x08000000,
            WS_DLGFRAME = 0x00400000,
            WS_GROUP = 0x00020000,
            WS_HSCROLL = 0x00100000,
            WS_ICONIC = 0x20000000,
            WS_MAXIMIZE = 0x01000000,
            WS_MAXIMIZEBOX = 0x00010000,
            WS_MINIMIZE = 0x20000000,
            WS_MINIMIZEBOX = 0x00020000,
            WS_OVERLAPPED = 0x00000000,
            WS_OVERLAPPEDWINDOW = WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX,
            WS_POPUP = unchecked((int)0x80000000),
            WS_POPUPWINDOW = WS_POPUP | WS_BORDER | WS_SYSMENU,
            WS_SIZEBOX = 0x00040000,
            WS_SYSMENU = 0x00080000,
            WS_TABSTOP = 0x00010000,
            WS_THICKFRAME = 0x00040000,
            WS_TILED = 0x00000000,
            WS_TILEDWINDOW = WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX,
            WS_VISIBLE = 0x10000000,
            WS_VSCROLL = 0x00200000;

        // extended style flags
        private const int
            WS_EX_DLGMODALFRAME = 0x00000001,
            WS_EX_CLIENTEDGE = 0x00000200,
            WS_EX_STATICEDGE = 0x00020000;

        // position flags
        private const int
            SWP_FRAMECHANGED = 0x0020,
            SWP_NOMOVE = 0x0002,
            SWP_NOSIZE = 0x0001,
            SWP_NOZORDER = 0x0004,
            SWP_NOOWNERZORDER = 0x0200,
            SWP_SHOWWINDOW = 0x0040,
            SWP_NOSENDCHANGING = 0x0400;

        // index for style and extended style flag management
        private const int
            GWL_STYLE = -16,
            GWL_EXSTYLE = -20;

        // members
        private string _title;
        private int _borderWidth;
        private int _captionHeight;

        /// <summary>
        /// Gets the window's current decoration size. If the window is in borderless mode, the results will be 0.
        /// </summary>
        private bool UpdateDecorationSize(IntPtr window)
        {
            // window and client rects
            RECT windowRect, clientRect;
            if (!GetWindowRect(Window, out windowRect)) return false;
            if (!GetClientRect(Window, out clientRect)) return false;

            // calculate decoration size
            int decorationWidth = (windowRect.Right - windowRect.Left) - (clientRect.Right - clientRect.Left);
            int decorationHeight = (windowRect.Bottom - windowRect.Top) - (clientRect.Bottom - clientRect.Top);

            // some important assumptions are made here:
            // 1) the window's frame only has border on the left and right
            // 2) the window's frame only has an equal thickness border on the bottom
            _borderWidth = decorationWidth / 2;
            _captionHeight = decorationHeight - _borderWidth * 2;

            return true;
        }

        private void UpdateWindowRect(IntPtr window, int x, int y, int width, int height)
        {
            SetWindowPos(window, -2, x, y, width, height, SWP_FRAMECHANGED);
        }

        /// <summary>
        /// Use this after calling one of the window's API functions to test if the method
        /// produced any errors.
        /// </summary>
        /// <param name="result">The return value of the window's API function.</param>
        private bool TestForErrors(IntPtr result)
        {
            if (result == IntPtr.Zero)
            {
                int errorCode = Marshal.GetLastWin32Error();
                if (errorCode != 0)
                {
                    Debug.LogError("Error " + errorCode.ToString() + " occured. SetDisplayMode failed.");
                    return true;
                }
            }

            return false;
        }
    }
    #endif
    #endregion
}