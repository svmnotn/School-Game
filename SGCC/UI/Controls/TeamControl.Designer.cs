namespace SchoolGame.SGCC.UI.Controls {
  partial class TeamControl {
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
      this.nameLabel = new System.Windows.Forms.Label();
      this.colorLabel = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.name = new System.Windows.Forms.TextBox();
      this.color = new System.Windows.Forms.TextBox();
      this.font = new System.Windows.Forms.TextBox();
      this.delete = new System.Windows.Forms.Button();
      this.structuralTable.SuspendLayout();
      this.SuspendLayout();
      // 
      // structuralTable
      // 
      this.structuralTable.ColumnCount = 2;
      this.structuralTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.structuralTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
      this.structuralTable.Controls.Add(this.nameLabel, 0, 0);
      this.structuralTable.Controls.Add(this.colorLabel, 0, 1);
      this.structuralTable.Controls.Add(this.label3, 0, 2);
      this.structuralTable.Controls.Add(this.name, 1, 0);
      this.structuralTable.Controls.Add(this.color, 1, 1);
      this.structuralTable.Controls.Add(this.font, 1, 2);
      this.structuralTable.Controls.Add(this.delete, 0, 3);
      this.structuralTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.structuralTable.Location = new System.Drawing.Point(0, 0);
      this.structuralTable.Name = "structuralTable";
      this.structuralTable.RowCount = 4;
      this.structuralTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.structuralTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.structuralTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.structuralTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.structuralTable.Size = new System.Drawing.Size(350, 100);
      this.structuralTable.TabIndex = 0;
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.nameLabel.Location = new System.Drawing.Point(3, 0);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(81, 25);
      this.nameLabel.TabIndex = 0;
      this.nameLabel.Text = "Team Name:";
      this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // colorLabel
      // 
      this.colorLabel.AutoSize = true;
      this.colorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.colorLabel.Location = new System.Drawing.Point(3, 25);
      this.colorLabel.Name = "colorLabel";
      this.colorLabel.Size = new System.Drawing.Size(81, 25);
      this.colorLabel.TabIndex = 1;
      this.colorLabel.Text = "Team Color:";
      this.colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label3.Location = new System.Drawing.Point(3, 50);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(81, 25);
      this.label3.TabIndex = 2;
      this.label3.Text = "Team Font:";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // name
      // 
      this.name.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.name.Location = new System.Drawing.Point(90, 3);
      this.name.Name = "name";
      this.name.Size = new System.Drawing.Size(257, 20);
      this.name.TabIndex = 3;
      this.name.TextChanged += new System.EventHandler(this.NameChange);
      // 
      // color
      // 
      this.color.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.color.Location = new System.Drawing.Point(90, 28);
      this.color.Name = "color";
      this.color.Size = new System.Drawing.Size(257, 20);
      this.color.TabIndex = 4;
      this.color.Click += new System.EventHandler(this.ColorClick);
      // 
      // font
      // 
      this.font.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.font.Location = new System.Drawing.Point(90, 53);
      this.font.Name = "font";
      this.font.Size = new System.Drawing.Size(257, 20);
      this.font.TabIndex = 5;
      this.font.Click += new System.EventHandler(this.FontClick);
      // 
      // delete
      // 
      this.structuralTable.SetColumnSpan(this.delete, 2);
      this.delete.Dock = System.Windows.Forms.DockStyle.Fill;
      this.delete.Location = new System.Drawing.Point(3, 78);
      this.delete.Name = "delete";
      this.delete.Size = new System.Drawing.Size(344, 19);
      this.delete.TabIndex = 6;
      this.delete.Text = "Delete this Team";
      this.delete.UseVisualStyleBackColor = true;
      this.delete.Click += new System.EventHandler(this.DeleteClick);
      // 
      // TeamControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.structuralTable);
      this.Name = "TeamControl";
      this.Size = new System.Drawing.Size(350, 100);
      this.structuralTable.ResumeLayout(false);
      this.structuralTable.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel structuralTable;
    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.Label colorLabel;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox name;
    private System.Windows.Forms.TextBox color;
    private System.Windows.Forms.TextBox font;
    private System.Windows.Forms.Button delete;
  }
}
