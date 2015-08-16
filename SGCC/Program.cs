namespace SchoolGame.SGCC {
  using System;
  using System.IO;
  using System.Windows.Forms;
  using Data;
  using UI;

  static class Program {
    internal static string AppDirectory {
      get {
        return Extensions.CoreDirectory + @"\SGCC";
      }
    }
    internal static string WorkingDirectory {
      get {
        return AppDirectory + @"\Data";
      }
    }
    internal static string TmpDirectory {
      get {
        return AppDirectory + @"\tmp";
      }
    }
    internal static string AnswerName { get { return main.CurrentTopic + '\\' + main.currentQuestion.id + "_answer" + (DateTime.Now - System.Diagnostics.Process.GetCurrentProcess().StartTime).Ticks; } }
    internal static MainScreen main;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      main = new MainScreen(Setup());
      Application.Run(main);
    }

    static Archive Setup() {
      if(!Directory.Exists(WorkingDirectory)) {
        Directory.CreateDirectory(WorkingDirectory);
        ArchiveManager.SaveArchiveToDir(WorkingDirectory, Archive.Default);
      }
      return ArchiveManager.LoadArchiveFromDir(WorkingDirectory);
    }

    internal static string CopyTo(string from, string to, string newName) {
      var type = from.Split('.');
      var name = newName + '.' + type[type.Length - 1];
      var newPath = to + '\\' + name;
      File.Copy(from, newPath, true);
      return name;
    }
  }
}