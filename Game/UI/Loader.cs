namespace SchoolGame.Game.UI {
  using System.Windows.Forms;
  using Data;

  public partial class Loader : Form {
    Archive archive;
    internal Archive CurrentArchive {
      get { return archive; }
      set {
        name.Text = value.name;
        description.Text = value.description;
        version.Text = value.version;
        author.Text = value.author;
        license.Text = value.license;
        update.Text = value.updateURL;
        LinkLabel.Link link = new LinkLabel.Link();
        link.LinkData = value.updateURL;
        update.Links.Add(link);
        archive = value;
      }
    }

    public Loader() {
      InitializeComponent();
    }
  }
}