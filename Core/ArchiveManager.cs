namespace SchoolGame {
  using Newtonsoft.Json;
  using System.Collections.Generic;
  using System.IO;
  using System.IO.Compression;
  using Data;

  public static class ArchiveManager {
    static JsonSerializerSettings settings = new JsonSerializerSettings() { DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore };

    public static Archive LoadArchiveFromDir(string from) {
      var a = JsonConvert.DeserializeObject<Archive>(File.ReadAllText(from + @"\info.json"), settings);
      a.settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(from + @"\settings.json"), settings);
      a.topics = new List<Topic>();
      var dirs = Directory.GetDirectories(from);
      for(int i = 0; i < dirs.Length; i++) {
        var t = new Topic();
        var name = dirs[i].Split('\\');
        t.name = name[name.Length-1];
        t.questions = new Dictionary<int, List<Question>>();
        foreach(var q in JsonConvert.DeserializeObject<List<Question>>(File.ReadAllText(dirs[i] + @"\questions.json"), settings)) {
          t.AddQuestion(q);
        }
        a.topics.Add(t);
      }
      return a;
    }

    public static void SaveArchiveToDir(string to, Archive arc) {
      File.WriteAllText(to + @"\info.json", JsonConvert.SerializeObject(arc, settings));
      File.WriteAllText(to + @"\settings.json", JsonConvert.SerializeObject(arc.settings, settings));
      foreach(var t in arc.topics) {
        var n = to + @"\" + t.name;
        Directory.CreateDirectory(to + @"\" + t.name);
        var content = new List<Question>();
        foreach(var qList in t.questions.Values) {
          foreach(var q in qList) {
            content.Add(q);
          }
        }
        File.WriteAllText(n + @"\questions.json", JsonConvert.SerializeObject(content, settings));
      }
    }

    public static Archive LoadArchiveFromFile(string from, string dest) {
      ZipFile.ExtractToDirectory(from, dest);
      return LoadArchiveFromDir(dest);
    }

    public static void SaveArchiveToFile(string to, Archive arc, string tempPath) {
      if(!Directory.Exists(tempPath)) {
        Directory.CreateDirectory(tempPath);
      }
      SaveArchiveToDir(tempPath, arc);
      ZipFile.CreateFromDirectory(tempPath, to, CompressionLevel.Optimal, false);
      Directory.Delete(tempPath, true);
    }
  }
}