namespace Shadow.SchoolGame.Game.Data {
  using Utils;
  using UnityEngine;
  using System.Collections.Generic;

  public class QuestionData {
    public int value;
    public string question;
    public string image;
    [System.NonSerialized]
    public Sprite
      spr;
    [System.NonSerialized]
    public string
      loc;
    public List<AnswerData> answers;
    
    public override string ToString() {
      var s = "";
      s += "QuestionData{value=";
      s += value;
      s += ", question=\'";
      s += question;
      s += "\', image=";
      s += image;
      s += ", loc=";
      s += loc;
      s += ", answers=[\n";
      foreach(var a in answers) {
        s += a.ToString();
        s += ",\n";
      }
      s = s.Remove(s.LastIndexOf(','));
      s += "]}";
      return s;
    }

    public QuestionData Copy(TopicData topic) {
      var tmp = new QuestionData();
      tmp.value = value;
      tmp.question = string.IsNullOrEmpty(question) ? "" : string.Copy(question);
      tmp.loc = string.IsNullOrEmpty(loc) ? "" : string.Copy(loc);
      if(!string.IsNullOrEmpty(image)) {
        tmp.image = string.Copy(image);
        tmp.spr = Extensions.LoadSprite(Extensions.LocalizeInTopic(topic, tmp.image));
      }
      tmp.answers = new List<AnswerData>();
      foreach(AnswerData d in answers) {
        tmp.answers.Add(d.Copy(topic));
      }
      return tmp;
    }
  }
}