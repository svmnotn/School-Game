﻿namespace SchoolGame.SGCC.UI {
  using System;
  using System.ComponentModel;
  using System.Drawing;
  using System.Windows.Forms;
  using Data;

  public partial class AnswerControl : UserControl {
    public Answer answerObj;
    public bool needDel;

    public AnswerControl() {
      answerObj = new Answer();
      InitializeComponent();
    }

    public AnswerControl(Answer ans) {
      answerObj = ans;
      InitializeComponent();
    }

    private void imageClick(object sender, EventArgs e) {
      OpenFileDialog d = new OpenFileDialog();
      d.Title = "Select which image to use as an answer";
      d.Filter = "Image Files (*.bmp, *.jpg, *.jpeg)|*.bmp;*.jpg;*.jpeg";
      d.FileOk += (object send, CancelEventArgs er) => answerObj.imageLoc = ((OpenFileDialog)send).FileName;
      d.ShowDialog();
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
      needDel = true;
    }
  }
}