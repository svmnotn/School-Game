namespace SchoolGame.Game.UI {
  using System;
  using System.Windows.Forms;
  using Data;

  internal partial class MainWindow : Form {
    Archive archive;

    internal MainWindow() : this(Archive.Default) { }

    internal MainWindow(Archive a) {
      InitializeComponent();
      archive = a;
      Text = a.name;
      if(!string.IsNullOrWhiteSpace(a.settings.backgroundLoc)) {
        BackgroundImage = a.settings.background ?? Extensions.LoadImage(Program.ArchivePath(a), a.settings.backgroundLoc);
      }
      BackColor = a.settings.backgroundColor;
    }

    private void OnTick(object sender, EventArgs e) {
      ((Timer)sender).Enabled = false;
    }

    private void OnClose(object sender, FormClosedEventArgs e) {
      Application.Exit();
    }
  }
}