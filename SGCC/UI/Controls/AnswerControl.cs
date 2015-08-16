namespace SchoolGame.SGCC.UI.Controls {
  using System;
  using System.ComponentModel;
  using System.Drawing;
  using System.Windows.Forms;
  using Data;

  internal partial class AnswerControl : UserControl {
    internal Answer answerObj;

    internal AnswerControl() : this(new Answer()) {}

    internal AnswerControl(Answer ans) {
      answerObj = ans;
      InitializeComponent();
      LoadFromData();
    }

    internal void LoadFromData() {
      answer.Text = answerObj.answer ?? "";
      if(!string.IsNullOrWhiteSpace(answerObj.imageLoc)) {
        answerPicture.Image = answerObj.image ?? Extensions.LoadImage(Program.WorkingDirectory, answerObj.imageLoc);
      } else {
        answerPicture.Image = null;
      }
      correct.Checked = answerObj.correct;
    }

    private void imageClick(object sender, EventArgs e) {
      OpenFileDialog d = new OpenFileDialog();
      d.Title = "Select which image to use as an answer";
      d.Filter = "Image Files (*.bmp, *.jpg, *.jpeg)|*.bmp;*.jpg;*.jpeg";
      d.FileOk += (object send, CancelEventArgs er) => answerObj.imageLoc = ((OpenFileDialog)send).FileName;
      d.ShowDialog();
      answerObj.imageLoc = Program.CopyTo(answerObj.imageLoc, Program.WorkingDirectory, Program.AnswerName);
      if(!string.IsNullOrWhiteSpace(answerObj.imageLoc)) {
        answerObj.image = Image.FromFile(answerObj.imageLoc);
        var obj = (PictureBox)sender;
        obj.Image = answerObj.image;
      }
    }

    private void textChange(object sender, EventArgs e) {
      var obj = (TextBox)sender;
      answerObj.answer = obj.Text;
    }

    private void checkedChange(object sender, EventArgs e) {
      var obj = (CheckBox)sender;
      answerObj.correct = obj.Checked;
    }

    private void delete(object sender, EventArgs e) {
      Program.main.currentQuestion.answers.Remove(answerObj);
      Program.main.LoadAnswers();
    }
  }
}