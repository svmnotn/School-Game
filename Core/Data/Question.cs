namespace SchoolGame.Data {
  using System;
  using System.Drawing;
  using Answers = System.Collections.Generic.IList<Answer>;

  public class Question {
    public int value;
    public string question;
    [NonSerialized]
    public Image image;
    public string imageLoc;
    [NonSerialized]
    public string loc;
    public Answers answers;
  }
}