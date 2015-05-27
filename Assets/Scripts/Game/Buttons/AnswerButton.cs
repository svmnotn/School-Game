namespace Shadow.SchoolGame.Game.Buttons {
  using UI;
  using Data;
  using Utils;
  using Controllers;
  using UnityEngine;
  using UnityEngine.UI;

  public class AnswerButton : MonoBehaviour {
    public AnswerData data;
    Image i;

    void Start() {
      var txt = GetComponentInChildren<Text>();
      txt.text = string.IsNullOrEmpty(data.answer) ? "" : data.answer;
      if(string.IsNullOrEmpty(data.image)) {
        i = GetComponent<Image>();
      } else {
        i = GetComponentInChildren<Image>();
        i.sprite = data.spr;
      }
    }

    public void Click() {
      ChangeColor();
      Core.data.answered = true;
      Core.inst.Answered();
      if(data.correct) {
        Core.inst.right.Play();
        if(Core.data.blue) {
          Core.data.blueScore += Core.data.currentValue;
        } else {
          Core.data.redScore += Core.data.currentValue;
        }
      } else {
        Core.inst.wrong.Play();
      }
      Timer.inst.Stop(Settings.settings.waitAfterAnswer);
    }

    public void ChangeColor() {
      if(data.correct) {
        GetComponent<Image>().color = Color.green;
      } else {
        GetComponent<Image>().color = Color.red;
      }
    }
  }
}