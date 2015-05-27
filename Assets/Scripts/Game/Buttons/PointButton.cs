namespace Shadow.SchoolGame.Game.Buttons {
  using Data;
  using System;
  using UnityEngine;
  using UnityEngine.UI;

  public class PointButton : MonoBehaviour {
    public int value;
    CurrentData data;

    void Start() {
      data = Core.data;
      var txt = GetComponentInChildren<Text>();
      var enable = data.currentTopic.HasQuestions(value);
      GetComponent<Button>().enabled = enable;
      txt.text = Convert.ToString(value) + (enable ? "" : " - No Questions Left");
    }

    public void Click() {
      data.currentValue = value;
      data.currentQuestion = data.currentTopic.GetQuestion(value);
      Core.inst.question.SetActive(true);
      Core.inst.pntSelect.SetActive(false);
    } 
  }
}