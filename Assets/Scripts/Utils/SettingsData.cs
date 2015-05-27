namespace Shadow.SchoolGame.Utils {
  using System;
  using UnityEngine;

  [Serializable]
  public class SettingsData {
    public bool background = true;
    public bool rightEffect = true;
    public bool wrongEffect = true;
    public int waitForAnswer = 60;
    public int waitAfterAnswer = 5;
    public int waitForScore = 5;
    public int waitForGameOver = 8;
    public string backgroundMusic = "~Jeopardy_Think_Music.wav";
    public string rightSound = "~Correct_Answer.wav";
    public string wrongSound = "~Incorrect_Answer.wav";
    public float backgroundColorR = Color.gray.r;
    public float backgroundColorG = Color.gray.g;
    public float backgroundColorB = Color.gray.b;
    public float timerColorR = Color.yellow.r;
    public float timerColorG = Color.yellow.g;
    public float timerColorB = Color.yellow.b;
    public TeamData blue = new TeamData("Blue Team", Color.blue);
    public TeamData red = new TeamData("Red Team", Color.red);
    
    [Serializable]
    public class TeamData {
      public string name = "No Name";
      public float nameColorR;
      public float nameColorG;
      public float nameColorB;

      public TeamData() {
        name = "No Name";
        nameColorR = 0;
        nameColorG = 0;
        nameColorB = 0;
      }

      public TeamData(string n, Color r) {
        name = n;
        nameColorR = r.r;
        nameColorG = r.g;
        nameColorB = r.b;
      }
    }
  }
}