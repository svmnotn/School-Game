namespace SchoolGame.Data {
  using System.Collections.Generic;

  public class Topic {
    public string name;
    public Dictionary<int, List<Question>> questions;

    public List<Question> GetQuestions(int val) {
      List<Question> qs;
      questions.TryGetValue(val, out qs);
      if(qs == null) {
        qs = new List<Question>();
        questions.Add(val, qs);
        return GetQuestions(val);
      }
      return qs;
    }

    public Question GetQuestion(int val) {
      var qs = GetQuestions(val);
      Question tmp = null;
      if(qs.Count > 0) {
        tmp = qs.ToArray()[0];
        qs.Remove(tmp);
        qs.Shuffle();
      }
      return tmp;
    }

    public void AddQuestion(Question q) {
      GetQuestions(q.value).Add(q);
    }

    public void RemoveQuestion(Question q) {
      GetQuestions(q.value).Remove(q);
    }

    public void ChangeValue(Question q, int newVal) {
      RemoveQuestion(q);
      q.value = newVal;
      AddQuestion(q);
    }

    public Question GetQuestionFromID(string id) {
      foreach(var qList in questions.Values) {
        foreach(var q in qList) {
          if(q.id.Equals(id)) {
            return q;
          }
        }
      }
      return null;
    }

    public void RemoveQuestionByID(string id) {
      List<Question> qList;
      var q = GetQuestionFromID(id);
      questions.TryGetValue(q.value, out qList);
      qList.Remove(q);
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

    public bool HasQuestions(int val) {
      var qs = GetQuestions(val);
      return (qs != null && qs.Count > 0);
    }

    public bool ContainsQuestion(Question q) {
      var qs = GetQuestions(q.value);
      if(qs != null && qs.Count > 0) {
        return qs.Contains(q);
      }
      return false;
    }
  }
}