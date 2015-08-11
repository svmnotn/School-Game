namespace SchoolGame.SGCC {
  using System;
  using System.IO;
  using System.Windows.Forms;
  using Data;
  using UI;

  static class Program {
    public static MainScreen main;
    public static string DataPath { get { return Application.StartupPath + @"\Data"; } }
    public static string TmpPath { get { return Application.LocalUserAppDataPath + @"\tmp"; } }
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
  }
}