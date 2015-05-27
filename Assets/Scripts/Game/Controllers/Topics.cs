namespace Shadow.SchoolGame.Game.Controllers {
  using Data;
  using Buttons;
  using UnityEngine;

  public class Topics : MonoBehaviour {
    public static Topics inst;
    public TopicButton button;

    void Awake() {
      inst = this;
    }

    void OnEnable() {
      if(Core.inst.TopicsLeft() > 0) {
        foreach(TopicData d in Core.topics) {
          if(d != null) {
            var bttn = Instantiate(button);
            bttn.data = d;
            bttn.transform.SetParent(transform, false);
          }
        }
      } else {
        Core.inst.over.SetActive(true);
        Core.inst.catSelect.SetActive(false);
      }
    }

    void OnDisable() {
      foreach(Transform child in transform) {
        GameObject.Destroy(child.gameObject);
      }
    }
  }
}