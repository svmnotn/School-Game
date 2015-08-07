using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolGame.SGCC.UI {
  using Data;

  public partial class MainScreen : Form {
    Archive arch;

    public MainScreen() {
      InitializeComponent();
      arch = new Archive();
      arch.settings = new Settings();
      arch.settings.sound = new SoundSettings();
    }

    private void LoadArchive(object sender, EventArgs e) {

    }

    private void SaveArchive(object sender, EventArgs e) {

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

        }
      #endregion
      #region Set Text
        private void SetArchiveName(object sender, EventArgs e) {
          var obj = (TextBox)sender;
        }

        private void SetArchiveDesc(object sender, EventArgs e) {
          var obj = (TextBox)sender;
        }

        private void SetArchiveURL(object sender, EventArgs e) {
          var obj = (TextBox)sender;
        }
        #region Set Sounds
          private void SelectBkgSound(object sender, EventArgs e) {
            ShowOpenDialog(openSound, "Select the Background Sound", (object send, CancelEventArgs er) => arch.settings.sound.backgroundSoundLoc = ((OpenFileDialog)send).FileName);
            var obj = (TextBox)sender;
            obj.Text = arch.settings.sound.backgroundSoundLoc;
          }

          private void SelectCorrectSound(object sender, EventArgs e) {
            ShowOpenDialog(openSound, "Select the Correct Sound", (object send, CancelEventArgs er) => arch.settings.sound.correctSoundLoc = ((OpenFileDialog)send).FileName);
            var obj = (TextBox)sender;
            obj.Text = arch.settings.sound.correctSoundLoc;
          }

          private void SelectWrongSound(object sender, EventArgs e) {
            ShowOpenDialog(openSound, "Select the Wrong Sound", (object send, CancelEventArgs er) => arch.settings.sound.wrongSoundLoc = ((OpenFileDialog)send).FileName);
            var obj = (TextBox)sender;
            obj.Text = arch.settings.sound.wrongSoundLoc;
          }
        #endregion
        #region Set Colors
          private void SelectBkgColor(object sender, EventArgs e) {
            colorDialog.ShowDialog();
            var obj = (TextBox)sender;
            arch.settings.backgroundColor = colorDialog.Color;
            obj.Text = colorDialog.Color.ToString();
          }

          private void SelectTimerColor(object sender, EventArgs e) {
            colorDialog.ShowDialog();
            var obj = (TextBox)sender;
            arch.settings.timerColor = colorDialog.Color;
            obj.Text = colorDialog.Color.ToString();
          }
        #endregion
        #region Set Fonts
          private void SelectTimerFont(object sender, EventArgs e) {
            fontDialog.ShowDialog();
          }
        #endregion
      #endregion
      #region Set Numbers
        private void SetBeforeQuestion(object sender, EventArgs e) {
          var obj = (NumericUpDown)sender;
        }

        private void SetAfterQuestion(object sender, EventArgs e) {
          var obj = (NumericUpDown)sender;
        }

        private void SetScoreDelay(object sender, EventArgs e) {
          var obj = (NumericUpDown)sender;
        }

        private void SetGODelay(object sender, EventArgs e) {
          var obj = (NumericUpDown)sender;
        }
      #endregion
    #endregion
  }
}