namespace SchoolGame.SGCC.UI {
  partial class MainScreen {
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
      this.tabControl = new System.Windows.Forms.TabControl();
      this.generalTab = new System.Windows.Forms.TabPage();
      this.generalTable = new System.Windows.Forms.TableLayoutPanel();
      this.timeInfoGroup = new System.Windows.Forms.GroupBox();
      this.timeTable = new System.Windows.Forms.TableLayoutPanel();
      this.timerFontLabel = new System.Windows.Forms.Label();
      this.timerColorLabel = new System.Windows.Forms.Label();
      this.beforeAnswerLabel = new System.Windows.Forms.Label();
      this.afterAnswerLabel = new System.Windows.Forms.Label();
      this.delayScoreLabel = new System.Windows.Forms.Label();
      this.delayGOLabel = new System.Windows.Forms.Label();
      this.timerFont = new System.Windows.Forms.TextBox();
      this.timerColor = new System.Windows.Forms.TextBox();
      this.beforeAnswer = new System.Windows.Forms.NumericUpDown();
      this.afterAnswer = new System.Windows.Forms.NumericUpDown();
      this.delayScore = new System.Windows.Forms.NumericUpDown();
      this.delayGO = new System.Windows.Forms.NumericUpDown();
      this.soundInfoGroup = new System.Windows.Forms.GroupBox();
      this.soundTable = new System.Windows.Forms.TableLayoutPanel();
      this.bkgSoundLabel = new System.Windows.Forms.Label();
      this.correctSoundLabel = new System.Windows.Forms.Label();
      this.wrongSoundLabel = new System.Windows.Forms.Label();
      this.bkgSound = new System.Windows.Forms.TextBox();
      this.correctSound = new System.Windows.Forms.TextBox();
      this.wrongSound = new System.Windows.Forms.TextBox();
      this.generalInfoGroup = new System.Windows.Forms.GroupBox();
      this.generalSTable = new System.Windows.Forms.TableLayoutPanel();
      this.bkgColorLabel = new System.Windows.Forms.Label();
      this.bkgImageLabel = new System.Windows.Forms.Label();
      this.bkgImage = new System.Windows.Forms.PictureBox();
      this.bkgColor = new System.Windows.Forms.TextBox();
      this.archiveInfoGroup = new System.Windows.Forms.GroupBox();
      this.archiveTable = new System.Windows.Forms.TableLayoutPanel();
      this.archiveName = new System.Windows.Forms.TextBox();
      this.archiveDesc = new System.Windows.Forms.TextBox();
      this.updateURL = new System.Windows.Forms.TextBox();
      this.archiveNameLabel = new System.Windows.Forms.Label();
      this.archiveDescLabel = new System.Windows.Forms.Label();
      this.archiveURLLabel = new System.Windows.Forms.Label();
      this.questionsTab = new System.Windows.Forms.TabPage();
      this.teamsTab = new System.Windows.Forms.TabPage();
      this.mainMenu = new System.Windows.Forms.MenuStrip();
      this.archivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.colorDialog = new System.Windows.Forms.ColorDialog();
      this.openImage = new System.Windows.Forms.OpenFileDialog();
      this.openSound = new System.Windows.Forms.OpenFileDialog();
      this.fontDialog = new System.Windows.Forms.FontDialog();
      this.openArchive = new System.Windows.Forms.OpenFileDialog();
      this.saveArchiveDialog = new System.Windows.Forms.SaveFileDialog();
      this.tabControl.SuspendLayout();
      this.generalTab.SuspendLayout();
      this.generalTable.SuspendLayout();
      this.timeInfoGroup.SuspendLayout();
      this.timeTable.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.beforeAnswer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.afterAnswer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.delayScore)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.delayGO)).BeginInit();
      this.soundInfoGroup.SuspendLayout();
      this.soundTable.SuspendLayout();
      this.generalInfoGroup.SuspendLayout();
      this.generalSTable.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bkgImage)).BeginInit();
      this.archiveInfoGroup.SuspendLayout();
      this.archiveTable.SuspendLayout();
      this.mainMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl
      // 
      this.tabControl.Controls.Add(this.generalTab);
      this.tabControl.Controls.Add(this.questionsTab);
      this.tabControl.Controls.Add(this.teamsTab);
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(0, 24);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(759, 539);
      this.tabControl.TabIndex = 0;
      // 
      // generalTab
      // 
      this.generalTab.Controls.Add(this.generalTable);
      this.generalTab.Location = new System.Drawing.Point(4, 22);
      this.generalTab.Name = "generalTab";
      this.generalTab.Padding = new System.Windows.Forms.Padding(3);
      this.generalTab.Size = new System.Drawing.Size(751, 513);
      this.generalTab.TabIndex = 0;
      this.generalTab.Text = "General Information";
      this.generalTab.UseVisualStyleBackColor = true;
      // 
      // generalTable
      // 
      this.generalTable.ColumnCount = 1;
      this.generalTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.generalTable.Controls.Add(this.timeInfoGroup, 0, 3);
      this.generalTable.Controls.Add(this.soundInfoGroup, 0, 2);
      this.generalTable.Controls.Add(this.generalInfoGroup, 0, 1);
      this.generalTable.Controls.Add(this.archiveInfoGroup, 0, 0);
      this.generalTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.generalTable.Location = new System.Drawing.Point(3, 3);
      this.generalTable.Name = "generalTable";
      this.generalTable.RowCount = 4;
      this.generalTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.generalTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.generalTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.generalTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
      this.generalTable.Size = new System.Drawing.Size(745, 507);
      this.generalTable.TabIndex = 0;
      // 
      // timeInfoGroup
      // 
      this.timeInfoGroup.BackColor = System.Drawing.Color.Transparent;
      this.timeInfoGroup.Controls.Add(this.timeTable);
      this.timeInfoGroup.Dock = System.Windows.Forms.DockStyle.Fill;
      this.timeInfoGroup.Location = new System.Drawing.Point(3, 356);
      this.timeInfoGroup.Name = "timeInfoGroup";
      this.timeInfoGroup.Size = new System.Drawing.Size(739, 148);
      this.timeInfoGroup.TabIndex = 3;
      this.timeInfoGroup.TabStop = false;
      this.timeInfoGroup.Text = "Time Settings";
      // 
      // timeTable
      // 
      this.timeTable.ColumnCount = 2;
      this.timeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.timeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
      this.timeTable.Controls.Add(this.timerFontLabel, 0, 0);
      this.timeTable.Controls.Add(this.timerColorLabel, 0, 1);
      this.timeTable.Controls.Add(this.beforeAnswerLabel, 0, 2);
      this.timeTable.Controls.Add(this.afterAnswerLabel, 0, 3);
      this.timeTable.Controls.Add(this.delayScoreLabel, 0, 4);
      this.timeTable.Controls.Add(this.delayGOLabel, 0, 5);
      this.timeTable.Controls.Add(this.timerFont, 1, 0);
      this.timeTable.Controls.Add(this.timerColor, 1, 1);
      this.timeTable.Controls.Add(this.beforeAnswer, 1, 2);
      this.timeTable.Controls.Add(this.afterAnswer, 1, 3);
      this.timeTable.Controls.Add(this.delayScore, 1, 4);
      this.timeTable.Controls.Add(this.delayGO, 1, 5);
      this.timeTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.timeTable.Location = new System.Drawing.Point(3, 16);
      this.timeTable.Name = "timeTable";
      this.timeTable.RowCount = 6;
      this.timeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.timeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.timeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.timeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.timeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.timeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.timeTable.Size = new System.Drawing.Size(733, 129);
      this.timeTable.TabIndex = 0;
      // 
      // timerFontLabel
      // 
      this.timerFontLabel.AutoSize = true;
      this.timerFontLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.timerFontLabel.Location = new System.Drawing.Point(3, 0);
      this.timerFontLabel.Name = "timerFontLabel";
      this.timerFontLabel.Size = new System.Drawing.Size(177, 21);
      this.timerFontLabel.TabIndex = 0;
      this.timerFontLabel.Text = "Timer Font:";
      this.timerFontLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // timerColorLabel
      // 
      this.timerColorLabel.AutoSize = true;
      this.timerColorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.timerColorLabel.Location = new System.Drawing.Point(3, 21);
      this.timerColorLabel.Name = "timerColorLabel";
      this.timerColorLabel.Size = new System.Drawing.Size(177, 21);
      this.timerColorLabel.TabIndex = 1;
      this.timerColorLabel.Text = "Timer Color:";
      this.timerColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // beforeAnswerLabel
      // 
      this.beforeAnswerLabel.AutoSize = true;
      this.beforeAnswerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.beforeAnswerLabel.Location = new System.Drawing.Point(3, 42);
      this.beforeAnswerLabel.Name = "beforeAnswerLabel";
      this.beforeAnswerLabel.Size = new System.Drawing.Size(177, 21);
      this.beforeAnswerLabel.TabIndex = 2;
      this.beforeAnswerLabel.Text = "Time before question answer:";
      this.beforeAnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // afterAnswerLabel
      // 
      this.afterAnswerLabel.AutoSize = true;
      this.afterAnswerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.afterAnswerLabel.Location = new System.Drawing.Point(3, 63);
      this.afterAnswerLabel.Name = "afterAnswerLabel";
      this.afterAnswerLabel.Size = new System.Drawing.Size(177, 21);
      this.afterAnswerLabel.TabIndex = 3;
      this.afterAnswerLabel.Text = "Delay after Answer:";
      this.afterAnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // delayScoreLabel
      // 
      this.delayScoreLabel.AutoSize = true;
      this.delayScoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.delayScoreLabel.Location = new System.Drawing.Point(3, 84);
      this.delayScoreLabel.Name = "delayScoreLabel";
      this.delayScoreLabel.Size = new System.Drawing.Size(177, 21);
      this.delayScoreLabel.TabIndex = 4;
      this.delayScoreLabel.Text = "Delay to see the Score:";
      this.delayScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // delayGOLabel
      // 
      this.delayGOLabel.AutoSize = true;
      this.delayGOLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.delayGOLabel.Location = new System.Drawing.Point(3, 105);
      this.delayGOLabel.Name = "delayGOLabel";
      this.delayGOLabel.Size = new System.Drawing.Size(177, 24);
      this.delayGOLabel.TabIndex = 5;
      this.delayGOLabel.Text = "Delay after Game Over:";
      this.delayGOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // timerFont
      // 
      this.timerFont.Dock = System.Windows.Forms.DockStyle.Fill;
      this.timerFont.Location = new System.Drawing.Point(186, 3);
      this.timerFont.Name = "timerFont";
      this.timerFont.Size = new System.Drawing.Size(544, 20);
      this.timerFont.TabIndex = 6;
      this.timerFont.Click += new System.EventHandler(this.SelectTimerFont);
      // 
      // timerColor
      // 
      this.timerColor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.timerColor.Location = new System.Drawing.Point(186, 24);
      this.timerColor.Name = "timerColor";
      this.timerColor.Size = new System.Drawing.Size(544, 20);
      this.timerColor.TabIndex = 7;
      this.timerColor.Click += new System.EventHandler(this.SelectTimerColor);
      // 
      // beforeAnswer
      // 
      this.beforeAnswer.DecimalPlaces = 4;
      this.beforeAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.beforeAnswer.Location = new System.Drawing.Point(186, 45);
      this.beforeAnswer.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
      this.beforeAnswer.Name = "beforeAnswer";
      this.beforeAnswer.Size = new System.Drawing.Size(544, 20);
      this.beforeAnswer.TabIndex = 8;
      this.beforeAnswer.ValueChanged += new System.EventHandler(this.SetBeforeQuestion);
      // 
      // afterAnswer
      // 
      this.afterAnswer.DecimalPlaces = 4;
      this.afterAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.afterAnswer.Location = new System.Drawing.Point(186, 66);
      this.afterAnswer.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
      this.afterAnswer.Name = "afterAnswer";
      this.afterAnswer.Size = new System.Drawing.Size(544, 20);
      this.afterAnswer.TabIndex = 9;
      this.afterAnswer.ValueChanged += new System.EventHandler(this.SetAfterQuestion);
      // 
      // delayScore
      // 
      this.delayScore.DecimalPlaces = 4;
      this.delayScore.Dock = System.Windows.Forms.DockStyle.Fill;
      this.delayScore.Location = new System.Drawing.Point(186, 87);
      this.delayScore.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
      this.delayScore.Name = "delayScore";
      this.delayScore.Size = new System.Drawing.Size(544, 20);
      this.delayScore.TabIndex = 10;
      this.delayScore.ValueChanged += new System.EventHandler(this.SetScoreDelay);
      // 
      // delayGO
      // 
      this.delayGO.DecimalPlaces = 4;
      this.delayGO.Dock = System.Windows.Forms.DockStyle.Fill;
      this.delayGO.Location = new System.Drawing.Point(186, 108);
      this.delayGO.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
      this.delayGO.Name = "delayGO";
      this.delayGO.Size = new System.Drawing.Size(544, 20);
      this.delayGO.TabIndex = 11;
      this.delayGO.ValueChanged += new System.EventHandler(this.SetGODelay);
      // 
      // soundInfoGroup
      // 
      this.soundInfoGroup.Controls.Add(this.soundTable);
      this.soundInfoGroup.Dock = System.Windows.Forms.DockStyle.Fill;
      this.soundInfoGroup.Location = new System.Drawing.Point(3, 255);
      this.soundInfoGroup.Name = "soundInfoGroup";
      this.soundInfoGroup.Size = new System.Drawing.Size(739, 95);
      this.soundInfoGroup.TabIndex = 2;
      this.soundInfoGroup.TabStop = false;
      this.soundInfoGroup.Text = "Sound Settings";
      // 
      // soundTable
      // 
      this.soundTable.ColumnCount = 2;
      this.soundTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.soundTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
      this.soundTable.Controls.Add(this.bkgSoundLabel, 0, 0);
      this.soundTable.Controls.Add(this.correctSoundLabel, 0, 1);
      this.soundTable.Controls.Add(this.wrongSoundLabel, 0, 2);
      this.soundTable.Controls.Add(this.bkgSound, 1, 0);
      this.soundTable.Controls.Add(this.correctSound, 1, 1);
      this.soundTable.Controls.Add(this.wrongSound, 1, 2);
      this.soundTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.soundTable.Location = new System.Drawing.Point(3, 16);
      this.soundTable.Name = "soundTable";
      this.soundTable.RowCount = 3;
      this.soundTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.soundTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.soundTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.soundTable.Size = new System.Drawing.Size(733, 76);
      this.soundTable.TabIndex = 0;
      // 
      // bkgSoundLabel
      // 
      this.bkgSoundLabel.AutoSize = true;
      this.bkgSoundLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bkgSoundLabel.Location = new System.Drawing.Point(3, 0);
      this.bkgSoundLabel.Name = "bkgSoundLabel";
      this.bkgSoundLabel.Size = new System.Drawing.Size(177, 25);
      this.bkgSoundLabel.TabIndex = 0;
      this.bkgSoundLabel.Text = "Background Music:";
      this.bkgSoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // correctSoundLabel
      // 
      this.correctSoundLabel.AutoSize = true;
      this.correctSoundLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.correctSoundLabel.Location = new System.Drawing.Point(3, 25);
      this.correctSoundLabel.Name = "correctSoundLabel";
      this.correctSoundLabel.Size = new System.Drawing.Size(177, 25);
      this.correctSoundLabel.TabIndex = 1;
      this.correctSoundLabel.Text = "Correct Sound:";
      this.correctSoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // wrongSoundLabel
      // 
      this.wrongSoundLabel.AutoSize = true;
      this.wrongSoundLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.wrongSoundLabel.Location = new System.Drawing.Point(3, 50);
      this.wrongSoundLabel.Name = "wrongSoundLabel";
      this.wrongSoundLabel.Size = new System.Drawing.Size(177, 26);
      this.wrongSoundLabel.TabIndex = 2;
      this.wrongSoundLabel.Text = "Wrong Sound:";
      this.wrongSoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // bkgSound
      // 
      this.bkgSound.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bkgSound.Location = new System.Drawing.Point(186, 3);
      this.bkgSound.Name = "bkgSound";
      this.bkgSound.Size = new System.Drawing.Size(544, 20);
      this.bkgSound.TabIndex = 3;
      this.bkgSound.Click += new System.EventHandler(this.SelectBkgSound);
      // 
      // correctSound
      // 
      this.correctSound.Dock = System.Windows.Forms.DockStyle.Fill;
      this.correctSound.Location = new System.Drawing.Point(186, 28);
      this.correctSound.Name = "correctSound";
      this.correctSound.Size = new System.Drawing.Size(544, 20);
      this.correctSound.TabIndex = 4;
      this.correctSound.Click += new System.EventHandler(this.SelectCorrectSound);
      // 
      // wrongSound
      // 
      this.wrongSound.Dock = System.Windows.Forms.DockStyle.Fill;
      this.wrongSound.Location = new System.Drawing.Point(186, 53);
      this.wrongSound.Name = "wrongSound";
      this.wrongSound.Size = new System.Drawing.Size(544, 20);
      this.wrongSound.TabIndex = 5;
      this.wrongSound.Click += new System.EventHandler(this.SelectWrongSound);
      // 
      // generalInfoGroup
      // 
      this.generalInfoGroup.Controls.Add(this.generalSTable);
      this.generalInfoGroup.Dock = System.Windows.Forms.DockStyle.Fill;
      this.generalInfoGroup.Location = new System.Drawing.Point(3, 129);
      this.generalInfoGroup.Name = "generalInfoGroup";
      this.generalInfoGroup.Size = new System.Drawing.Size(739, 120);
      this.generalInfoGroup.TabIndex = 1;
      this.generalInfoGroup.TabStop = false;
      this.generalInfoGroup.Text = "General Settings";
      // 
      // generalSTable
      // 
      this.generalSTable.ColumnCount = 2;
      this.generalSTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.generalSTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
      this.generalSTable.Controls.Add(this.bkgColorLabel, 0, 0);
      this.generalSTable.Controls.Add(this.bkgImageLabel, 0, 1);
      this.generalSTable.Controls.Add(this.bkgImage, 1, 1);
      this.generalSTable.Controls.Add(this.bkgColor, 1, 0);
      this.generalSTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.generalSTable.Location = new System.Drawing.Point(3, 16);
      this.generalSTable.Name = "generalSTable";
      this.generalSTable.RowCount = 2;
      this.generalSTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.generalSTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
      this.generalSTable.Size = new System.Drawing.Size(733, 101);
      this.generalSTable.TabIndex = 0;
      // 
      // bkgColorLabel
      // 
      this.bkgColorLabel.AutoSize = true;
      this.bkgColorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bkgColorLabel.Location = new System.Drawing.Point(3, 0);
      this.bkgColorLabel.Name = "bkgColorLabel";
      this.bkgColorLabel.Size = new System.Drawing.Size(177, 25);
      this.bkgColorLabel.TabIndex = 0;
      this.bkgColorLabel.Text = "Background Color:";
      this.bkgColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // bkgImageLabel
      // 
      this.bkgImageLabel.AutoSize = true;
      this.bkgImageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bkgImageLabel.Location = new System.Drawing.Point(3, 25);
      this.bkgImageLabel.Name = "bkgImageLabel";
      this.bkgImageLabel.Size = new System.Drawing.Size(177, 76);
      this.bkgImageLabel.TabIndex = 1;
      this.bkgImageLabel.Text = "Background Image:";
      this.bkgImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // bkgImage
      // 
      this.bkgImage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bkgImage.Location = new System.Drawing.Point(186, 28);
      this.bkgImage.Name = "bkgImage";
      this.bkgImage.Size = new System.Drawing.Size(544, 70);
      this.bkgImage.TabIndex = 2;
      this.bkgImage.TabStop = false;
      this.bkgImage.Click += new System.EventHandler(this.SelectBkgImage);
      // 
      // bkgColor
      // 
      this.bkgColor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bkgColor.Location = new System.Drawing.Point(186, 3);
      this.bkgColor.Name = "bkgColor";
      this.bkgColor.Size = new System.Drawing.Size(544, 20);
      this.bkgColor.TabIndex = 3;
      this.bkgColor.Click += new System.EventHandler(this.SelectBkgColor);
      // 
      // archiveInfoGroup
      // 
      this.archiveInfoGroup.Controls.Add(this.archiveTable);
      this.archiveInfoGroup.Dock = System.Windows.Forms.DockStyle.Fill;
      this.archiveInfoGroup.Location = new System.Drawing.Point(3, 3);
      this.archiveInfoGroup.Name = "archiveInfoGroup";
      this.archiveInfoGroup.Size = new System.Drawing.Size(739, 120);
      this.archiveInfoGroup.TabIndex = 0;
      this.archiveInfoGroup.TabStop = false;
      this.archiveInfoGroup.Text = "Archive Information";
      // 
      // archiveTable
      // 
      this.archiveTable.ColumnCount = 2;
      this.archiveTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.archiveTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
      this.archiveTable.Controls.Add(this.archiveName, 1, 0);
      this.archiveTable.Controls.Add(this.archiveDesc, 1, 1);
      this.archiveTable.Controls.Add(this.updateURL, 1, 2);
      this.archiveTable.Controls.Add(this.archiveNameLabel, 0, 0);
      this.archiveTable.Controls.Add(this.archiveDescLabel, 0, 1);
      this.archiveTable.Controls.Add(this.archiveURLLabel, 0, 2);
      this.archiveTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.archiveTable.Location = new System.Drawing.Point(3, 16);
      this.archiveTable.Name = "archiveTable";
      this.archiveTable.RowCount = 3;
      this.archiveTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.archiveTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.archiveTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.archiveTable.Size = new System.Drawing.Size(733, 101);
      this.archiveTable.TabIndex = 0;
      // 
      // archiveName
      // 
      this.archiveName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.archiveName.Location = new System.Drawing.Point(186, 3);
      this.archiveName.Name = "archiveName";
      this.archiveName.Size = new System.Drawing.Size(544, 20);
      this.archiveName.TabIndex = 0;
      this.archiveName.TextChanged += new System.EventHandler(this.SetArchiveName);
      // 
      // archiveDesc
      // 
      this.archiveDesc.Dock = System.Windows.Forms.DockStyle.Fill;
      this.archiveDesc.Location = new System.Drawing.Point(186, 28);
      this.archiveDesc.Multiline = true;
      this.archiveDesc.Name = "archiveDesc";
      this.archiveDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.archiveDesc.Size = new System.Drawing.Size(544, 44);
      this.archiveDesc.TabIndex = 1;
      this.archiveDesc.TextChanged += new System.EventHandler(this.SetArchiveDesc);
      // 
      // updateURL
      // 
      this.updateURL.Dock = System.Windows.Forms.DockStyle.Fill;
      this.updateURL.Location = new System.Drawing.Point(186, 78);
      this.updateURL.Name = "updateURL";
      this.updateURL.Size = new System.Drawing.Size(544, 20);
      this.updateURL.TabIndex = 2;
      this.updateURL.TextChanged += new System.EventHandler(this.SetArchiveURL);
      // 
      // archiveNameLabel
      // 
      this.archiveNameLabel.AutoSize = true;
      this.archiveNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.archiveNameLabel.Location = new System.Drawing.Point(3, 0);
      this.archiveNameLabel.Name = "archiveNameLabel";
      this.archiveNameLabel.Size = new System.Drawing.Size(177, 25);
      this.archiveNameLabel.TabIndex = 3;
      this.archiveNameLabel.Text = "Archive Name:";
      this.archiveNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // archiveDescLabel
      // 
      this.archiveDescLabel.AutoSize = true;
      this.archiveDescLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.archiveDescLabel.Location = new System.Drawing.Point(3, 25);
      this.archiveDescLabel.Name = "archiveDescLabel";
      this.archiveDescLabel.Size = new System.Drawing.Size(177, 50);
      this.archiveDescLabel.TabIndex = 4;
      this.archiveDescLabel.Text = "Archive Description:";
      this.archiveDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // archiveURLLabel
      // 
      this.archiveURLLabel.AutoSize = true;
      this.archiveURLLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.archiveURLLabel.Location = new System.Drawing.Point(3, 75);
      this.archiveURLLabel.Name = "archiveURLLabel";
      this.archiveURLLabel.Size = new System.Drawing.Size(177, 26);
      this.archiveURLLabel.TabIndex = 5;
      this.archiveURLLabel.Text = "Update URL:";
      this.archiveURLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // questionsTab
      // 
      this.questionsTab.Location = new System.Drawing.Point(4, 22);
      this.questionsTab.Name = "questionsTab";
      this.questionsTab.Padding = new System.Windows.Forms.Padding(3);
      this.questionsTab.Size = new System.Drawing.Size(751, 513);
      this.questionsTab.TabIndex = 1;
      this.questionsTab.Text = "Questions";
      this.questionsTab.UseVisualStyleBackColor = true;
      // 
      // teamsTab
      // 
      this.teamsTab.Location = new System.Drawing.Point(4, 22);
      this.teamsTab.Name = "teamsTab";
      this.teamsTab.Padding = new System.Windows.Forms.Padding(3);
      this.teamsTab.Size = new System.Drawing.Size(751, 513);
      this.teamsTab.TabIndex = 2;
      this.teamsTab.Text = "Teams";
      this.teamsTab.UseVisualStyleBackColor = true;
      // 
      // mainMenu
      // 
      this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivesToolStripMenuItem});
      this.mainMenu.Location = new System.Drawing.Point(0, 0);
      this.mainMenu.Name = "mainMenu";
      this.mainMenu.Size = new System.Drawing.Size(759, 24);
      this.mainMenu.TabIndex = 1;
      this.mainMenu.Text = "mainMenu";
      // 
      // archivesToolStripMenuItem
      // 
      this.archivesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
      this.archivesToolStripMenuItem.Name = "archivesToolStripMenuItem";
      this.archivesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
      this.archivesToolStripMenuItem.Text = "Archive";
      // 
      // loadToolStripMenuItem
      // 
      this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
      this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
      this.loadToolStripMenuItem.Text = "Load";
      this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadArchive);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
      this.saveToolStripMenuItem.Text = "Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveArchive);
      // 
      // colorDialog
      // 
      this.colorDialog.AnyColor = true;
      // 
      // openImage
      // 
      this.openImage.FileName = "openFileDialog1";
      this.openImage.Filter = "Image Files (*.bmp, *.jpg, *.jpeg)|*.bmp;*.jpg;*.jpeg";
      // 
      // openSound
      // 
      this.openSound.FileName = "openFileDialog1";
      this.openSound.Filter = "Sound Files (*.wav)|*.wav";
      // 
      // fontDialog
      // 
      this.fontDialog.FontMustExist = true;
      // 
      // openArchive
      // 
      this.openArchive.FileName = "openFileDialog";
      this.openArchive.Filter = "School Game Content Archive (*.sgca)|*.sgca";
      // 
      // saveArchiveDialog
      // 
      this.saveArchiveDialog.DefaultExt = "sgca";
      // 
      // MainScreen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(759, 563);
      this.Controls.Add(this.tabControl);
      this.Controls.Add(this.mainMenu);
      this.MainMenuStrip = this.mainMenu;
      this.Name = "MainScreen";
      this.Text = "School Game Content Creator";
      this.tabControl.ResumeLayout(false);
      this.generalTab.ResumeLayout(false);
      this.generalTable.ResumeLayout(false);
      this.timeInfoGroup.ResumeLayout(false);
      this.timeTable.ResumeLayout(false);
      this.timeTable.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.beforeAnswer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.afterAnswer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.delayScore)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.delayGO)).EndInit();
      this.soundInfoGroup.ResumeLayout(false);
      this.soundTable.ResumeLayout(false);
      this.soundTable.PerformLayout();
      this.generalInfoGroup.ResumeLayout(false);
      this.generalSTable.ResumeLayout(false);
      this.generalSTable.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bkgImage)).EndInit();
      this.archiveInfoGroup.ResumeLayout(false);
      this.archiveTable.ResumeLayout(false);
      this.archiveTable.PerformLayout();
      this.mainMenu.ResumeLayout(false);
      this.mainMenu.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage generalTab;
    private System.Windows.Forms.TabPage questionsTab;
    private System.Windows.Forms.MenuStrip mainMenu;
    private System.Windows.Forms.ToolStripMenuItem archivesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.TableLayoutPanel generalTable;
    private System.Windows.Forms.GroupBox timeInfoGroup;
    private System.Windows.Forms.GroupBox soundInfoGroup;
    private System.Windows.Forms.GroupBox generalInfoGroup;
    private System.Windows.Forms.GroupBox archiveInfoGroup;
    private System.Windows.Forms.TableLayoutPanel archiveTable;
    private System.Windows.Forms.TextBox archiveName;
    private System.Windows.Forms.TextBox archiveDesc;
    private System.Windows.Forms.TextBox updateURL;
    private System.Windows.Forms.Label archiveNameLabel;
    private System.Windows.Forms.Label archiveDescLabel;
    private System.Windows.Forms.Label archiveURLLabel;
    private System.Windows.Forms.TabPage teamsTab;
    private System.Windows.Forms.TableLayoutPanel generalSTable;
    private System.Windows.Forms.Label bkgColorLabel;
    private System.Windows.Forms.Label bkgImageLabel;
    private System.Windows.Forms.PictureBox bkgImage;
    private System.Windows.Forms.TextBox bkgColor;
    private System.Windows.Forms.ColorDialog colorDialog;
    private System.Windows.Forms.OpenFileDialog openImage;
    private System.Windows.Forms.TableLayoutPanel soundTable;
    private System.Windows.Forms.Label bkgSoundLabel;
    private System.Windows.Forms.Label correctSoundLabel;
    private System.Windows.Forms.Label wrongSoundLabel;
    private System.Windows.Forms.TextBox bkgSound;
    private System.Windows.Forms.TextBox correctSound;
    private System.Windows.Forms.TextBox wrongSound;
    private System.Windows.Forms.OpenFileDialog openSound;
    private System.Windows.Forms.FontDialog fontDialog;
    private System.Windows.Forms.TableLayoutPanel timeTable;
    private System.Windows.Forms.Label timerFontLabel;
    private System.Windows.Forms.Label timerColorLabel;
    private System.Windows.Forms.Label beforeAnswerLabel;
    private System.Windows.Forms.Label afterAnswerLabel;
    private System.Windows.Forms.Label delayScoreLabel;
    private System.Windows.Forms.Label delayGOLabel;
    private System.Windows.Forms.TextBox timerFont;
    private System.Windows.Forms.TextBox timerColor;
    private System.Windows.Forms.NumericUpDown beforeAnswer;
    private System.Windows.Forms.NumericUpDown afterAnswer;
    private System.Windows.Forms.NumericUpDown delayScore;
    private System.Windows.Forms.NumericUpDown delayGO;
    private System.Windows.Forms.OpenFileDialog openArchive;
    private System.Windows.Forms.SaveFileDialog saveArchiveDialog;
  }
}