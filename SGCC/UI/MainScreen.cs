using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolGame.SGCC.UI {
  using Data;

  public partial class MainScreen : Form {
    Archive archive;

    public MainScreen(Archive a) {
      InitializeComponent();
      archive = a;
    }

    public MainScreen() {
      InitializeComponent();
      archive = Archive.Default();
    }

    private void LoadArchive(object sender, EventArgs e) {
      string file = "";
      ShowOpenDialog(openArchive, "Choose what Archive to load", ((object send, CancelEventArgs er) => file = ((OpenFileDialog)send).FileName));
      archive = ArchiveManager.LoadArchive(file);
    }

    private void SaveArchive(object sender, EventArgs e) {
      string file = "";
      saveArchiveDialog.FileOk += ((object send, CancelEventArgs er) => file = ((SaveFileDialog)send).FileName);
      ArchiveManager.SaveArchive(file, archive);
    }

    void ShowOpenDialog(OpenFileDialog dialog, string title, CancelEventHandler eventH) {
      dialog.Title = title;
      dialog.FileOk += eventH;
      dialog.ShowDialog();
      dialog.Title = "";
      dialog.FileOk -= eventH;
    }

    #region Set Archive Data to user input

      #region Set Images
      private void SelectBkgImage(object sender, EventArgs e) {
        ShowOpenDialog(openImage, "Select the Background Image", (object send, CancelEventArgs er) => archive.settings.backgroundLoc = ((OpenFileDialog)send).FileName);
        if(!string.IsNullOrWhiteSpace(archive.settings.backgroundLoc)) {
          archive.settings.background = Image.FromFile(archive.settings.backgroundLoc);
          var obj = (PictureBox)sender;
          obj.Image = archive.settings.background;
        }
      }
      #endregion

    #region Set Text
    private void SetArchiveName(object sender, EventArgs e) {
          var obj = (TextBox)sender;
          archive.name = obj.Text;
        }

        private void SetArchiveDesc(object sender, EventArgs e) {
          var obj = (TextBox)sender;
          archive.description = obj.Text;
        }

        private void SetArchiveURL(object sender, EventArgs e) {
          var obj = (TextBox)sender;
          archive.updateURL = obj.Text;
        }

        #region Set Sounds
          private void SelectBkgSound(object sender, EventArgs e) {
            ShowOpenDialog(openSound, "Select the Background Sound", (object send, CancelEventArgs er) => archive.settings.sound.backgroundSoundLoc = ((OpenFileDialog)send).FileName);
            var obj = (TextBox)sender;
            obj.Text = archive.settings.sound.backgroundSoundLoc;
          }

          private void SelectCorrectSound(object sender, EventArgs e) {
            ShowOpenDialog(openSound, "Select the Correct Sound", (object send, CancelEventArgs er) => archive.settings.sound.correctSoundLoc = ((OpenFileDialog)send).FileName);
            var obj = (TextBox)sender;
            obj.Text = archive.settings.sound.correctSoundLoc;
          }

          private void SelectWrongSound(object sender, EventArgs e) {
            ShowOpenDialog(openSound, "Select the Wrong Sound", (object send, CancelEventArgs er) => archive.settings.sound.wrongSoundLoc = ((OpenFileDialog)send).FileName);
            var obj = (TextBox)sender;
            obj.Text = archive.settings.sound.wrongSoundLoc;
          }
        #endregion

        #region Set Colors
          private void SelectBkgColor(object sender, EventArgs e) {
            colorDialog.ShowDialog();
            var obj = (TextBox)sender;
            archive.settings.backgroundColor = colorDialog.Color;
            obj.Text = colorDialog.Color.ToString();
          }

          private void SelectTimerColor(object sender, EventArgs e) {
            colorDialog.ShowDialog();
            var obj = (TextBox)sender;
            archive.settings.timerColor = colorDialog.Color;
            obj.Text = colorDialog.Color.ToString();
          }
        #endregion

        #region Set Fonts
          private void SelectTimerFont(object sender, EventArgs e) {
            fontDialog.ShowDialog();
            archive.settings.timerFont = fontDialog.Font;
            var obj = (TextBox)sender;
            obj.Text = archive.settings.timerFont.ToString();
          }
        #endregion

      #endregion

      #region Set Numbers
        private void SetBeforeQuestion(object sender, EventArgs e) {
          var obj = (NumericUpDown)sender;
          archive.settings.time.beforeAnswer = obj.Value;
        }

        private void SetAfterQuestion(object sender, EventArgs e) {
          var obj = (NumericUpDown)sender;
          archive.settings.time.afterAnswer = obj.Value;
        }

        private void SetScoreDelay(object sender, EventArgs e) {
          var obj = (NumericUpDown)sender;
          archive.settings.time.scoreDelay = obj.Value;
        }

        private void SetGODelay(object sender, EventArgs e) {
          var obj = (NumericUpDown)sender;
          archive.settings.time.gameOverDelay = obj.Value;
        }
    #endregion

    #endregion
  }
}