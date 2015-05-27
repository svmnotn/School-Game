namespace Shadow.SchoolGame.Game.Buttons {
  using Data;
  using UnityEngine;
  using UnityEngine.UI;

  public class TopicButton : MonoBehaviour {
    public TopicData data;

    void Start() {
      var txt = GetComponentInChildren<Text>();
      int empty = 0;
      bool enable = true;
      foreach(int val in data.questions.Keys) {
        if(!data.HasQuestions(val)) {
          empty++;
        }
      }
      if(empty == data.questions.Keys.Count) {
        enable = false;
      }
      GetComponent<Button>().enabled = enable;
      txt.text = data.name + (enable ? "" : " - No Questions Left");
    }

    public void Click() {
      Core.data.currentTopic = data;
      Core.inst.pntSelect.SetActive(true);
      Core.inst.catSelect.SetActive(false);
    }


  }
}