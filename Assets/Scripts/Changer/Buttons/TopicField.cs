namespace Shadow.SchoolGame.Changer.Buttons {
  using Loaders;
  using Game.Data;
  using Controllers;
  using UnityEngine;
  using UnityEngine.UI;

  public class TopicField : MonoBehaviour {
    public TopicData data;

    void Start() {
      InputField inp = GetComponentInChildren<InputField>();
      inp.text = data.name;
    }

    public void NameChange(string newName) {
      QuestionLoader.ChangeTopic(data, newName);
    }

    public void Edit() {
      Loader.currentTopic = data;
      TopicController.inst.valCont.SetActive(true);
      TopicController.inst.gameObject.SetActive(false);
    }

    public void Delete() {
      QuestionLoader.DeleteTopic(data);
      TopicController.inst.content.RemoveContent(GetComponent<LayoutElement>());
    }
  }
}