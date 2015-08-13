namespace SchoolGame.Game {
  using System;
  using System.Windows.Forms;
  using UI;

  static class Program {
    internal static string DataPath { get { return Application.StartupPath + @"\Data"; } }
    internal static string TmpPath { get { return Application.LocalUserAppDataPath + @"\tmp"; } }
    internal static Form main;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      main = new Loader();
      Application.Run(main);
    }
  }
}