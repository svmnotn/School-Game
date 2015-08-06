namespace SchoolGame.Data {
  using System.Drawing;

  public class Settings {
    Font timerFont;
    Color timerColor;
    Color background;
    string backgroundLoc;
    SoundSettings sound;
    TimeSettings time;
    Team[] teams;
  }

  public class SoundSettings {
    string backgroundSoundLoc;
    string correctSoundLoc;
    string wrongSoundLoc;
  }

  public class TimeSettings {
    double timeForAnswer;
    double delayAfternAnswer;
    double scoreDelay;
    double gameoverDelay;
  }
}