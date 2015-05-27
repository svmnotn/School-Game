namespace Shadow.SchoolGame.Game.Data {
  using Utils;
  using System.Collections.Generic;

  public class TopicData {
    public string name;
    public Dictionary<int, List<QuestionData>> questions;

    public void ChangeValue(int oldVal, int newVal) {
      var qs = GetQuestions(oldVal);
      questions.Remove(oldVal);
      questions.Add(newVal, qs);
    }

    public List<QuestionData> GetQuestions(int value) {
      List<QuestionData> qs;
      questions.TryGetValue(value, out qs);
      if(qs == null) {
        qs = new List<QuestionData>(); 
        questions.Add(value, qs);
        return GetQuestions(value);
      }
      return qs;
    }

    public void AddQuestion(int value, QuestionData data) {
      GetQuestions(value).Add(data);
    }

    public void RemoveQuestion(int value, QuestionData data) {
      GetQuestions(value).Remove(data);
    }

    public bool HasQuestions() {
      int count = 0;
      foreach(int key in questions.Keys) {
        if(HasQuestions(key)) {
          count++;
        }
      }
      return count > 0;
    }

    public bool HasQuestions(int value) {
      var qs = GetQuestions(value);
      return (qs != null && qs.Count > 0);
    }

    public bool HasQuestion(int value, QuestionData q) {
      var qs = GetQuestions(value);
      if(qs != null && qs.Count > 0) {
        return qs.Contains(q);
      }
      return false;
    }

    public QuestionData GetQuestion(int value) {
      var qs = GetQuestions(value);
      QuestionData tmp = null;
      if(qs.Count > 0) {
        tmp = qs.ToArray()[0];
        qs.Remove(tmp);
        qs.Shuffle();
      }
      return tmp;
    }

    public override string ToString() {
      var s = "";
      s += "TopicData{name=";
      s += name;
      s += ", questions=[\n";
      foreach(var qs in questions.Values) {
        foreach(var q in qs) {
          s += q.ToString();
          s += ", ";
        }
      }
      s = s.Remove(s.LastIndexOf(','));
      s += "]}";
      return s;
    }

    public TopicData Copy() {
      var tmp = new TopicData();
      tmp.name = string.IsNullOrEmpty(name) ? "" : string.Copy(name);
      tmp.questions = new Dictionary<int, List<QuestionData>>();
      foreach(int val in questions.Keys) {
        var l = new List<QuestionData>();
        foreach(var q in GetQuestions(val)) {
          l.Add(q.Copy(tmp));
        }
        tmp.questions.Add(val, l);
      }
      return tmp;
    }
  }
}