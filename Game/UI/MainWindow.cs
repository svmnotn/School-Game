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
  public partial class MainWindow : Form {
    public MainWindow() {
      InitializeComponent();
      BackColor = Properties.General.Default.BackgroundColor;
      if(!string.IsNullOrWhiteSpace(Properties.General.Default.BackgroundImage)) {
        BackgroundImage = Image.FromFile(Properties.General.Default.BackgroundImage);
      }
    }

    private void OnTick(object sender, EventArgs e) {
      ((Timer)sender).Enabled = false;
    }

    private void OnClose(object sender, FormClosedEventArgs e) {
      Application.Exit();
    }
  }
}