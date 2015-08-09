namespace SchoolGame.Data {
  using System;
  using System.Drawing;

  public class Team {
    public string name;
    public Color color;
    public Font font;
    [NonSerialized]
    public int score;
  }
}