namespace Shadow.SchoolGame.Changer {
  using Utils;
  using System.IO;
  using Game.Data;
  using UnityEngine;
  using UnityEngine.UI;

  public class AnswerEdit : MonoBehaviour {
    public AnswerData data;
    public InputField answer;
    public Toggle correct;
    public InputField image;

    public void AnswerChange(string a) {
      data.answer = a;
    }
    
    public void ImageChange(string i) {
      data.image = i;
      if(File.Exists(Extensions.LocalizeInTopic(Loader.currentTopic, data.image))) {
        image.textComponent.color = Color.green;
        data.spr = Extensions.LoadSprite(Extensions.LocalizeInTopic(Loader.currentTopic, data.image));
      } else {
        image.textComponent.color = Color.red;
      }
    }

    public void Correct(bool c) {
      data.correct = c;
    }
  }
}