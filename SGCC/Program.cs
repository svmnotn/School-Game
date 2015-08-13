namespace SchoolGame.SGCC {
  using System;
  using System.IO;
  using System.Windows.Forms;
  using Data;
  using UI;

  static class Program {
    internal static MainScreen main;
    internal static string DataPath { get { return Application.StartupPath + @"\Data";} }
    internal static string TmpPath { get { return Application.LocalUserAppDataPath + @"\tmp";} }
    internal static string AnswerName { get { return main.CurrentTopic + '\\' + main.currentQuestion.id + "_answer" + (DateTime.Now - System.Diagnostics.Process.GetCurrentProcess().StartTime).Ticks;} }
    
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
      if(!Directory.Exists(DataPath)) {
        Directory.CreateDirectory(DataPath);
        ArchiveManager.SaveArchiveToDir(DataPath, Archive.Default);
      }
      return ArchiveManager.LoadArchiveFromDir(DataPath);
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