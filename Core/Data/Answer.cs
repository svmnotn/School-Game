namespace SchoolGame.Data {
  using System;
  using System.Drawing;

  public class Answer {
    public bool correct;
    public string answer;
    [NonSerialized]
    public Image image;
    public string imageLoc;
  }
}