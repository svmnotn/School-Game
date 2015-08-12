using System;
using System.Windows.Forms;

namespace SchoolGame.Game {
  using UI;

  static class Program {
    static Form main;
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