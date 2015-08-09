using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolGame.SGCC.UI {
  using Data;

  public partial class MainScreen : Form {
    Archive archive;

    public MainScreen() : this(Archive.Default()) {}

    public MainScreen(Archive a) {
      InitializeComponent();
      archive = a;
      LoadData();
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

    #region Set UI to Archive
    public void LoadData() {
      // Load General Page
      LoadArchiveInfo();
      LoadGeneralSettings();
      LoadSoundSettings();
      LoadTimeSettings();
    }

      #region Set General Tab Data to Archive Info
      public void LoadArchiveInfo() {
        archiveName.Text = archive.name ?? "";
        archiveDesc.Text = archive.description ?? "";
        updateURL.Text = archive.updateURL ?? "";
      }

      public void LoadGeneralSettings() {
        winning.Text = archive.teamWinningMsg ?? "";
        losing.Text = archive.teamLosingMsg ?? "";
        tying.Text = archive.tyingMsg ?? "";
        won.Text = archive.teamWonMsg ?? "";
        lost.Text = archive.teamLostMsg ?? "";
        tied.Text = archive.tiedMsg ?? "";
        bkgColor.Text = archive.settings.backgroundColor.ToString();
        if(!string.IsNullOrWhiteSpace(archive.settings.backgroundLoc)) {
          bkgImage.Image = archive.settings.background != null ? archive.settings.background : Image.FromFile(archive.settings.backgroundLoc);
        }
      }

      public void LoadSoundSettings() {
        bkgSound.Text = archive.settings.sound.backgroundSoundLoc ?? "";
        correctSound.Text = archive.settings.sound.correctSoundLoc ?? "";
        wrongSound.Text = archive.settings.sound.wrongSoundLoc ?? "";
      }

      public void LoadTimeSettings() {
        timerFont.Text = archive.settings.timerFont != null ? archive.settings.timerFont.ToString() : "";
        timerColor.Text = archive.settings.timerColor != null ? archive.settings.timerColor.ToString() : "";
        beforeAnswer.Value = archive.settings.time.beforeAnswer;
        afterAnswer.Value = archive.settings.time.afterAnswer;
        delayScore.Value = archive.settings.time.scoreDelay;
        delayGO.Value = archive.settings.time.gameOverDelay;
      }
      #endregion



    #endregion

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

        private void SetWinning(object sender, EventArgs e) {
          var obj = (TextBox)sender;
          archive.teamWinningMsg = obj.Text;
        }

        private void SetLosing(object sender, EventArgs e) {
          var obj = (TextBox)sender;
          archive.teamLosingMsg = obj.Text;
        }

        private void SetTying(object sender, EventArgs e) {
          var obj = (TextBox)sender;
          archive.tyingMsg = obj.Text;
        }

        private void SetWon(object sender, EventArgs e) {
          var obj = (TextBox)sender;
          archive.teamWonMsg = obj.Text;
        }

        private void SetLost(object sender, EventArgs e) {
          var obj = (TextBox)sender;
          archive.teamLostMsg = obj.Text;
        }

        private void SetTied(object sender, EventArgs e) {
          var obj = (TextBox)sender;
          archive.tiedMsg = obj.Text;
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