namespace SchoolGame.Game.UI {
  using System;
  using System.Windows.Forms;
  using Data;

  public partial class MainWindow : Form {
    public MainWindow() {
      InitializeComponent();
    }

    private void OnTick(object sender, EventArgs e) {
      ((Timer)sender).Enabled = false;
    }

    private void OnClose(object sender, FormClosedEventArgs e) {
      Application.Exit();
    }
  }
}