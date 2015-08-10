namespace SchoolGame.SGCC.UI {
  partial class InputDialog {
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.questionLabel = new System.Windows.Forms.Label();
      this.userInput = new System.Windows.Forms.TextBox();
      this.done = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.questionLabel, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.userInput, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.done, 0, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 100);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // questionLabel
      // 
      this.questionLabel.AutoSize = true;
      this.questionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.questionLabel.Location = new System.Drawing.Point(3, 0);
      this.questionLabel.Name = "questionLabel";
      this.questionLabel.Size = new System.Drawing.Size(304, 50);
      this.questionLabel.TabIndex = 0;
      this.questionLabel.Text = "label1";
      // 
      // userInput
      // 
      this.userInput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.userInput.Location = new System.Drawing.Point(3, 53);
      this.userInput.Name = "userInput";
      this.userInput.Size = new System.Drawing.Size(304, 20);
      this.userInput.TabIndex = 1;
      // 
      // done
      // 
      this.done.Dock = System.Windows.Forms.DockStyle.Fill;
      this.done.Location = new System.Drawing.Point(0, 75);
      this.done.Margin = new System.Windows.Forms.Padding(0);
      this.done.Name = "done";
      this.done.Size = new System.Drawing.Size(310, 25);
      this.done.TabIndex = 2;
      this.done.Text = "Done";
      this.done.UseVisualStyleBackColor = true;
      this.done.Click += new System.EventHandler(this.Done);
      // 
      // InputDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(310, 100);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "InputDialog";
      this.Text = "InputDialog";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label questionLabel;
    public System.Windows.Forms.TextBox userInput;
    private System.Windows.Forms.Button done;
  }
}