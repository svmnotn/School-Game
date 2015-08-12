namespace SchoolGame.Data {
  using System;
  using System.Drawing;
  using System.Collections.Generic;

  public class Archive {
    public string name;
    public string description;
    public string updateURL;
    public string teamWinningMsg;
    public string tyingMsg;
    public string teamLosingMsg;
    public string teamWonMsg;
    public string teamLostMsg;
    public string tiedMsg;
    public string version;
    [NonSerialized]
    public Image image;
    public string imageLoc; 
    [NonSerialized]
    public IList<Topic> topics;
    [NonSerialized]
    public Settings settings;

    public Topic GetTopicFromName(string name) {
      foreach(var t in topics) {
        if(t.name.Equals(name)) {
          return t;
        }
      }
      return null;
    }

    public Topic GetTopicFromQuestion(Question q) {
      foreach(var t in topics) {
        if(t.ContainsQuestion(q)) {
          return t;
        }
      }
      return null;
    }

    public static Archive Default {
      get {
        var tmp = new Archive();
        tmp.name = "Default Archive";
        tmp.description = "This is the Default that is automatically created when the SGCC is first run.";
        tmp.teamWinningMsg = "{team} is winning.";
        tmp.teamLosingMsg = "{team} is losing.";
        tmp.tyingMsg = "{teams} are tied!";
        tmp.teamWonMsg = "{team} Won!";
        tmp.teamLostMsg = "{team} Lost.";
        tmp.tiedMsg = "{teams} tied";
        tmp.topics = new List<Topic>();
        var t = new Topic();
        t.name = "Test Topic";
        t.questions = new Dictionary<int, List<Question>>();
        var q = new Question();
        q.id = "test1";
        q.value = 100;
        q.question = "Is this a test?";
        q.answers = new List<Answer>();
        var a = new Answer();
        a.answer = "Yes!";
        a.correct = true;
        q.answers.Add(a);
        a = new Answer();
        a.answer = "No!";
        q.answers.Add(a);
        t.AddQuestion(q);
        q = new Question();
        q.id = "test2";
        q.value = 1000;
        q.question = "Is this really a test?";
        q.answers = new List<Answer>();
        a = new Answer();
        a.answer = "Yes!";
        a.correct = true;
        q.answers.Add(a);
        a = new Answer();
        a.answer = "No!";
        q.answers.Add(a);
        t.AddQuestion(q);
        tmp.topics.Add(t);
        tmp.settings = Settings.Default;
        return tmp;
      }
    }
  }
}