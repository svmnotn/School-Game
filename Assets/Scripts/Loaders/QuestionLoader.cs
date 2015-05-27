namespace Shadow.SchoolGame.Loaders {
  using Utils;
  using Game.Data;
  using System.IO;
  using Newtonsoft.Json;
  using System.Collections.Generic;

  public class QuestionLoader {
    public const string FileType = ".json";

    public static string QuestionFolder {
      get {
        var dir = Loader.DataFolder + Extensions.Separator + "Questions";
        if(!Directory.Exists(dir)) {
          Directory.CreateDirectory(dir);
        }
        return dir;
      }
    }

    static JsonSerializerSettings s {
      get {
        JsonSerializerSettings tmp = new JsonSerializerSettings();
        tmp.Formatting = Formatting.Indented;
        tmp.NullValueHandling = NullValueHandling.Ignore;
        tmp.MissingMemberHandling = MissingMemberHandling.Ignore;
        tmp.DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate;
        return tmp;
      }
    }

    public static string DirFromName(string name) {
      return QuestionFolder + Extensions.Separator + name;
    }

    public static string[] QuestionFiles(string name) {
      return Directory.GetFiles(DirFromName(name), "*" + FileType);
    }

    public static List<TopicData> LoadTopics() {
      var topicDirsAvailable = Directory.GetDirectories(QuestionFolder);
      var topicsInLoad = new List<TopicData>();
      for(int topicIndex = 0; topicIndex < topicDirsAvailable.Length; topicIndex++) {
        var topic = new TopicData();
        topic.name = Extensions.DirectoryName(topicDirsAvailable[topicIndex]);
        LoadValues(topicDirsAvailable[topicIndex], out topic.questions);
        topicsInLoad.Add(topic);
      }
      return topicsInLoad;
    }
    
    public static void LoadValues(string topic, out Dictionary<int, List<QuestionData>> questions) {
      questions = new Dictionary<int, List<QuestionData>>();
      List<QuestionData> questionList;
      LoadQuestions(topic, out questionList);
      foreach(QuestionData q in questionList) {
        List<QuestionData> tmp;
        if(questions.TryGetValue(q.value, out tmp)) {
          tmp.Add(q);
        } else {
          tmp = new List<QuestionData>();
          tmp.Add(q);
          questions.Add(q.value, tmp);
        }
      }
    }
    
    public static void LoadQuestions(string topic, out List<QuestionData> questionList) {
      var questionFiles = Directory.GetFiles(topic, "*" + FileType);
      questionList = new List<QuestionData>();
      for(int questionIndex = 0; questionIndex < questionFiles.Length; questionIndex++) {
        var a = Deserialize(questionFiles[questionIndex]);
        a.loc = questionFiles[questionIndex];
        if(!string.IsNullOrEmpty(a.image)) {
          a.spr = Extensions.LoadSprite(Extensions.LocalizeInTopic(topic, a.image));
        }
        foreach(AnswerData ans in a.answers) {
          if(!string.IsNullOrEmpty(ans.image)) {
            ans.spr = Extensions.LoadSprite(Extensions.LocalizeInTopic(topic, ans.image));
          }
        }
        questionList.Add(a);
      }
    }
        
    public static void AddTopic(TopicData data) {
      Directory.CreateDirectory(DirFromName(data.name));
    }
    
    public static void ChangeTopic(TopicData data, string newName) {
      var old = DirFromName(data.name);
      if(!string.IsNullOrEmpty(old) && data.name != newName) {
        Directory.Move(old, (Extensions.DirectoryPath(old) + Extensions.Separator + newName));
        data.name = newName;
      }
    }
    
    public static void DeleteTopic(TopicData delete) {
      var toDel = DirFromName(delete.name);
      if(!string.IsNullOrEmpty(toDel)) {
        Directory.Delete(toDel, true);
      }
      Loader.topics.Remove(delete);
    }
    
    public static void ChangeValue(int val, int newVal, TopicData data = null) {
      var questionFiles = QuestionFiles(data != null ? data.name : Loader.currentTopic.name);
      for(int questionIndex = 0; questionIndex < questionFiles.Length; questionIndex++) {
        var a = Deserialize(questionFiles[questionIndex]);
        if(a.value == val) {
          a.value = newVal;
          File.WriteAllText(questionFiles[questionIndex], Serialize(a));
        }
      }
    }
    
    public static void DeleteValue(int val, TopicData data = null) {
      var questionFiles = QuestionFiles(data != null ? data.name : Loader.currentTopic.name);
      for(int questionIndex = 0; questionIndex < questionFiles.Length; questionIndex++) {
        QuestionData a = Deserialize(questionFiles[questionIndex]);
        if(a.value == val) {
          File.Delete(questionFiles[questionIndex]);
        }
      }
    }
    
    public static void SaveQuestion(TopicData topic = null, QuestionData question = null) {
      var t = topic ?? Loader.currentTopic;
      var q = question ?? Loader.currentQuestion;
      if(!string.IsNullOrEmpty(q.loc)) {
        File.WriteAllText(q.loc, Serialize(q));
      } else {
        var fName = DirFromName(t.name) + Extensions.Separator + Path.GetRandomFileName() + FileType;
        File.Create(fName).Close();
        File.WriteAllText(fName, Serialize(q));
        q.loc = fName;
      }
    }
    
    public static void DeleteQuestion(QuestionData question = null) {
      var q = question ?? Loader.currentQuestion;
      File.Delete(q.loc);
    }

    static QuestionData Deserialize(string path) {
      return JsonConvert.DeserializeObject<QuestionData>(File.ReadAllText(path), s);
    }

    static string Serialize(QuestionData q) {
      return JsonConvert.SerializeObject(q, s);
    }
  }
}