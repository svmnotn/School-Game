namespace Shadow.SchoolGame.Changer.Controllers {
  using Utils;
  using Buttons;
  using Loaders;
  using UnityEngine;
  
  public class ValueController : MonoBehaviour {
    public static ValueController inst;
    public GameObject qCont;
    public ScrollContentFitter content;

    void Awake() {
      inst = this;
    }

    void Update() {
      if(Input.GetKeyDown(KeyCode.F5)) {
        content.Clear();
        QuestionLoader.LoadValues(QuestionLoader.DirFromName(Loader.currentTopic.name), out Loader.currentTopic.questions);
        foreach(int val in Loader.currentTopic.questions.Keys) {
          var t = AddValueField();
          t.value = val;
        }
      }
    }
    
    void OnEnable() {
      foreach(int val in Loader.currentTopic.questions.Keys) {
        var t = AddValueField();
        t.value = val;
      }
    }
    
    void OnDisable() {
      content.Clear();
    }
    
    ValueField AddValueField() {
      return content.ReturnAddedContent().GetComponent<ValueField>();
    }

    public void AddValue() {
      AddValueField();
    }
  }
}