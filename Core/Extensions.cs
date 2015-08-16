﻿namespace SchoolGame {
  using System;
  using System.Collections.Generic;
  using System.Drawing;
  using System.IO;
  using System.IO.Compression;
  using static System.Environment;

  public static class Extensions {
    public static string CoreDirectory {
      get {
        return GetFolderPath(SpecialFolder.ApplicationData) + @"\School Game";
      }
    }

    public static void Shuffle<T>(this List<T> list) {
      Random rng = new Random();
      int n = list.Count;
      while(n > 1) {
        n--;
        int k = rng.Next(n + 1);
        T value = list[k];
        list[k] = list[n];
        list[n] = value;
      }
    }

    public static Image LoadImage(string dataPath, string relativeLoc) {
      return Image.FromFile(dataPath + '\\' + relativeLoc);
    }
  }
}