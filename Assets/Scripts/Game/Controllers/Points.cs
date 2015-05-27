namespace Shadow.SchoolGame.Game.Controllers {
  using Data;
  using Utils;
  using Buttons;
  using UnityEngine;
  using System.Collections.Generic;

  public class Points : MonoBehaviour {
    public static Points inst;
    public PointButton button;
    
    void Awake() {
      inst = this;
    }

    List<int> vals;

    TopicData Random() {
      int i = vals.ToArray()[0];
      vals.Remove(i);
      var d = Core.topics.ToArray()[i];
      if(d == null || !d.HasQuestions()) {
        return Random();
      }
      return d;
    }

    void OnEnable() {
      if(Core.inst.TopicsLeft() > 0) {
        if(Core.data.currentTopic == null) {
          vals = new List<int>(System.Linq.Enumerable.Range(0, Core.topics.Count));
          vals.Shuffle();
          Core.data.currentTopic = Random();
        }
        foreach(int val in Core.data.currentTopic.questions.Keys) {
          var bttn = Instantiate(button);
          bttn.value = val;
          bttn.transform.SetParent(transform, false);
        }
      } else {
        Core.inst.over.SetActive(true);
        Core.inst.pntSelect.SetActive(false);
      }
    }

    void OnDisable() {
      vals = null;
      foreach(Transform child in transform) {
        GameObject.Destroy(child.gameObject);
      }
    }
  }
}