namespace Shadow.SchoolGame.Utils {
  using Game.Data;
  using Loaders;
  using System.IO;
  using UnityEngine;
  using System.Collections.Generic;

  public static class Extensions {
    public static char Separator = Path.AltDirectorySeparatorChar;

    public static string Sanitize(string path) {
      if(!string.IsNullOrEmpty(path)) {
        return path.Replace(Path.DirectorySeparatorChar, Separator);
      }
      return "";
    }

    public static string Localize(string loc, string thing) {
      if(thing.Contains("~")) {
        return Sanitize(loc + Separator + thing.Split('~')[1]);
      }
      return Sanitize(thing);
    }

    public static string LocalizeInTopic(string topic, string thing) {
      return Localize(topic, thing);
    }

    public static string LocalizeInTopic(TopicData topic, string thing) {
      return LocalizeInTopic(QuestionLoader.DirFromName(topic.name), thing);
    }

    public static string DirectoryPath(string path) {
      path = Sanitize(path);
      int lastSlash = path.LastIndexOf(Separator);
      return path.Remove(lastSlash);
    }

    public static string DirectoryName(string path) {
      path = Sanitize(path);
      var tmp = path.Split(Separator);
      return tmp[tmp.Length - 1];
    }

    public static Sprite LoadSprite(string path) {
      path = Sanitize(path);
      if(!string.IsNullOrEmpty(path)) {
        path = @"file://" + path;
        WWW www = new WWW(path);
        Debug.Log("Loading image... \n" + www.url);
        while(!www.isDone) {}
        Debug.Log("Done loading image...");
        Texture2D texTmp = new Texture2D(1024, 1024);
        www.LoadImageIntoTexture(texTmp);
        return Sprite.Create(texTmp, new Rect(0, 0, texTmp.width, texTmp.height), new Vector2(0.5f, 0.5f));
      }
      return null;
    }

    public static string FormatTime(int val) {
      int minutes = val / 60;
      int seconds = val % 60;
      string tmp = "";
      tmp += minutes;
      tmp += ":";
      if(seconds < 10) {
        tmp += "0";
      }
      tmp += seconds;
      return tmp;
    }

    public static void Shuffle<T>(this List<T> list) {  
      System.Random rng = new System.Random();  
      int n = list.Count;  
      while(n > 1) {  
        n--;  
        int k = rng.Next(n + 1);  
        T value = list[k];  
        list[k] = list[n];  
        list[n] = value;  
      }  
    }
  }
}