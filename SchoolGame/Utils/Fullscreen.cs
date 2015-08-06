using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolGame.Utils {
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