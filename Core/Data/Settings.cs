namespace SchoolGame.Data {
  using System;
  using System.Collections.Generic;
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
    public List<Team> teams;

    public static Settings Default() {
      var tmp = new Settings();
      tmp.teams = new List<Team>();
      tmp.sound = new SoundSettings();
      tmp.time = new TimeSettings();
      tmp.time.beforeAnswer = 60;
      tmp.time.afterAnswer = 5;
      tmp.time.scoreDelay = 5;
      tmp.time.gameOverDelay = 8;
      return tmp;
    }
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