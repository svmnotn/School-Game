namespace SchoolGame.Game.UI {
  partial class Loader {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.openArchive = new System.Windows.Forms.OpenFileDialog();
      this.splitContainer = new System.Windows.Forms.SplitContainer();
      this.listView = new System.Windows.Forms.ListView();
      this.detailsStructure = new System.Windows.Forms.TableLayoutPanel();
      this.nameLabel = new System.Windows.Forms.Label();
      this.descLabel = new System.Windows.Forms.Label();
      this.versionLabel = new System.Windows.Forms.Label();
      this.updateLabel = new System.Windows.Forms.Label();
      this.name = new System.Windows.Forms.Label();
      this.description = new System.Windows.Forms.Label();
      this.version = new System.Windows.Forms.Label();
      this.update = new System.Windows.Forms.LinkLabel();
      this.image = new System.Windows.Forms.PictureBox();
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.importArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mainStructure = new System.Windows.Forms.TableLayoutPanel();
      this.play = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
      this.splitContainer.Panel1.SuspendLayout();
      this.splitContainer.Panel2.SuspendLayout();
      this.splitContainer.SuspendLayout();
      this.detailsStructure.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
      this.menuStrip.SuspendLayout();
      this.mainStructure.SuspendLayout();
      this.SuspendLayout();
      // 
      // openArchive
      // 
      this.openArchive.FileName = "openFileDialog1";
      this.openArchive.Filter = "School Game Content Archive (*.sgca)|*.sgca";
      // 
      // splitContainer
      // 
      this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer.Location = new System.Drawing.Point(3, 3);
      this.splitContainer.Name = "splitContainer";
      // 
      // splitContainer.Panel1
      // 
      this.splitContainer.Panel1.Controls.Add(this.listView);
      // 
      // splitContainer.Panel2
      // 
      this.splitContainer.Panel2.Controls.Add(this.detailsStructure);
      this.splitContainer.Size = new System.Drawing.Size(563, 363);
      this.splitContainer.SplitterDistance = 293;
      this.splitContainer.TabIndex = 0;
      // 
      // listView
      // 
      this.listView.AllowDrop = true;
      this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listView.Location = new System.Drawing.Point(0, 0);
      this.listView.MultiSelect = false;
      this.listView.Name = "listView";
      this.listView.ShowGroups = false;
      this.listView.Size = new System.Drawing.Size(293, 363);
      this.listView.TabIndex = 0;
      this.listView.UseCompatibleStateImageBehavior = false;
      // 
      // detailsStructure
      // 
      this.detailsStructure.ColumnCount = 2;
      this.detailsStructure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.detailsStructure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
      this.detailsStructure.Controls.Add(this.nameLabel, 0, 1);
      this.detailsStructure.Controls.Add(this.descLabel, 0, 2);
      this.detailsStructure.Controls.Add(this.versionLabel, 0, 3);
      this.detailsStructure.Controls.Add(this.updateLabel, 0, 4);
      this.detailsStructure.Controls.Add(this.name, 1, 1);
      this.detailsStructure.Controls.Add(this.description, 1, 2);
      this.detailsStructure.Controls.Add(this.version, 1, 3);
      this.detailsStructure.Controls.Add(this.update, 1, 4);
      this.detailsStructure.Controls.Add(this.image, 0, 0);
      this.detailsStructure.Dock = System.Windows.Forms.DockStyle.Fill;
      this.detailsStructure.Location = new System.Drawing.Point(0, 0);
      this.detailsStructure.Name = "detailsStructure";
      this.detailsStructure.RowCount = 5;
      this.detailsStructure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
      this.detailsStructure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.detailsStructure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
      this.detailsStructure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.detailsStructure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.detailsStructure.Size = new System.Drawing.Size(266, 363);
      this.detailsStructure.TabIndex = 0;
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.nameLabel.Location = new System.Drawing.Point(3, 199);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(60, 36);
      this.nameLabel.TabIndex = 0;
      this.nameLabel.Text = "Name:";
      this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // descLabel
      // 
      this.descLabel.AutoSize = true;
      this.descLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.descLabel.Location = new System.Drawing.Point(3, 235);
      this.descLabel.Name = "descLabel";
      this.descLabel.Size = new System.Drawing.Size(60, 54);
      this.descLabel.TabIndex = 1;
      this.descLabel.Text = "Description:";
      // 
      // versionLabel
      // 
      this.versionLabel.AutoSize = true;
      this.versionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.versionLabel.Location = new System.Drawing.Point(3, 289);
      this.versionLabel.Name = "versionLabel";
      this.versionLabel.Size = new System.Drawing.Size(60, 36);
      this.versionLabel.TabIndex = 2;
      this.versionLabel.Text = "Version:";
      this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // updateLabel
      // 
      this.updateLabel.AutoSize = true;
      this.updateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.updateLabel.Location = new System.Drawing.Point(3, 325);
      this.updateLabel.Name = "updateLabel";
      this.updateLabel.Size = new System.Drawing.Size(60, 38);
      this.updateLabel.TabIndex = 3;
      this.updateLabel.Text = "Update URL:";
      this.updateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // name
      // 
      this.name.AutoSize = true;
      this.name.Dock = System.Windows.Forms.DockStyle.Fill;
      this.name.Location = new System.Drawing.Point(69, 199);
      this.name.Name = "name";
      this.name.Size = new System.Drawing.Size(194, 36);
      this.name.TabIndex = 4;
      this.name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // description
      // 
      this.description.AutoSize = true;
      this.description.Dock = System.Windows.Forms.DockStyle.Fill;
      this.description.Location = new System.Drawing.Point(69, 235);
      this.description.Name = "description";
      this.description.Size = new System.Drawing.Size(194, 54);
      this.description.TabIndex = 5;
      // 
      // version
      // 
      this.version.AutoSize = true;
      this.version.Dock = System.Windows.Forms.DockStyle.Fill;
      this.version.Location = new System.Drawing.Point(69, 289);
      this.version.Name = "version";
      this.version.Size = new System.Drawing.Size(194, 36);
      this.version.TabIndex = 6;
      this.version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // update
      // 
      this.update.AutoSize = true;
      this.update.Dock = System.Windows.Forms.DockStyle.Fill;
      this.update.Location = new System.Drawing.Point(69, 325);
      this.update.Name = "update";
      this.update.Size = new System.Drawing.Size(194, 38);
      this.update.TabIndex = 7;
      this.update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // image
      // 
      this.detailsStructure.SetColumnSpan(this.image, 2);
      this.image.Dock = System.Windows.Forms.DockStyle.Fill;
      this.image.Location = new System.Drawing.Point(3, 3);
      this.image.Name = "image";
      this.image.Size = new System.Drawing.Size(260, 193);
      this.image.TabIndex = 8;
      this.image.TabStop = false;
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importArchiveToolStripMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(569, 24);
      this.menuStrip.TabIndex = 1;
      this.menuStrip.Text = "menuStrip1";
      // 
      // importArchiveToolStripMenuItem
      // 
      this.importArchiveToolStripMenuItem.Name = "importArchiveToolStripMenuItem";
      this.importArchiveToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
      this.importArchiveToolStripMenuItem.Text = "Import Archive";
      // 
      // mainStructure
      // 
      this.mainStructure.ColumnCount = 1;
      this.mainStructure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.mainStructure.Controls.Add(this.splitContainer, 0, 0);
      this.mainStructure.Controls.Add(this.play, 0, 1);
      this.mainStructure.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainStructure.Location = new System.Drawing.Point(0, 24);
      this.mainStructure.Name = "mainStructure";
      this.mainStructure.RowCount = 2;
      this.mainStructure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
      this.mainStructure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.mainStructure.Size = new System.Drawing.Size(569, 411);
      this.mainStructure.TabIndex = 2;
      // 
      // play
      // 
      this.play.Dock = System.Windows.Forms.DockStyle.Fill;
      this.play.Location = new System.Drawing.Point(3, 372);
      this.play.Name = "play";
      this.play.Size = new System.Drawing.Size(563, 36);
      this.play.TabIndex = 1;
      this.play.Text = "Play!";
      this.play.UseVisualStyleBackColor = true;
      // 
      // Loader
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(569, 435);
      this.Controls.Add(this.mainStructure);
      this.Controls.Add(this.menuStrip);
      this.Name = "Loader";
      this.Text = "Loader";
      this.splitContainer.Panel1.ResumeLayout(false);
      this.splitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
      this.splitContainer.ResumeLayout(false);
      this.detailsStructure.ResumeLayout(false);
      this.detailsStructure.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.mainStructure.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog openArchive;
    private System.Windows.Forms.SplitContainer splitContainer;
    private System.Windows.Forms.ListView listView;
    private System.Windows.Forms.TableLayoutPanel detailsStructure;
    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.Label descLabel;
    private System.Windows.Forms.Label versionLabel;
    private System.Windows.Forms.Label updateLabel;
    private System.Windows.Forms.Label name;
    private System.Windows.Forms.Label description;
    private System.Windows.Forms.Label version;
    private System.Windows.Forms.LinkLabel update;
    private System.Windows.Forms.PictureBox image;
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem importArchiveToolStripMenuItem;
    private System.Windows.Forms.TableLayoutPanel mainStructure;
    private System.Windows.Forms.Button play;
  }
}