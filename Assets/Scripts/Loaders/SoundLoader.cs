namespace Shadow.SchoolGame.Loaders {
  using Utils;
  using System.IO;
  using UnityEngine;
  
  public class SoundLoader {
    public static string SoundFolder {
      get {
        var dir = Loader.DataFolder + Extensions.Separator + "sfx";
        if(!Directory.Exists(dir)) {
          Directory.CreateDirectory(dir);
        }
        return dir;
      }
    }

    public static AudioClip Load(string sound) {
      AudioClip c = null;
      if(!string.IsNullOrEmpty(sound)) {
        sound = @"file://" + Extensions.Localize(SoundFolder, sound);
        WWW tmp = new WWW(sound);
        Debug.Log("Loading sound... \n" + tmp.url);
        while(!tmp.isDone) {}
        Debug.Log("Done loading sound...");
        c = tmp.GetAudioClip(false, false);
      }
      return c;
    }

    public static bool Exists(string sound) {
      sound = Extensions.Localize(SoundFolder, sound);
      if(File.Exists(sound)) {
        return true;
      }
      return false;
    }
  }
}