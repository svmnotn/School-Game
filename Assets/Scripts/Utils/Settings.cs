namespace Shadow.SchoolGame.Utils {
  using System;
  using Loaders;
  using System.IO;
  using UnityEngine;
  using UnityEngine.UI;
  using Newtonsoft.Json;
  using Game.Controllers;

  public class Settings : MonoBehaviour {
    public Toggle musicPlay;
    public InputField bckgMusic;
    public Toggle rightPlay;
    public InputField rightMusic;
    public Toggle wrongPlay;
    public InputField wrongMusic;
    public InputField bgColorR;
    public InputField bgColorG;
    public InputField bgColorB;
    public InputField timerColorR;
    public InputField timerColorG;
    public InputField timerColorB;
    public InputField waitAnswer;
    public InputField waitAfterAnswer;
    public InputField waitScore;
    public InputField waitOver;
    public InputField blueName;
    public InputField blueColorR;
    public InputField blueColorG;
    public InputField blueColorB;
    public InputField redName;
    public InputField redColorR;
    public InputField redColorG;
    public InputField redColorB;

    void Awake() {
      musicPlay.isOn = settings.background;
      rightPlay.isOn = settings.rightEffect;
      wrongPlay.isOn = settings.wrongEffect;
      bckgMusic.text = settings.backgroundMusic;
      rightMusic.text = settings.rightSound;
      wrongMusic.text = settings.wrongSound;
      waitAnswer.text = Convert.ToString(settings.waitForAnswer);
      waitAfterAnswer.text = Convert.ToString(settings.waitAfterAnswer);
      waitScore.text = Convert.ToString(settings.waitForScore);
      waitOver.text = Convert.ToString(settings.waitForGameOver);
      bgColorR.text = Convert.ToString(settings.backgroundColorR);
      bgColorG.text = Convert.ToString(settings.backgroundColorG);
      bgColorB.text = Convert.ToString(settings.backgroundColorB);
      timerColorR.text = Convert.ToString(settings.timerColorR);
      timerColorG.text = Convert.ToString(settings.timerColorG);
      timerColorB.text = Convert.ToString(settings.timerColorB);
      blueName.text = settings.blue.name;
      blueColorR.text = Convert.ToString(settings.blue.nameColorR);
      blueColorG.text = Convert.ToString(settings.blue.nameColorG);
      blueColorB.text = Convert.ToString(settings.blue.nameColorB);
      redName.text = settings.red.name;
      redColorR.text = Convert.ToString(settings.red.nameColorR);
      redColorG.text = Convert.ToString(settings.red.nameColorG);
      redColorB.text = Convert.ToString(settings.red.nameColorB);
    }

    public void SetBackground(bool b) {
      settings.background = b;
    }
    
    public void SetRightEffect(bool b) {
      settings.rightEffect = b;
    }
    
    public void SetWrongEffect(bool b) {
      settings.wrongEffect = b;
    }

    public void SetBackgroundMusic(string s) {
      if(SoundLoader.Exists(s)) {
        bckgMusic.textComponent.color = Color.green;
        settings.backgroundMusic = s;
      } else {
        bckgMusic.textComponent.color = Color.red;
      }
    }
    
    public void SetRightMusic(string s) {
      if(SoundLoader.Exists(s)) {
        rightMusic.textComponent.color = Color.green;
        settings.rightSound = s;
      } else {
        rightMusic.textComponent.color = Color.red;
      }
    }
    
    public void SetWrongMusic(string s) {
      if(SoundLoader.Exists(s)) {
        wrongMusic.textComponent.color = Color.green;
        settings.wrongSound = s;
      } else {
        wrongMusic.textComponent.color = Color.red;
      }
    }
    
    public void SetWaitForAnswer(string i) {
      settings.waitForAnswer = Convert.ToInt32(i);
    }
    
    public void SetWaitAfterAnswer(string i) {
      settings.waitAfterAnswer = Convert.ToInt32(i);
    }
    
    public void SetWaitForScore(string i) {
      settings.waitForScore = Convert.ToInt32(i);
    }
    
    public void SetWaitForGameOver(string i) {
      settings.waitForGameOver = Convert.ToInt32(i);
    }

    public void SetBckgCR(string f) {
      settings.backgroundColorR = Convert.ToSingle(f);
    }
    
    public void SetBckgCG(string f) {
      settings.backgroundColorG = Convert.ToSingle(f);
    }
    
    public void SetBckgCB(string f) {
      settings.backgroundColorB = Convert.ToSingle(f);
    }

    public void SetTimerCR(string f) {
      settings.timerColorR = Convert.ToSingle(f);
    }
    
    public void SetTimerCG(string f) {
      settings.timerColorG = Convert.ToSingle(f);
    }
    
    public void SetTimerCB(string f) {
      settings.timerColorB = Convert.ToSingle(f);
    }
    
    public void SetBlue(string s) {
      settings.blue.name = s;
    }

    public void SetBlueCR(string f) {
      settings.blue.nameColorR = Convert.ToSingle(f);
    }

    public void SetBlueCG(string f) {
      settings.blue.nameColorG = Convert.ToSingle(f);
    }

    public void SetBlueCB(string f) {
      settings.blue.nameColorB = Convert.ToSingle(f);
    }

    public void SetRed(string s) {
      settings.red.name = s;
    }

    public void SetRedCR(string f) {
      settings.red.nameColorR = Convert.ToSingle(f);
    }
    
    public void SetRedCG(string f) {
      settings.red.nameColorG = Convert.ToSingle(f);
    }
    
    public void SetRedCB(string f) {
      settings.red.nameColorB = Convert.ToSingle(f);
    }

    public void Save() {
      SaveData();
      Core.inst.LoadMusic();
    }

    public static SettingsData settings;

    public static string SettingsLocation {
      get {
        return Loader.DataFolder + Path.AltDirectorySeparatorChar + "Settings.json";
      }
    }

    static JsonSerializerSettings s {
      get {
        JsonSerializerSettings tmp = new JsonSerializerSettings();
        tmp.Formatting = Formatting.Indented;
        tmp.NullValueHandling = NullValueHandling.Ignore;
        tmp.MissingMemberHandling = MissingMemberHandling.Ignore;
        tmp.DefaultValueHandling = DefaultValueHandling.Include;
        return tmp;
      }
    }

    public static void SaveData() {
      string data = JsonConvert.SerializeObject(settings, s);
      Debug.Log(data);
      File.WriteAllText(SettingsLocation, data);
    }

    public static void Load() {
      if(File.Exists(SettingsLocation)) {
        settings = JsonConvert.DeserializeObject<SettingsData>(File.ReadAllText(SettingsLocation), s);
      } else {
        settings = new SettingsData();
        SaveData();
      }
    }
  }
}