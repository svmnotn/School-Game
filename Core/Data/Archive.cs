namespace SchoolGame.Data {
  using System;
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

    public static Archive Default() {
      var tmp = new Archive();
      tmp.teamWinningMsg = "{team} is winning.";
      tmp.teamLosingMsg = "{team} is losing.";
      tmp.tyingMsg = "{teams} are tied!";
      tmp.teamWonMsg = "{team} Won!";
      tmp.teamLostMsg = "{team} Lost.";
      tmp.tiedMsg = "{teams} tied";
      tmp.topics = new List<Topic>();
      tmp.settings = Settings.Default();
      return tmp;
    }
  }
}