namespace SchoolGame.Game.UI {
  using System;
  using System.IO;
  using System.Windows.Forms;
  using Controls;
  using Data;

  internal partial class Loader : Form {

    internal Loader() {
      InitializeComponent();
      LoadArchivesToTable();
    }

    internal void LoadArchivesToTable() {
      if(Directory.Exists(Program.ArchivesDirectory)) {
        var dirs = Directory.GetDirectories(Program.ArchivesDirectory);
        archivesTable.Controls.Clear();
        archivesTable.RowStyles.Clear();
        foreach(var dir in dirs) {
          var archive = ArchiveManager.LoadArchiveFromDir(dir);
          var control = new ArchiveControl(archive);
          archivesTable.Controls.Add(control);
        }
      } else {
        Directory.CreateDirectory(Program.ArchivesDirectory);
      }
    }

    private void ImportArchive(object sender, EventArgs e) {
      var res = openArchive.ShowDialog();
      if(res == DialogResult.OK || res == DialogResult.Yes) {
        var a = ArchiveManager.LoadArchiveFromFile(openArchive.OpenFile(), Program.TmpDirectory);
        if(!Directory.Exists(Program.ArchivePath(a))) {
          Directory.Move(Program.TmpDirectory, Program.ArchivePath(a));
          LoadArchivesToTable();
        } else {
          //SHOW ERROR
          Directory.Delete(Program.TmpDirectory, true);
        }
      }
    }

    internal void StartGame(Archive archive) {
      Hide();
      Program.main = new MainWindow(archive);
      Program.main.Show();
    }
  }
}