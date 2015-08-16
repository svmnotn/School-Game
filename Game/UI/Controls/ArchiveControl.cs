namespace SchoolGame.Game.UI.Controls {
  using System;
  using System.IO;
  using System.Windows.Forms;
  using Data;

  internal partial class ArchiveControl : UserControl {
    Archive archive;

    internal ArchiveControl() : this(Archive.Default) {}

    internal ArchiveControl(Archive a) {
      InitializeComponent();
      archive = a;
      LoadFromData();
    }

    internal void LoadFromData() {
      title.Text = archive.name;
      description.Text = archive.description;
      author.Text = "Author(s): " + archive.author;
      version.Text = "Version: " + archive.version;
      license.Text = "License(s): " + archive.license;
      url.Text = archive.updateURL;
      var link = new LinkLabel.Link();
      link.LinkData = archive.updateURL;
      url.Links.Add(link);
    }

    private void Play(object sender, EventArgs e) {

    }

    private void Delete(object sender, EventArgs e) {

    }
  }
}