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
      System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Test");
      this.splitContainer = new System.Windows.Forms.SplitContainer();
      this.listView = new System.Windows.Forms.ListView();
      this.detailsStructure = new System.Windows.Forms.TableLayoutPanel();
      this.name = new System.Windows.Forms.Label();
      this.description = new System.Windows.Forms.Label();
      this.version = new System.Windows.Forms.Label();
      this.author = new System.Windows.Forms.Label();
      this.license = new System.Windows.Forms.Label();
      this.update = new System.Windows.Forms.LinkLabel();
      this.versionLabel = new System.Windows.Forms.Label();
      this.authorLabel = new System.Windows.Forms.Label();
      this.licenseLabel = new System.Windows.Forms.Label();
      this.updateLabel = new System.Windows.Forms.Label();
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.importArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mainStructure = new System.Windows.Forms.TableLayoutPanel();
      this.play = new System.Windows.Forms.Button();
      this.openArchive = new System.Windows.Forms.OpenFileDialog();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
      this.splitContainer.Panel1.SuspendLayout();
      this.splitContainer.Panel2.SuspendLayout();
      this.splitContainer.SuspendLayout();
      this.detailsStructure.SuspendLayout();
      this.menuStrip.SuspendLayout();
      this.mainStructure.SuspendLayout();
      this.SuspendLayout();
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
      this.splitContainer.SplitterDistance = 323;
      this.splitContainer.TabIndex = 0;
      // 
      // listView
      // 
      this.listView.AllowDrop = true;
      this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
      this.listView.Location = new System.Drawing.Point(0, 0);
      this.listView.MultiSelect = false;
      this.listView.Name = "listView";
      this.listView.ShowGroups = false;
      this.listView.Size = new System.Drawing.Size(323, 363);
      this.listView.TabIndex = 0;
      this.listView.UseCompatibleStateImageBehavior = false;
      this.listView.View = System.Windows.Forms.View.List;
      // 
      // detailsStructure
      // 
      this.detailsStructure.ColumnCount = 2;
      this.detailsStructure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.detailsStructure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
      this.detailsStructure.Controls.Add(this.name, 0, 0);
      this.detailsStructure.Controls.Add(this.description, 0, 1);
      this.detailsStructure.Controls.Add(this.version, 1, 2);
      this.detailsStructure.Controls.Add(this.author, 1, 3);
      this.detailsStructure.Controls.Add(this.license, 1, 4);
      this.detailsStructure.Controls.Add(this.update, 1, 5);
      this.detailsStructure.Controls.Add(this.versionLabel, 0, 2);
      this.detailsStructure.Controls.Add(this.authorLabel, 0, 3);
      this.detailsStructure.Controls.Add(this.licenseLabel, 0, 4);
      this.detailsStructure.Controls.Add(this.updateLabel, 0, 5);
      this.detailsStructure.Dock = System.Windows.Forms.DockStyle.Fill;
      this.detailsStructure.Location = new System.Drawing.Point(0, 0);
      this.detailsStructure.Name = "detailsStructure";
      this.detailsStructure.RowCount = 6;
      this.detailsStructure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.detailsStructure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
      this.detailsStructure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.detailsStructure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.detailsStructure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.detailsStructure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.detailsStructure.Size = new System.Drawing.Size(236, 363);
      this.detailsStructure.TabIndex = 0;
      // 
      // name
      // 
      this.name.AutoSize = true;
      this.detailsStructure.SetColumnSpan(this.name, 2);
      this.name.Dock = System.Windows.Forms.DockStyle.Fill;
      this.name.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.name.Location = new System.Drawing.Point(3, 0);
      this.name.Name = "name";
      this.name.Size = new System.Drawing.Size(230, 72);
      this.name.TabIndex = 4;
      this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // description
      // 
      this.description.AutoSize = true;
      this.detailsStructure.SetColumnSpan(this.description, 2);
      this.description.Dock = System.Windows.Forms.DockStyle.Fill;
      this.description.Location = new System.Drawing.Point(3, 72);
      this.description.Name = "description";
      this.description.Size = new System.Drawing.Size(230, 145);
      this.description.TabIndex = 5;
      this.description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // version
      // 
      this.version.AutoSize = true;
      this.version.Dock = System.Windows.Forms.DockStyle.Fill;
      this.version.Location = new System.Drawing.Point(62, 217);
      this.version.Name = "version";
      this.version.Size = new System.Drawing.Size(171, 36);
      this.version.TabIndex = 6;
      this.version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // author
      // 
      this.author.AutoSize = true;
      this.author.Dock = System.Windows.Forms.DockStyle.Fill;
      this.author.Location = new System.Drawing.Point(62, 253);
      this.author.Name = "author";
      this.author.Size = new System.Drawing.Size(171, 36);
      this.author.TabIndex = 10;
      this.author.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // license
      // 
      this.license.AutoSize = true;
      this.license.Dock = System.Windows.Forms.DockStyle.Fill;
      this.license.Location = new System.Drawing.Point(62, 289);
      this.license.Name = "license";
      this.license.Size = new System.Drawing.Size(171, 36);
      this.license.TabIndex = 11;
      this.license.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // update
      // 
      this.update.AutoSize = true;
      this.update.Dock = System.Windows.Forms.DockStyle.Fill;
      this.update.Location = new System.Drawing.Point(62, 325);
      this.update.Name = "update";
      this.update.Size = new System.Drawing.Size(171, 38);
      this.update.TabIndex = 7;
      this.update.TabStop = true;
      this.update.Text = "google.com";
      this.update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // versionLabel
      // 
      this.versionLabel.AutoSize = true;
      this.versionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.versionLabel.Location = new System.Drawing.Point(3, 217);
      this.versionLabel.Name = "versionLabel";
      this.versionLabel.Size = new System.Drawing.Size(53, 36);
      this.versionLabel.TabIndex = 2;
      this.versionLabel.Text = "Version:";
      this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // authorLabel
      // 
      this.authorLabel.AutoSize = true;
      this.authorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.authorLabel.Location = new System.Drawing.Point(3, 253);
      this.authorLabel.Name = "authorLabel";
      this.authorLabel.Size = new System.Drawing.Size(53, 36);
      this.authorLabel.TabIndex = 8;
      this.authorLabel.Text = "Author:";
      this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // licenseLabel
      // 
      this.licenseLabel.AutoSize = true;
      this.licenseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.licenseLabel.Location = new System.Drawing.Point(3, 289);
      this.licenseLabel.Name = "licenseLabel";
      this.licenseLabel.Size = new System.Drawing.Size(53, 36);
      this.licenseLabel.TabIndex = 9;
      this.licenseLabel.Text = "License:";
      this.licenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // updateLabel
      // 
      this.updateLabel.AutoSize = true;
      this.updateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.updateLabel.Location = new System.Drawing.Point(3, 325);
      this.updateLabel.Name = "updateLabel";
      this.updateLabel.Size = new System.Drawing.Size(53, 38);
      this.updateLabel.TabIndex = 3;
      this.updateLabel.Text = "Update URL:";
      this.updateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
      this.play.Enabled = false;
      this.play.Location = new System.Drawing.Point(3, 372);
      this.play.Name = "play";
      this.play.Size = new System.Drawing.Size(563, 36);
      this.play.TabIndex = 1;
      this.play.Text = "Play!";
      this.play.UseVisualStyleBackColor = true;
      // 
      // openArchive
      // 
      this.openArchive.Filter = "School Game Content Archive (*.sgca)|*.sgca";
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
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.mainStructure.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.SplitContainer splitContainer;
    private System.Windows.Forms.ListView listView;
    private System.Windows.Forms.TableLayoutPanel detailsStructure;
    private System.Windows.Forms.Label versionLabel;
    private System.Windows.Forms.Label updateLabel;
    private System.Windows.Forms.Label name;
    private System.Windows.Forms.Label description;
    private System.Windows.Forms.Label version;
    private System.Windows.Forms.LinkLabel update;
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem importArchiveToolStripMenuItem;
    private System.Windows.Forms.TableLayoutPanel mainStructure;
    private System.Windows.Forms.Button play;
    private System.Windows.Forms.Label authorLabel;
    private System.Windows.Forms.Label licenseLabel;
    private System.Windows.Forms.Label author;
    private System.Windows.Forms.Label license;
    private System.Windows.Forms.OpenFileDialog openArchive;
  }
}