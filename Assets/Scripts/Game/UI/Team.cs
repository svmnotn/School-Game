namespace Shadow.SchoolGame.Game.UI {
  using Utils;
  using UnityEngine;
  using UnityEngine.UI;

  public class Team : MonoBehaviour {
    Text team;

    string TeamName {
      get {
        if(Core.data.blue) {
          return Settings.settings.blue.name;
        }
        return Settings.settings.red.name;
      }
    }

    Color TeamColor {
      get {
        Color c = new Color();
        c.a = 1;
        if(Core.data.blue) {
          c.r = Settings.settings.blue.nameColorR;
          c.g = Settings.settings.blue.nameColorG;
          c.b = Settings.settings.blue.nameColorB;
          return c;
        }
        c.r = Settings.settings.red.nameColorR;
        c.g = Settings.settings.red.nameColorG;
        c.b = Settings.settings.red.nameColorB;
        return c;
      }
    }

    void OnEnable() {
      team = GetComponent<Text>();
    }
  
    void Update() {
      team.text = TeamName + "'s turn!";
      team.color = TeamColor;
    }
  }
}