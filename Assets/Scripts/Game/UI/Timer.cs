namespace Shadow.SchoolGame.Game.UI {
  using Utils;
  using UnityEngine;
  using UnityEngine.UI;
  using System.Collections;

  public class Timer : MonoBehaviour {
    public static Timer inst;
    Text txt;
    int wait;

    void Awake() {
      inst = this;
      txt = GetComponent<Text>();
    }

    void OnEnable() {
      Color c = new Color();
      c.a = 1;
      c.r = Settings.settings.timerColorR;
      c.g = Settings.settings.timerColorG;
      c.b = Settings.settings.timerColorB;
      txt.color = c;
      wait = Settings.settings.waitForAnswer;
      StartCoroutine("TimeKeep");
    }

    IEnumerator TimeKeep() {
      while(wait != 0) {
        txt.text = Extensions.FormatTime(wait--);
        yield return new WaitForSeconds(1);
      }
      txt.text = Extensions.FormatTime(wait);
      if(!Core.data.answered) {
        Core.inst.Answered();
        yield return new WaitForSeconds(Settings.settings.waitAfterAnswer);
      }

      if(Core.inst.TopicsLeft() > 0){
        Core.inst.result.SetActive(true);
      }else{
        Core.inst.over.SetActive(true);
      }

      Core.data.answered = false;
      Core.inst.question.SetActive(false);
    }

    public void Stop(int time) {
      if(wait > time)
        wait = time;
    }

    void OnDisable() {
      StopAllCoroutines();
    }
  }
}