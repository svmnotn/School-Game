namespace Shadow.SchoolGame.Changer.Controllers {
  using Utils;
  using Buttons;
  using Loaders;
  using Game.Data;
  using UnityEngine;
  using System.Collections.Generic;

  public class QuestionController : MonoBehaviour {
    public static QuestionController inst;
    public GameObject questionEditor;
    public GameObject questionAdder;
    public ScrollContentFitter content;
    
    void Awake() {
      inst = this;
    }

    void Load(List<QuestionData> qs) {
      content.Clear();
      foreach(var question in qs) {
        var field = AddQuestionField();
        field.data = question;
      }
    }

    void Update() {
      if(Input.GetKeyDown(KeyCode.F5)) {
        QuestionLoader.LoadValues(QuestionLoader.DirFromName(Loader.currentTopic.name), out Loader.currentTopic.questions);
        Load(Loader.currentTopic.GetQuestions(Loader.currentValue));
      }
    }

    void OnEnable() {
      var qs = Loader.currentTopic.GetQuestions(Loader.currentValue);
      if(qs.Count > 0) {
        Load(qs);
      } else {
        QuestionLoader.LoadValues(QuestionLoader.DirFromName(Loader.currentTopic.name), out Loader.currentTopic.questions);
        Load(Loader.currentTopic.GetQuestions(Loader.currentValue));
      }
    }
    
    void OnDisable() {
      content.Clear();
    }

    QuestionField AddQuestionField() {
      return content.ReturnAddedContent().GetComponent<QuestionField>();
    }

    public void AddQuestion() {
      AddQuestionField();
    }
  }
}