namespace Shadow.SchoolGame {
  using Utils;
  using Game.Data;
  using Game.Buttons;
  using Game.Controllers;
  using UnityEngine;
  using UnityEngine.UI;
  using System.Collections.Generic;
  using Loaders;

  public class Core : MonoBehaviour {
    public static Core inst;
    public static List<TopicData> topics;
    public static CurrentData data;
    public GameObject mainMenu;
    public GameObject modeSelect;
    public GameObject catSelect;
    public GameObject pntSelect;
    public GameObject question;
    public GameObject result;
    public GameObject over;
    public AudioSource backgnd;
    public AudioSource right;
    public AudioSource wrong;

    void Awake() {
      inst = this;
      topics = new List<TopicData>();
      foreach(var t in Loader.topics) {
        topics.Add(t.Copy());
      }
      data = new CurrentData();
      LoadMusic();
    }

    public void LoadMusic(){
      backgnd.clip = SoundLoader.Load(Settings.settings.backgroundMusic);
      right.clip = SoundLoader.Load(Settings.settings.rightSound);
      wrong.clip = SoundLoader.Load(Settings.settings.wrongSound);
    }

    bool Playing() {
      return catSelect.activeInHierarchy || pntSelect.activeInHierarchy || question.activeInHierarchy;
    }

    void Update() {
      if(Playing() && !backgnd.isPlaying && !data.answered) {
        backgnd.Play();
      }

      if(Input.GetKeyDown(KeyCode.Escape)) {
        if(Playing() || result.activeInHierarchy || modeSelect.activeInHierarchy) {
          mainMenu.SetActive(true);
          modeSelect.SetActive(false);
          catSelect.SetActive(false);
          pntSelect.SetActive(false);
          question.SetActive(false);
          result.SetActive(false);
          Reset();
        }
      }
    }

    public int TopicsLeft() {
      int count = 0;
      foreach(TopicData key in topics) {
        if(key.HasQuestions()) {
          count++;
        }
      }
      return count;
    }

    public void Reset() {
      topics = new List<TopicData>();
      foreach(var t in Loader.topics) {
        topics.Add(t.Copy());
      }
      data = new CurrentData();
      backgnd.Stop();
    }

    public void SetGamemode(int mode) {
      data.mode = (GameMode)mode;
      backgnd.Play();
    }

    public void Answered() {
      backgnd.Stop();
      var bttns = Answers.inst.transform.FindChild("Content");
      foreach(Transform t in bttns) {
        var bttn = t.GetComponent<Button>();
        var b = t.GetComponent<AnswerButton>();
        if(b != null) {
          if(b.data.correct) {
            b.ChangeColor();
          }
        }
        if(bttn != null) {
          bttn.enabled = false;
        }
      }
    }

    public void Quit() {
      Application.Quit();
    }
  }
}