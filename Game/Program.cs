namespace SchoolGame.Game {
  using System;
  using System.Windows.Forms;
  using UI;
  using Data;

  static class Program {
    internal static string AppDirectory {
      get {
        return Extensions.CoreDirectory + @"\Game";
      }
    }
    internal static string ArchivesDirectory {
      get {
        return AppDirectory + @"\Archives";
      }
    }
    internal static string TmpDirectory {
      get {
        return AppDirectory + @"\tmp";
      }
    }
    internal static Loader loader;
    internal static MainWindow main;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      loader = new Loader();
      Application.Run(loader);
    }

    internal static string ArchivePath(Archive a) {
      return ArchivesDirectory + '\\' + a.name;
    }
  }
}