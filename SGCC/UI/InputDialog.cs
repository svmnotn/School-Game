namespace SchoolGame.SGCC.UI {
  using System;
  using System.Windows.Forms;

  internal partial class InputDialog : Form {

    internal InputDialog() : this("", "") { }

    internal InputDialog(string title, string question) {
      InitializeComponent();
      AcceptButton = done;
      Text = title;
      questionLabel.Text = question;
    }

    private void Done(object sender, EventArgs e) {
      DialogResult = DialogResult.OK;
      Close();
    }
  }
}