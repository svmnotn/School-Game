namespace Shadow.SchoolGame {
  using Utils;
  using Loaders;
  using Game.Data;
  using UnityEngine;
  using System.Collections.Generic;

  public class Loader : MonoBehaviour {
    public static Loader inst;
    public GameObject game;
    public static List<TopicData> topics;
    public static TopicData currentTopic;
    public static int currentValue;
    public static QuestionData currentQuestion;

    public static string DataFolder {
      get {
        var dir = Extensions.DirectoryPath(Application.dataPath) + Extensions.Separator + "Data";
        if(!System.IO.Directory.Exists(dir)) {
          System.IO.Directory.CreateDirectory(dir);
        }
        return dir;
      }
    }

    void Awake() {
      inst = this;
      Settings.Load();
      topics = QuestionLoader.LoadTopics();
      game.SetActive(true);
      GetComponentInChildren<Canvas>().gameObject.SetActive(false);
    }
  }
}