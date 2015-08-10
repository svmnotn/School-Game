namespace SchoolGame.SGCC.UI {
  using System;
  using System.Windows.Forms;

  public partial class InputDialog : Form {

    public InputDialog() : this("",""){}

    public InputDialog(string title, string question) {
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