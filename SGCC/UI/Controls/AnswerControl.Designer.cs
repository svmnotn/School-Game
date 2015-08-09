namespace SchoolGame.SGCC.UI {
  partial class AnswerControl {
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
      this.structureTable = new System.Windows.Forms.TableLayoutPanel();
      this.answerPicture = new System.Windows.Forms.PictureBox();
      this.dataTable = new System.Windows.Forms.TableLayoutPanel();
      this.answerTable = new System.Windows.Forms.TableLayoutPanel();
      this.answerLabel = new System.Windows.Forms.Label();
      this.answer = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.button1 = new System.Windows.Forms.Button();
      this.correct = new System.Windows.Forms.CheckBox();
      this.structureTable.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.answerPicture)).BeginInit();
      this.dataTable.SuspendLayout();
      this.answerTable.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // structureTable
      // 
      this.structureTable.ColumnCount = 2;
      this.structureTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.structureTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
      this.structureTable.Controls.Add(this.answerPicture, 0, 0);
      this.structureTable.Controls.Add(this.dataTable, 1, 0);
      this.structureTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.structureTable.Location = new System.Drawing.Point(0, 0);
      this.structureTable.Margin = new System.Windows.Forms.Padding(0);
      this.structureTable.Name = "structureTable";
      this.structureTable.RowCount = 1;
      this.structureTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.structureTable.Size = new System.Drawing.Size(398, 98);
      this.structureTable.TabIndex = 0;
      // 
      // answerPicture
      // 
      this.answerPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.answerPicture.Dock = System.Windows.Forms.DockStyle.Fill;
      this.answerPicture.Location = new System.Drawing.Point(3, 3);
      this.answerPicture.Name = "answerPicture";
      this.answerPicture.Size = new System.Drawing.Size(93, 92);
      this.answerPicture.TabIndex = 0;
      this.answerPicture.TabStop = false;
      this.answerPicture.Click += new System.EventHandler(this.imageClick);
      // 
      // dataTable
      // 
      this.dataTable.ColumnCount = 1;
      this.dataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.dataTable.Controls.Add(this.answerTable, 0, 0);
      this.dataTable.Controls.Add(this.tableLayoutPanel1, 0, 1);
      this.dataTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataTable.Location = new System.Drawing.Point(99, 0);
      this.dataTable.Margin = new System.Windows.Forms.Padding(0);
      this.dataTable.Name = "dataTable";
      this.dataTable.RowCount = 2;
      this.dataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.dataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.dataTable.Size = new System.Drawing.Size(299, 98);
      this.dataTable.TabIndex = 1;
      // 
      // answerTable
      // 
      this.answerTable.ColumnCount = 2;
      this.answerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.answerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
      this.answerTable.Controls.Add(this.answerLabel, 0, 0);
      this.answerTable.Controls.Add(this.answer, 1, 0);
      this.answerTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.answerTable.Location = new System.Drawing.Point(0, 0);
      this.answerTable.Margin = new System.Windows.Forms.Padding(0);
      this.answerTable.Name = "answerTable";
      this.answerTable.RowCount = 1;
      this.answerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.answerTable.Size = new System.Drawing.Size(299, 49);
      this.answerTable.TabIndex = 1;
      // 
      // answerLabel
      // 
      this.answerLabel.AutoSize = true;
      this.answerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.answerLabel.Location = new System.Drawing.Point(3, 0);
      this.answerLabel.Name = "answerLabel";
      this.answerLabel.Size = new System.Drawing.Size(68, 49);
      this.answerLabel.TabIndex = 0;
      this.answerLabel.Text = "Answer:";
      this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // answer
      // 
      this.answer.AcceptsReturn = true;
      this.answer.AcceptsTab = true;
      this.answer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.answer.Location = new System.Drawing.Point(77, 3);
      this.answer.Multiline = true;
      this.answer.Name = "answer";
      this.answer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.answer.Size = new System.Drawing.Size(219, 43);
      this.answer.TabIndex = 1;
      this.answer.TextChanged += new System.EventHandler(this.textChange);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.correct, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 52);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 43);
      this.tableLayoutPanel1.TabIndex = 2;
      // 
      // button1
      // 
      this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button1.Location = new System.Drawing.Point(149, 3);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(141, 37);
      this.button1.TabIndex = 0;
      this.button1.Text = "Delete this answer";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.delete);
      // 
      // correct
      // 
      this.correct.AutoSize = true;
      this.correct.Dock = System.Windows.Forms.DockStyle.Fill;
      this.correct.Location = new System.Drawing.Point(3, 3);
      this.correct.Name = "correct";
      this.correct.Size = new System.Drawing.Size(140, 37);
      this.correct.TabIndex = 1;
      this.correct.Text = "Correct";
      this.correct.UseVisualStyleBackColor = true;
      this.correct.CheckedChanged += new System.EventHandler(this.checkedChange);
      // 
      // AnswerControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.structureTable);
      this.Name = "AnswerControl";
      this.Size = new System.Drawing.Size(398, 98);
      this.structureTable.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.answerPicture)).EndInit();
      this.dataTable.ResumeLayout(false);
      this.answerTable.ResumeLayout(false);
      this.answerTable.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel structureTable;
    private System.Windows.Forms.PictureBox answerPicture;
    private System.Windows.Forms.TableLayoutPanel dataTable;
    private System.Windows.Forms.TableLayoutPanel answerTable;
    private System.Windows.Forms.Label answerLabel;
    private System.Windows.Forms.TextBox answer;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.CheckBox correct;
  }
}
