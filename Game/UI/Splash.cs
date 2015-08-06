using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolGame.Game.UI {
  public partial class Splash : Form {
    public Splash() {
      InitializeComponent();
    }

    private void OnTick(object sender, EventArgs e) {
      ((Timer)sender).Enabled = false;
      var main = new MainWindow();
      Program.Run(LoadingBar);
      main.Show();
      Hide();
    }
  }
}