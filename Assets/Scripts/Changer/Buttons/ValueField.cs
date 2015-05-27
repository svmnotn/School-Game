namespace Shadow.SchoolGame.Changer.Buttons {
  using Loaders;
  using Controllers;
  using UnityEngine;
  using UnityEngine.UI;
  
  public class ValueField : MonoBehaviour {
    public int value;
    InputField inp;
    
    void Start() {
      inp = GetComponentInChildren<InputField>();
      inp.text = System.Convert.ToString(value);
    }
    
    public void ValueChange(string s) {
      int newValue = System.Convert.ToInt32(s);
      Loader.currentTopic.ChangeValue(value, newValue);
      QuestionLoader.ChangeValue(value, newValue);
      value = newValue;
    }
    
    public void Edit() {
      Loader.currentValue = value;
      ValueController.inst.qCont.SetActive(true);
      ValueController.inst.gameObject.SetActive(false);
    }
    
    public void Delete() {
      QuestionLoader.DeleteValue(value);
      Loader.currentTopic.questions.Remove(value);
      ValueController.inst.content.RemoveContent(GetComponent<LayoutElement>());
    }
  }
}