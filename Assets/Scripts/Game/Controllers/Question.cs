namespace Shadow.SchoolGame.Game.Controllers {
  using UnityEngine;
  using UnityEngine.UI;

  public class Question : MonoBehaviour {
    public Text question;
    public Image image;

    public void OnEnable() {
      question.text = Core.data.currentQuestion.question;
      if(Core.data.currentQuestion.spr != null) {
        image.enabled = true;
        image = GetComponentInChildren<Image>();
        image.sprite = Core.data.currentQuestion.spr;
      }
    }

    public void OnDisable() {
      image.overrideSprite = null;
      image.enabled = false;
    }
  }
}