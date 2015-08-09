namespace SchoolGame.Data {
  using System;
  using System.Collections.Generic;

  public class Archive {
    public string name;
    public string description;
    public string updateURL;
    public string teamWinningMsg;
    public string tieingMsg;
    public string teamLossingMsg;
    public string teamWonMsg;
    public string teamLostMsg;
    public string tiedMsg;
    [NonSerialized]
    public IList<Topic> topics;
    [NonSerialized]
    public Settings settings;

    public static Archive Default() {
      var tmp = new Archive();
      tmp.teamWinningMsg = "";
      tmp.teamLossingMsg = "";
      tmp.tieingMsg = "";
      tmp.teamWonMsg = "";
      tmp.teamLostMsg = "";
      tmp.tiedMsg = "";
      tmp.topics = new List<Topic>();
      tmp.settings = Settings.Default();
      return tmp;
    }
  }
}