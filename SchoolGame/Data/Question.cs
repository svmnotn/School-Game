namespace SchoolGame.Data {
  using System;
  using Answers = System.Collections.Generic.IList<Answer>;

  public class Question {
    public int value;
    public string question;
    public string imageLoc;
    [NonSerialized]
    public string loc;
    public Answers answers;
  }
}