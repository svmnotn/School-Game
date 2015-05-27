namespace Shadow.SchoolGame.Game.Data {
  using Utils;
  using UnityEngine;

  public class AnswerData {
    public string answer;
    public bool correct;
    public string image;
    [System.NonSerialized]
    public Sprite
      spr;
    
    public override string ToString() {
      var s = "";
      s += "AnswerData{answer=";
      s += answer;
      s += ", correct=";
      s += correct;
      s += ", imageLoc=";
      s += image;
      s += "}";
      return s;
    }

    public AnswerData Copy(TopicData topic) {
      var tmp = new AnswerData();
      tmp.answer = string.IsNullOrEmpty(answer) ? "" : string.Copy(answer);
      tmp.correct = correct;
      if(!string.IsNullOrEmpty(image)) {
        tmp.image = string.Copy(image);
        tmp.spr = Extensions.LoadSprite(Extensions.LocalizeInTopic(topic, tmp.image));
      }
      return tmp;
    }
  }
}