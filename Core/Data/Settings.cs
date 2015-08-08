namespace SchoolGame.Data {
  using System;
  using System.Drawing;

  public class Settings {
    public Font timerFont;
    public Color timerColor;
    public Color backgroundColor;
    [NonSerialized]
    public Image background;
    public string backgroundLoc;
    public SoundSettings sound;
    public TimeSettings time;
    public Team[] teams;
  }

  public class SoundSettings {
    public string backgroundSoundLoc;
    public string correctSoundLoc;
    public string wrongSoundLoc;
  }

  public class TimeSettings {
    public decimal beforeAnswer;
    public decimal afterAnswer;
    public decimal scoreDelay;
    public decimal gameOverDelay;
  }
}