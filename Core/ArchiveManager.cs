namespace SchoolGame {
  using System;
  using Data;

  public static class ArchiveManager {

    public static Archive LoadArchive(string from) {
      Console.WriteLine(from);
      Archive tmp = null;
      if(from.EndsWith(".sgca")) {
        tmp = LoadArchiveFromFile(from);
      } else {
        tmp = LoadArchiveFromDir(from);
      }
      return tmp;
    }

    public static void SaveArchive(string to, Archive arc) {
      if(to.EndsWith(".sgca")) {
        SaveArchiveToFile(to, arc);
      } else {
        SaveArchiveToDir(to, arc);
      }
    }

    private static Archive LoadArchiveFromDir(string from) {
      throw new NotImplementedException();
    }

    private static void SaveArchiveToDir(string to, Archive arc) {
      throw new NotImplementedException();
    }

    private static Archive LoadArchiveFromFile(string from) {
      throw new NotImplementedException();
    }

    private static void SaveArchiveToFile(string to, Archive arc) {
      throw new NotImplementedException();
    }
  }
}