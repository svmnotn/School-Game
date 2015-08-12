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
      //main = new Splash();
      //Application.Run(main);
    }

    internal static void Run(ProgressBar p) {
      //Load Everything
      var x = 0;
      while(x <= (100 * 10000000)) {
        x++;
        p.Value = x / (100 * 10000000);
      }
    }
  }
}