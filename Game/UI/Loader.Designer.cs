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
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.importArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openArchive = new System.Windows.Forms.OpenFileDialog();
      this.archivesTable = new System.Windows.Forms.TableLayoutPanel();
      this.menuStrip.SuspendLayout();
      this.SuspendLayout();
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
      this.importArchiveToolStripMenuItem.Click += new System.EventHandler(this.ImportArchive);
      // 
      // openArchive
      // 
      this.openArchive.Filter = "School Game Content Archive (*.sgca)|*.sgca";
      //this.openArchive.Title = "Select the Content Archive to import";
      // 
      // archivesTable
      // 
      this.archivesTable.AutoScroll = true;
      this.archivesTable.ColumnCount = 1;
      this.archivesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.archivesTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.archivesTable.Location = new System.Drawing.Point(0, 24);
      this.archivesTable.Name = "archivesTable";
      this.archivesTable.RowCount = 1;
      this.archivesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.archivesTable.Size = new System.Drawing.Size(569, 411);
      this.archivesTable.TabIndex = 2;
      // 
      // Loader
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(569, 435);
      this.Controls.Add(this.archivesTable);
      this.Controls.Add(this.menuStrip);
      this.Name = "Loader";
      this.Text = "Loader";
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem importArchiveToolStripMenuItem;
    private System.Windows.Forms.OpenFileDialog openArchive;
    private System.Windows.Forms.TableLayoutPanel archivesTable;
  }
}