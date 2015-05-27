namespace Shadow.SchoolGame.Game.Controllers {
  using Data;
  using Utils;
  using UnityEngine;
  using UnityEngine.UI;
  using System.Collections;

  public class Score : MonoBehaviour {
    public static Score inst;
    public bool team1;
    public bool measure;
    public bool over;
    CurrentData data;
    Text team;

    void Awake() {
      data = Core.data;
      inst = this;
      team = GetComponent<Text>();
    }
      
    void Update() {
      if(measure) {
        if(data.blueScore > data.redScore) {
          team.text = Settings.settings.blue.name + " is Winning!" + "\n\n" + "Come on " + Settings.settings.red.name + "!";
        } else if(data.blueScore < data.redScore) {
          team.text = Settings.settings.red.name + " is Winning!" + " \n\n" + "Come on " + Settings.settings.blue.name + "!";
        } else {
          team.text = "Things are getting interesting now!\n\nThe Teams are tied!";
        }
      } else if(over) {
        if(data.blueScore > data.redScore) {
          team.text = Settings.settings.blue.name + " Won!" + "\n\n" + "Better luck next time " + Settings.settings.red.name + "!";
        } else if(data.blueScore < data.redScore) {
          team.text = Settings.settings.red.name + " Won!" + " \n\n" + "Better luck next time " + Settings.settings.blue.name + "!";
        } else {
          team.text = "You have all won,\n" +
            " This was, in fact, Not expected.\n" +
              " Feel free to pat yourselfs in the back now." +
              "\n.\n..\n...\n..\n.\n" +
              "If you want look up \"Still Alive\" by Jonathan Coulton.\n" +
              " That seems like a fitting end for an impposibility like this.";
        }
      } else {
        if(team1) {
          team.text = Settings.settings.blue.name + ": " + data.blueScore;
        } else {
          team.text = Settings.settings.red.name + ": " + data.redScore;
        }
      }
    }

    IEnumerator TimeOut() {
      if(!over) {
        yield return new WaitForSeconds(Settings.settings.waitForScore);
        switch(Core.data.mode) {
          case GameMode.Random:
            Core.data.currentTopic = null;
            Core.inst.pntSelect.SetActive(true);
            break;
          case GameMode.Topic:
            Core.inst.catSelect.SetActive(true);
            break;
        }
        Core.inst.result.SetActive(false);
      } else {
        yield return new WaitForSeconds(Settings.settings.waitForGameOver);
        Core.inst.mainMenu.SetActive(true);
        Core.inst.Reset();
        Core.inst.over.SetActive(false);
      }
    }

    void OnEnable() {
      StartCoroutine("TimeOut");
    }

    void OnDisable() {
      StopAllCoroutines();
      if(!over) {
        data.blue = !data.blue;
      }
    }
  }
}