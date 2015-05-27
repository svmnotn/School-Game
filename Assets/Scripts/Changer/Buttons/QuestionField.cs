namespace Shadow.SchoolGame.Changer.Buttons {
  using Loaders;
  using Game.Data;
  using Controllers;
  using UnityEngine;
  using UnityEngine.UI;

  public class QuestionField : MonoBehaviour {
    public QuestionData data;

    void Start() {
      Text txt = transform.FindChild("Question").GetComponentInChildren<Text>();
      var s = "\t" + (string.IsNullOrEmpty(data.question) ? "IMAGE BASED QUESTION" : data.question);
      int i = 1;
      foreach(var ans in data.answers) {
        s += "\n\t\t";
        s += i++ + ") ";
        s += (string.IsNullOrEmpty(ans.answer) ? "IMAGE BASED ANSWER" : ans.answer);
      }
      txt.text = s;
    }

    public void Edit() {
      Loader.currentQuestion = data;
      QuestionController.inst.questionAdder.SetActive(true);
      QuestionController.inst.questionEditor.SetActive(false);
    }
    
    public void Delete() {
      QuestionLoader.DeleteQuestion(data);
      Loader.currentTopic.RemoveQuestion(Loader.currentValue, data);
      QuestionController.inst.content.RemoveContent(GetComponent<LayoutElement>());
    }
  }
}