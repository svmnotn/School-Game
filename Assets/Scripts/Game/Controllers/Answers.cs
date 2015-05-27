namespace Shadow.SchoolGame.Game.Controllers {
  using Data;
  using Utils;
  using Buttons;
  using UnityEngine;
  using UnityEngine.UI;
  using Loaders;

  public class Answers : MonoBehaviour {
    public static Answers inst;
    public LayoutElement txtBttn;
    public LayoutElement imgBttn;
    ScrollContentFitter layout;

    void Awake() {
      inst = this;
      layout = GetComponent<ScrollContentFitter>();
    }

    void OnEnable() {
      Core.data.currentQuestion.answers.Shuffle();
      int ord = 1;
      AnswerButton[] a = null;
      int i = -1;
      foreach(AnswerData d in Core.data.currentQuestion.answers) {
        d.answer = string.IsNullOrEmpty(d.answer) ? "" : ord++ + ") " + d.answer;
        if(d.spr == null) {
          var bttn = layout.ReturnAddedContent(txtBttn).gameObject.GetComponent<AnswerButton>();
          bttn.data = d;
        } else {
          if(i == -1) {
            a = layout.ReturnAddedContent(imgBttn).gameObject.GetComponentsInChildren<AnswerButton>();
            i++;
          }
          a[i++].data = d;
          if(i > 1) {
            i = -1;
          }
        }
      }
    }
    
    void OnDisable() {
      layout.Clear();
    }
  }
}