namespace Shadow.SchoolGame.Changer.Controllers {
  using Utils;
  using Buttons;
  using Loaders;
  using Game.Data;
  using UnityEngine;
  using System.Collections.Generic;

  public class TopicController : MonoBehaviour {
    public static TopicController inst;
    public GameObject valCont;
    public ScrollContentFitter content;

    void Awake() {
      inst = this;
    }

    void Update() {
      if(Input.GetKeyDown(KeyCode.F5)) {
        content.Clear();
        Loader.topics = QuestionLoader.LoadTopics();
        foreach(TopicData d in Loader.topics) {
          var t = AddTopicField();
          t.data = d;
        }
      }
    }
    
    void OnEnable() {
      foreach(TopicData d in Loader.topics) {
        var t = AddTopicField();
        t.data = d;
      }
    }
    
    void OnDisable() {
      content.Clear();
    }

    TopicField AddTopicField() {
      return content.ReturnAddedContent().GetComponent<TopicField>();
    }

    public void AddTopic() {
      var newTopic = new TopicData();
      newTopic = new TopicData();
      newTopic.name = "New Topic";
      newTopic.questions = new Dictionary<int, List<QuestionData>>();
      AddTopicField().data = newTopic;
      QuestionLoader.AddTopic(newTopic);
      Loader.topics.Add(newTopic);
    }
  }
}