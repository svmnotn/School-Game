namespace SchoolGame.Data {
  using System;
  using System.Drawing;
  using System.Collections.Generic;

  public class Question {
    public string id;
    public int value;
    public string question;
    [NonSerialized]
    public Image image;
    public string imageLoc;
    public IList<Answer> answers;
  }
}