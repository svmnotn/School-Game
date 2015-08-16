namespace SchoolGame.Game.UI.Controls {
  partial class ArchiveControl {
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.structuralTable = new System.Windows.Forms.TableLayoutPanel();
      this.infoTable = new System.Windows.Forms.TableLayoutPanel();
      this.title = new System.Windows.Forms.Label();
      this.description = new System.Windows.Forms.Label();
      this.detailsTable = new System.Windows.Forms.TableLayoutPanel();
      this.version = new System.Windows.Forms.Label();
      this.license = new System.Windows.Forms.Label();
      this.url = new System.Windows.Forms.LinkLabel();
      this.author = new System.Windows.Forms.Label();
      this.buttonTable = new System.Windows.Forms.TableLayoutPanel();
      this.play = new System.Windows.Forms.Button();
      this.delete = new System.Windows.Forms.Button();
      this.structuralTable.SuspendLayout();
      this.infoTable.SuspendLayout();
      this.detailsTable.SuspendLayout();
      this.buttonTable.SuspendLayout();
      this.SuspendLayout();
      // 
      // structuralTable
      // 
      this.structuralTable.ColumnCount = 1;
      this.structuralTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.structuralTable.Controls.Add(this.infoTable, 0, 0);
      this.structuralTable.Controls.Add(this.buttonTable, 0, 1);
      this.structuralTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.structuralTable.Location = new System.Drawing.Point(0, 0);
      this.structuralTable.Name = "structuralTable";
      this.structuralTable.RowCount = 2;
      this.structuralTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
      this.structuralTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.structuralTable.Size = new System.Drawing.Size(533, 191);
      this.structuralTable.TabIndex = 0;
      // 
      // infoTable
      // 
      this.infoTable.ColumnCount = 1;
      this.infoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.infoTable.Controls.Add(this.title, 0, 0);
      this.infoTable.Controls.Add(this.description, 0, 1);
      this.infoTable.Controls.Add(this.detailsTable, 0, 3);
      this.infoTable.Controls.Add(this.author, 0, 2);
      this.infoTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.infoTable.Location = new System.Drawing.Point(3, 3);
      this.infoTable.Name = "infoTable";
      this.infoTable.RowCount = 4;
      this.infoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.infoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.infoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
      this.infoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
      this.infoTable.Size = new System.Drawing.Size(527, 137);
      this.infoTable.TabIndex = 1;
      // 
      // title
      // 
      this.title.AutoSize = true;
      this.title.Dock = System.Windows.Forms.DockStyle.Fill;
      this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.title.Location = new System.Drawing.Point(3, 0);
      this.title.Name = "title";
      this.title.Size = new System.Drawing.Size(521, 27);
      this.title.TabIndex = 1;
      this.title.Text = "Title!";
      this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // description
      // 
      this.description.AutoSize = true;
      this.description.Dock = System.Windows.Forms.DockStyle.Fill;
      this.description.Location = new System.Drawing.Point(3, 27);
      this.description.Name = "description";
      this.description.Size = new System.Drawing.Size(521, 68);
      this.description.TabIndex = 2;
      this.description.Text = "this is a description!";
      // 
      // detailsTable
      // 
      this.detailsTable.ColumnCount = 3;
      this.detailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.detailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.detailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.detailsTable.Controls.Add(this.version, 0, 0);
      this.detailsTable.Controls.Add(this.license, 1, 0);
      this.detailsTable.Controls.Add(this.url, 2, 0);
      this.detailsTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.detailsTable.Location = new System.Drawing.Point(3, 118);
      this.detailsTable.Name = "detailsTable";
      this.detailsTable.RowCount = 1;
      this.detailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.detailsTable.Size = new System.Drawing.Size(521, 16);
      this.detailsTable.TabIndex = 0;
      // 
      // version
      // 
      this.version.AutoSize = true;
      this.version.Dock = System.Windows.Forms.DockStyle.Fill;
      this.version.Location = new System.Drawing.Point(3, 0);
      this.version.Name = "version";
      this.version.Size = new System.Drawing.Size(167, 16);
      this.version.TabIndex = 0;
      this.version.Text = "Version: 0.0.1";
      this.version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // license
      // 
      this.license.AutoSize = true;
      this.license.Dock = System.Windows.Forms.DockStyle.Fill;
      this.license.Location = new System.Drawing.Point(176, 0);
      this.license.Name = "license";
      this.license.Size = new System.Drawing.Size(167, 16);
      this.license.TabIndex = 1;
      this.license.Text = "License: Public Domain";
      this.license.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // url
      // 
      this.url.AutoSize = true;
      this.url.Dock = System.Windows.Forms.DockStyle.Fill;
      this.url.Location = new System.Drawing.Point(349, 0);
      this.url.Name = "url";
      this.url.Size = new System.Drawing.Size(169, 16);
      this.url.TabIndex = 2;
      this.url.TabStop = true;
      this.url.Text = "updateme.com";
      this.url.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // author
      // 
      this.author.AutoSize = true;
      this.author.Dock = System.Windows.Forms.DockStyle.Fill;
      this.author.Location = new System.Drawing.Point(3, 95);
      this.author.Name = "author";
      this.author.Size = new System.Drawing.Size(521, 20);
      this.author.TabIndex = 3;
      this.author.Text = "Author(s): ";
      this.author.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // buttonTable
      // 
      this.buttonTable.ColumnCount = 2;
      this.buttonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.buttonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.buttonTable.Controls.Add(this.play, 0, 0);
      this.buttonTable.Controls.Add(this.delete, 1, 0);
      this.buttonTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonTable.Location = new System.Drawing.Point(3, 146);
      this.buttonTable.Name = "buttonTable";
      this.buttonTable.RowCount = 1;
      this.buttonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.buttonTable.Size = new System.Drawing.Size(527, 42);
      this.buttonTable.TabIndex = 0;
      // 
      // play
      // 
      this.play.Dock = System.Windows.Forms.DockStyle.Fill;
      this.play.Location = new System.Drawing.Point(3, 3);
      this.play.Name = "play";
      this.play.Size = new System.Drawing.Size(257, 36);
      this.play.TabIndex = 0;
      this.play.Text = "Play!";
      this.play.UseVisualStyleBackColor = true;
      this.play.Click += new System.EventHandler(this.Play);
      // 
      // delete
      // 
      this.delete.Dock = System.Windows.Forms.DockStyle.Fill;
      this.delete.Location = new System.Drawing.Point(266, 3);
      this.delete.Name = "delete";
      this.delete.Size = new System.Drawing.Size(258, 36);
      this.delete.TabIndex = 1;
      this.delete.Text = "Delete this";
      this.delete.UseVisualStyleBackColor = true;
      this.delete.Click += new System.EventHandler(this.Delete);
      // 
      // ArchiveControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.structuralTable);
      this.Name = "ArchiveControl";
      this.Size = new System.Drawing.Size(533, 191);
      this.structuralTable.ResumeLayout(false);
      this.infoTable.ResumeLayout(false);
      this.infoTable.PerformLayout();
      this.detailsTable.ResumeLayout(false);
      this.detailsTable.PerformLayout();
      this.buttonTable.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel structuralTable;
    private System.Windows.Forms.TableLayoutPanel buttonTable;
    private System.Windows.Forms.TableLayoutPanel infoTable;
    private System.Windows.Forms.TableLayoutPanel detailsTable;
    private System.Windows.Forms.Button play;
    private System.Windows.Forms.Button delete;
    private System.Windows.Forms.Label version;
    private System.Windows.Forms.Label license;
    private System.Windows.Forms.LinkLabel url;
    private System.Windows.Forms.Label title;
    private System.Windows.Forms.Label description;
    private System.Windows.Forms.Label author;
  }
}
