namespace SchoolGame.Game.Utils {
  using System.Windows.Forms;

  internal enum ScreenMode {
    Fullscreen,
    Normal
  }

  internal class Fullscreen {
    internal static void SwitchScreen(Form target, ScreenMode mode) {
      switch(mode) {
        case ScreenMode.Fullscreen:
          target.WindowState = FormWindowState.Normal;
          target.FormBorderStyle = FormBorderStyle.None;
          target.WindowState = FormWindowState.Maximized;
          break;
        case ScreenMode.Normal:
          target.FormBorderStyle = FormBorderStyle.Sizable;
          target.WindowState = FormWindowState.Normal;
          break;
      }
    }
  }
}