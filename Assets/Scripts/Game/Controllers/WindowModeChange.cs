namespace Shadow.SchoolGame.Game.Controllers {
  using UnityEngine;
  using UnityEngine.UI;

  public class WindowModeChange : MonoBehaviour {
    public ResolutionController controller;
    public Toggle fullscreen;
    public Toggle borderless;
    public Toggle windowed;

    void Start() {
      fullscreen.isOn = controller.CurrentDisplayMode == ResolutionController.DisplayModes.Fullscreen;
      borderless.isOn = controller.CurrentDisplayMode == ResolutionController.DisplayModes.Borderless;
      windowed.isOn = controller.CurrentDisplayMode == ResolutionController.DisplayModes.Windowed;
    }

    public void Fullscreen(bool on) {
      if(on) {
        controller.TryChangeDisplayMode(ResolutionController.DisplayModes.Fullscreen);
      }
    }

    public void Borderless(bool on) {
      if(on) {
        controller.TryChangeDisplayMode(ResolutionController.DisplayModes.Borderless);
      }
    }

    public void Windowed(bool on) {
      if(on) {
        controller.TryChangeDisplayMode(ResolutionController.DisplayModes.Windowed);
      }
    }
  }
}