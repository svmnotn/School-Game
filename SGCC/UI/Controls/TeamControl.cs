namespace SchoolGame.SGCC.UI.Controls {
  using System;
  using System.Windows.Forms;
  using Data;

  public partial class TeamControl : UserControl {
    public Team teamObj;

    public TeamControl() : this(new Team()) {}

    public TeamControl(Team team) {
      teamObj = team;
      InitializeComponent();
      LoadFromData();
    }

    public void LoadFromData() {
      name.Text = teamObj.name ?? "";
      font.Text = teamObj.font != null ? teamObj.font.ToString() : "";
      color.Text = teamObj.color != null ? teamObj.color.ToString() : "";
    }

    private void NameChange(object sender, EventArgs e) {
      var obj = (TextBox)sender;
      teamObj.name = obj.Text;
    }

    private void ColorClick(object sender, EventArgs e) {
      var obj = (TextBox)sender;
      var dig = new ColorDialog();
      dig.AnyColor = true;
      dig.ShowDialog();
      teamObj.color = dig.Color;
      obj.Text = teamObj.color.ToString();
    }

    private void FontClick(object sender, EventArgs e) {
      var obj = (TextBox)sender;
      var dig = new FontDialog();
      dig.FontMustExist = true;
      dig.ShowDialog();
      teamObj.font = dig.Font;
      obj.Text = teamObj.font.ToString();
    }

    private void DeleteClick(object sender, EventArgs e) {
      Program.main.archive.settings.teams.Remove(teamObj);
      Program.main.LoadTeams();
    }
  }
}