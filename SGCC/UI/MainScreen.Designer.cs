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
      this.winning = new System.Windows.Forms.TextBox();
      this.losing = new System.Windows.Forms.TextBox();
      this.tying = new System.Windows.Forms.TextBox();
      this.won = new System.Windows.Forms.TextBox();
      this.lost = new System.Windows.Forms.TextBox();
      this.tied = new System.Windows.Forms.TextBox();
      this.winingLabel = new System.Windows.Forms.Label();
      this.losingLabel = new System.Windows.Forms.Label();
      this.tyingLabel = new System.Windows.Forms.Label();
      this.wonLabel = new System.Windows.Forms.Label();
      this.lostLabel = new System.Windows.Forms.Label();
      this.tiedLabel = new System.Windows.Forms.Label();
      this.archiveInfoGroup = new System.Windows.Forms.GroupBox();
      this.archiveTable = new System.Windows.Forms.TableLayoutPanel();
      this.archiveName = new System.Windows.Forms.TextBox();
      this.archiveNameLabel = new System.Windows.Forms.Label();
      this.archiveDescLabel = new System.Windows.Forms.Label();
      this.archiveDesc = new System.Windows.Forms.TextBox();
      this.archiveURLLabel = new System.Windows.Forms.Label();
      this.updateURL = new System.Windows.Forms.TextBox();
      this.versionLabel = new System.Windows.Forms.Label();
      this.version = new System.Windows.Forms.TextBox();
      this.author = new System.Windows.Forms.TextBox();
      this.license = new System.Windows.Forms.TextBox();
      this.authorLabel = new System.Windows.Forms.Label();
      this.licenseLabel = new System.Windows.Forms.Label();
      this.questionsTab = new System.Windows.Forms.TabPage();
      this.splitContainer = new System.Windows.Forms.SplitContainer();
      this.nodeTable = new System.Windows.Forms.TableLayoutPanel();
      this.nodeEditTable = new System.Windows.Forms.TableLayoutPanel();
      this.addTopic = new System.Windows.Forms.Button();
      this.addQuestion = new System.Windows.Forms.Button();
      this.removeCurrentTopic = new System.Windows.Forms.Button();
      this.removeCurrentQuestion = new System.Windows.Forms.Button();
      this.topicsTree = new SchoolGame.SGCC.UI.Controls.TreeLE();
      this.panel2Table = new System.Windows.Forms.TableLayoutPanel();
      this.questionInfoGroup = new System.Windows.Forms.GroupBox();
      this.panel2SubTable = new System.Windows.Forms.TableLayoutPanel();
      this.questionLabel = new System.Windows.Forms.Label();
      this.pointsLabel = new System.Windows.Forms.Label();
      this.imageLabel = new System.Windows.Forms.Label();
      this.image = new System.Windows.Forms.PictureBox();
      this.question = new System.Windows.Forms.TextBox();
      this.points = new System.Windows.Forms.NumericUpDown();
      this.answersGroup = new System.Windows.Forms.GroupBox();
      this.answerTable = new System.Windows.Forms.TableLayoutPanel();
      this.addAnswer = new System.Windows.Forms.Button();
      this.answersTable = new System.Windows.Forms.TableLayoutPanel();
      this.teamsTab = new System.Windows.Forms.TabPage();
      this.teamTable = new System.Windows.Forms.TableLayoutPanel();
      this.addTeam = new System.Windows.Forms.Button();
      this.teamsTable = new System.Windows.Forms.TableLayoutPanel();
      this.mainMenu = new System.Windows.Forms.MenuStrip();
      this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
      this.questionsTab.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
      this.splitContainer.Panel1.SuspendLayout();
      this.splitContainer.Panel2.SuspendLayout();
      this.splitContainer.SuspendLayout();
      this.nodeTable.SuspendLayout();
      this.nodeEditTable.SuspendLayout();
      this.panel2Table.SuspendLayout();
      this.questionInfoGroup.SuspendLayout();
      this.panel2SubTable.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.points)).BeginInit();
      this.answersGroup.SuspendLayout();
      this.answerTable.SuspendLayout();
      this.teamsTab.SuspendLayout();
      this.teamTable.SuspendLayout();
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
      this.tabControl.Size = new System.Drawing.Size(784, 537);
      this.tabControl.TabIndex = 0;
      // 
      // generalTab
      // 
      this.generalTab.Controls.Add(this.generalTable);
      this.generalTab.Location = new System.Drawing.Point(4, 22);
      this.generalTab.Margin = new System.Windows.Forms.Padding(0);
      this.generalTab.Name = "generalTab";
      this.generalTab.Padding = new System.Windows.Forms.Padding(3);
      this.generalTab.Size = new System.Drawing.Size(776, 511);
      this.generalTab.TabIndex = 0;
      this.generalTab.Text = "General Information";
      this.generalTab.UseVisualStyleBackColor = true;
      // 
      // generalTable
      // 
      this.generalTable.AutoScroll = true;
      this.generalTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.generalTable.ColumnCount = 1;
      this.generalTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.generalTable.Controls.Add(this.timeInfoGroup, 0, 3);
      this.generalTable.Controls.Add(this.soundInfoGroup, 0, 2);
      this.generalTable.Controls.Add(this.generalInfoGroup, 0, 1);
      this.generalTable.Controls.Add(this.archiveInfoGroup, 0, 0);
      this.generalTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.generalTable.Location = new System.Drawing.Point(3, 3);
      this.generalTable.Name = "generalTable";
      this.generalTable.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
      this.generalTable.RowCount = 4;
      this.generalTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.generalTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.generalTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.generalTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.generalTable.Size = new System.Drawing.Size(770, 505);
      this.generalTable.TabIndex = 0;
      // 
      // timeInfoGroup
      // 
      this.timeInfoGroup.AutoSize = true;
      this.timeInfoGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.timeInfoGroup.BackColor = System.Drawing.Color.Transparent;
      this.timeInfoGroup.Controls.Add(this.timeTable);
      this.timeInfoGroup.Dock = System.Windows.Forms.DockStyle.Fill;
      this.timeInfoGroup.Location = new System.Drawing.Point(3, 892);
      this.timeInfoGroup.Name = "timeInfoGroup";
      this.timeInfoGroup.Size = new System.Drawing.Size(746, 175);
      this.timeInfoGroup.TabIndex = 3;
      this.timeInfoGroup.TabStop = false;
      this.timeInfoGroup.Text = "Time Settings";
      // 
      // timeTable
      // 
      this.timeTable.AutoSize = true;
      this.timeTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
      this.timeTable.Margin = new System.Windows.Forms.Padding(0);
      this.timeTable.Name = "timeTable";
      this.timeTable.RowCount = 6;
      this.timeTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.timeTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.timeTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.timeTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.timeTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.timeTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.timeTable.Size = new System.Drawing.Size(740, 156);
      this.timeTable.TabIndex = 0;
      // 
      // timerFontLabel
      // 
      this.timerFontLabel.AutoSize = true;
      this.timerFontLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.timerFontLabel.Location = new System.Drawing.Point(3, 0);
      this.timerFontLabel.Name = "timerFontLabel";
      this.timerFontLabel.Size = new System.Drawing.Size(179, 26);
      this.timerFontLabel.TabIndex = 0;
      this.timerFontLabel.Text = "Timer Font:";
      this.timerFontLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // timerColorLabel
      // 
      this.timerColorLabel.AutoSize = true;
      this.timerColorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.timerColorLabel.Location = new System.Drawing.Point(3, 26);
      this.timerColorLabel.Name = "timerColorLabel";
      this.timerColorLabel.Size = new System.Drawing.Size(179, 26);
      this.timerColorLabel.TabIndex = 1;
      this.timerColorLabel.Text = "Timer Color:";
      this.timerColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // beforeAnswerLabel
      // 
      this.beforeAnswerLabel.AutoSize = true;
      this.beforeAnswerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.beforeAnswerLabel.Location = new System.Drawing.Point(3, 52);
      this.beforeAnswerLabel.Name = "beforeAnswerLabel";
      this.beforeAnswerLabel.Size = new System.Drawing.Size(179, 26);
      this.beforeAnswerLabel.TabIndex = 2;
      this.beforeAnswerLabel.Text = "Time before question answer:";
      this.beforeAnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // afterAnswerLabel
      // 
      this.afterAnswerLabel.AutoSize = true;
      this.afterAnswerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.afterAnswerLabel.Location = new System.Drawing.Point(3, 78);
      this.afterAnswerLabel.Name = "afterAnswerLabel";
      this.afterAnswerLabel.Size = new System.Drawing.Size(179, 26);
      this.afterAnswerLabel.TabIndex = 3;
      this.afterAnswerLabel.Text = "Delay after Answer:";
      this.afterAnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // delayScoreLabel
      // 
      this.delayScoreLabel.AutoSize = true;
      this.delayScoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.delayScoreLabel.Location = new System.Drawing.Point(3, 104);
      this.delayScoreLabel.Name = "delayScoreLabel";
      this.delayScoreLabel.Size = new System.Drawing.Size(179, 26);
      this.delayScoreLabel.TabIndex = 4;
      this.delayScoreLabel.Text = "Delay to see the Score:";
      this.delayScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // delayGOLabel
      // 
      this.delayGOLabel.AutoSize = true;
      this.delayGOLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.delayGOLabel.Location = new System.Drawing.Point(3, 130);
      this.delayGOLabel.Name = "delayGOLabel";
      this.delayGOLabel.Size = new System.Drawing.Size(179, 26);
      this.delayGOLabel.TabIndex = 5;
      this.delayGOLabel.Text = "Delay after Game Over:";
      this.delayGOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // timerFont
      // 
      this.timerFont.Dock = System.Windows.Forms.DockStyle.Fill;
      this.timerFont.Location = new System.Drawing.Point(188, 3);
      this.timerFont.Name = "timerFont";
      this.timerFont.Size = new System.Drawing.Size(549, 20);
      this.timerFont.TabIndex = 6;
      this.timerFont.Click += new System.EventHandler(this.SelectTimerFont);
      // 
      // timerColor
      // 
      this.timerColor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.timerColor.Location = new System.Drawing.Point(188, 29);
      this.timerColor.Name = "timerColor";
      this.timerColor.Size = new System.Drawing.Size(549, 20);
      this.timerColor.TabIndex = 7;
      this.timerColor.Click += new System.EventHandler(this.SelectTimerColor);
      // 
      // beforeAnswer
      // 
      this.beforeAnswer.DecimalPlaces = 4;
      this.beforeAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.beforeAnswer.Location = new System.Drawing.Point(188, 55);
      this.beforeAnswer.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
      this.beforeAnswer.Name = "beforeAnswer";
      this.beforeAnswer.Size = new System.Drawing.Size(549, 20);
      this.beforeAnswer.TabIndex = 8;
      this.beforeAnswer.ValueChanged += new System.EventHandler(this.SetBeforeQuestion);
      // 
      // afterAnswer
      // 
      this.afterAnswer.DecimalPlaces = 4;
      this.afterAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.afterAnswer.Location = new System.Drawing.Point(188, 81);
      this.afterAnswer.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
      this.afterAnswer.Name = "afterAnswer";
      this.afterAnswer.Size = new System.Drawing.Size(549, 20);
      this.afterAnswer.TabIndex = 9;
      this.afterAnswer.ValueChanged += new System.EventHandler(this.SetAfterQuestion);
      // 
      // delayScore
      // 
      this.delayScore.DecimalPlaces = 4;
      this.delayScore.Dock = System.Windows.Forms.DockStyle.Fill;
      this.delayScore.Location = new System.Drawing.Point(188, 107);
      this.delayScore.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
      this.delayScore.Name = "delayScore";
      this.delayScore.Size = new System.Drawing.Size(549, 20);
      this.delayScore.TabIndex = 10;
      this.delayScore.ValueChanged += new System.EventHandler(this.SetScoreDelay);
      // 
      // delayGO
      // 
      this.delayGO.DecimalPlaces = 4;
      this.delayGO.Dock = System.Windows.Forms.DockStyle.Fill;
      this.delayGO.Location = new System.Drawing.Point(188, 133);
      this.delayGO.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
      this.delayGO.Name = "delayGO";
      this.delayGO.Size = new System.Drawing.Size(549, 20);
      this.delayGO.TabIndex = 11;
      this.delayGO.ValueChanged += new System.EventHandler(this.SetGODelay);
      // 
      // soundInfoGroup
      // 
      this.soundInfoGroup.AutoSize = true;
      this.soundInfoGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.soundInfoGroup.Controls.Add(this.soundTable);
      this.soundInfoGroup.Dock = System.Windows.Forms.DockStyle.Fill;
      this.soundInfoGroup.Location = new System.Drawing.Point(3, 789);
      this.soundInfoGroup.Name = "soundInfoGroup";
      this.soundInfoGroup.Size = new System.Drawing.Size(746, 97);
      this.soundInfoGroup.TabIndex = 2;
      this.soundInfoGroup.TabStop = false;
      this.soundInfoGroup.Text = "Sound Settings";
      // 
      // soundTable
      // 
      this.soundTable.AutoSize = true;
      this.soundTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
      this.soundTable.Margin = new System.Windows.Forms.Padding(0);
      this.soundTable.Name = "soundTable";
      this.soundTable.RowCount = 3;
      this.soundTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.soundTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.soundTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.soundTable.Size = new System.Drawing.Size(740, 78);
      this.soundTable.TabIndex = 0;
      // 
      // bkgSoundLabel
      // 
      this.bkgSoundLabel.AutoSize = true;
      this.bkgSoundLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bkgSoundLabel.Location = new System.Drawing.Point(3, 0);
      this.bkgSoundLabel.Name = "bkgSoundLabel";
      this.bkgSoundLabel.Size = new System.Drawing.Size(179, 26);
      this.bkgSoundLabel.TabIndex = 0;
      this.bkgSoundLabel.Text = "Background Music:";
      this.bkgSoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // correctSoundLabel
      // 
      this.correctSoundLabel.AutoSize = true;
      this.correctSoundLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.correctSoundLabel.Location = new System.Drawing.Point(3, 26);
      this.correctSoundLabel.Name = "correctSoundLabel";
      this.correctSoundLabel.Size = new System.Drawing.Size(179, 26);
      this.correctSoundLabel.TabIndex = 1;
      this.correctSoundLabel.Text = "Correct Sound:";
      this.correctSoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // wrongSoundLabel
      // 
      this.wrongSoundLabel.AutoSize = true;
      this.wrongSoundLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.wrongSoundLabel.Location = new System.Drawing.Point(3, 52);
      this.wrongSoundLabel.Name = "wrongSoundLabel";
      this.wrongSoundLabel.Size = new System.Drawing.Size(179, 26);
      this.wrongSoundLabel.TabIndex = 2;
      this.wrongSoundLabel.Text = "Wrong Sound:";
      this.wrongSoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // bkgSound
      // 
      this.bkgSound.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bkgSound.Location = new System.Drawing.Point(188, 3);
      this.bkgSound.Name = "bkgSound";
      this.bkgSound.Size = new System.Drawing.Size(549, 20);
      this.bkgSound.TabIndex = 3;
      this.bkgSound.Click += new System.EventHandler(this.SelectBkgSound);
      // 
      // correctSound
      // 
      this.correctSound.Dock = System.Windows.Forms.DockStyle.Fill;
      this.correctSound.Location = new System.Drawing.Point(188, 29);
      this.correctSound.Name = "correctSound";
      this.correctSound.Size = new System.Drawing.Size(549, 20);
      this.correctSound.TabIndex = 4;
      this.correctSound.Click += new System.EventHandler(this.SelectCorrectSound);
      // 
      // wrongSound
      // 
      this.wrongSound.Dock = System.Windows.Forms.DockStyle.Fill;
      this.wrongSound.Location = new System.Drawing.Point(188, 55);
      this.wrongSound.Name = "wrongSound";
      this.wrongSound.Size = new System.Drawing.Size(549, 20);
      this.wrongSound.TabIndex = 5;
      this.wrongSound.Click += new System.EventHandler(this.SelectWrongSound);
      // 
      // generalInfoGroup
      // 
      this.generalInfoGroup.AutoSize = true;
      this.generalInfoGroup.Controls.Add(this.generalSTable);
      this.generalInfoGroup.Dock = System.Windows.Forms.DockStyle.Fill;
      this.generalInfoGroup.Location = new System.Drawing.Point(1, 282);
      this.generalInfoGroup.Margin = new System.Windows.Forms.Padding(1);
      this.generalInfoGroup.Name = "generalInfoGroup";
      this.generalInfoGroup.Size = new System.Drawing.Size(750, 503);
      this.generalInfoGroup.TabIndex = 1;
      this.generalInfoGroup.TabStop = false;
      this.generalInfoGroup.Text = "General Settings";
      // 
      // generalSTable
      // 
      this.generalSTable.AutoSize = true;
      this.generalSTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.generalSTable.ColumnCount = 2;
      this.generalSTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.generalSTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
      this.generalSTable.Controls.Add(this.bkgColorLabel, 0, 6);
      this.generalSTable.Controls.Add(this.bkgImageLabel, 0, 7);
      this.generalSTable.Controls.Add(this.bkgImage, 1, 7);
      this.generalSTable.Controls.Add(this.bkgColor, 1, 6);
      this.generalSTable.Controls.Add(this.winning, 1, 0);
      this.generalSTable.Controls.Add(this.losing, 1, 1);
      this.generalSTable.Controls.Add(this.tying, 1, 2);
      this.generalSTable.Controls.Add(this.won, 1, 3);
      this.generalSTable.Controls.Add(this.lost, 1, 4);
      this.generalSTable.Controls.Add(this.tied, 1, 5);
      this.generalSTable.Controls.Add(this.winingLabel, 0, 0);
      this.generalSTable.Controls.Add(this.losingLabel, 0, 1);
      this.generalSTable.Controls.Add(this.tyingLabel, 0, 2);
      this.generalSTable.Controls.Add(this.wonLabel, 0, 3);
      this.generalSTable.Controls.Add(this.lostLabel, 0, 4);
      this.generalSTable.Controls.Add(this.tiedLabel, 0, 5);
      this.generalSTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.generalSTable.Location = new System.Drawing.Point(3, 16);
      this.generalSTable.Margin = new System.Windows.Forms.Padding(0);
      this.generalSTable.Name = "generalSTable";
      this.generalSTable.RowCount = 8;
      this.generalSTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.generalSTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.generalSTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.generalSTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.generalSTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.generalSTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.generalSTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.generalSTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.generalSTable.Size = new System.Drawing.Size(744, 484);
      this.generalSTable.TabIndex = 0;
      // 
      // bkgColorLabel
      // 
      this.bkgColorLabel.AutoSize = true;
      this.bkgColorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bkgColorLabel.Location = new System.Drawing.Point(3, 156);
      this.bkgColorLabel.Name = "bkgColorLabel";
      this.bkgColorLabel.Size = new System.Drawing.Size(180, 26);
      this.bkgColorLabel.TabIndex = 0;
      this.bkgColorLabel.Text = "Background Color:";
      this.bkgColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // bkgImageLabel
      // 
      this.bkgImageLabel.AutoSize = true;
      this.bkgImageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bkgImageLabel.Location = new System.Drawing.Point(3, 182);
      this.bkgImageLabel.Name = "bkgImageLabel";
      this.bkgImageLabel.Size = new System.Drawing.Size(180, 302);
      this.bkgImageLabel.TabIndex = 1;
      this.bkgImageLabel.Text = "Background Image:";
      this.bkgImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // bkgImage
      // 
      this.bkgImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.bkgImage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bkgImage.Location = new System.Drawing.Point(189, 185);
      this.bkgImage.Name = "bkgImage";
      this.bkgImage.Size = new System.Drawing.Size(552, 296);
      this.bkgImage.TabIndex = 2;
      this.bkgImage.TabStop = false;
      this.bkgImage.Click += new System.EventHandler(this.SelectBkgImage);
      // 
      // bkgColor
      // 
      this.bkgColor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bkgColor.Location = new System.Drawing.Point(189, 159);
      this.bkgColor.Name = "bkgColor";
      this.bkgColor.Size = new System.Drawing.Size(552, 20);
      this.bkgColor.TabIndex = 3;
      this.bkgColor.Click += new System.EventHandler(this.SelectBkgColor);
      // 
      // winning
      // 
      this.winning.Dock = System.Windows.Forms.DockStyle.Fill;
      this.winning.Location = new System.Drawing.Point(189, 3);
      this.winning.Name = "winning";
      this.winning.Size = new System.Drawing.Size(552, 20);
      this.winning.TabIndex = 4;
      this.winning.TextChanged += new System.EventHandler(this.SetWinning);
      // 
      // losing
      // 
      this.losing.Dock = System.Windows.Forms.DockStyle.Fill;
      this.losing.Location = new System.Drawing.Point(189, 29);
      this.losing.Name = "losing";
      this.losing.Size = new System.Drawing.Size(552, 20);
      this.losing.TabIndex = 5;
      this.losing.TextChanged += new System.EventHandler(this.SetLosing);
      // 
      // tying
      // 
      this.tying.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tying.Location = new System.Drawing.Point(189, 55);
      this.tying.Name = "tying";
      this.tying.Size = new System.Drawing.Size(552, 20);
      this.tying.TabIndex = 6;
      this.tying.TextChanged += new System.EventHandler(this.SetTying);
      // 
      // won
      // 
      this.won.Dock = System.Windows.Forms.DockStyle.Fill;
      this.won.Location = new System.Drawing.Point(189, 81);
      this.won.Name = "won";
      this.won.Size = new System.Drawing.Size(552, 20);
      this.won.TabIndex = 7;
      this.won.TextChanged += new System.EventHandler(this.SetWon);
      // 
      // lost
      // 
      this.lost.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lost.Location = new System.Drawing.Point(189, 107);
      this.lost.Name = "lost";
      this.lost.Size = new System.Drawing.Size(552, 20);
      this.lost.TabIndex = 8;
      this.lost.TextChanged += new System.EventHandler(this.SetLost);
      // 
      // tied
      // 
      this.tied.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tied.Location = new System.Drawing.Point(189, 133);
      this.tied.Name = "tied";
      this.tied.Size = new System.Drawing.Size(552, 20);
      this.tied.TabIndex = 9;
      this.tied.TextChanged += new System.EventHandler(this.SetTied);
      // 
      // winingLabel
      // 
      this.winingLabel.AutoSize = true;
      this.winingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.winingLabel.Location = new System.Drawing.Point(3, 0);
      this.winingLabel.Name = "winingLabel";
      this.winingLabel.Size = new System.Drawing.Size(180, 26);
      this.winingLabel.TabIndex = 10;
      this.winingLabel.Text = "Winning Message:";
      this.winingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // losingLabel
      // 
      this.losingLabel.AutoSize = true;
      this.losingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.losingLabel.Location = new System.Drawing.Point(3, 26);
      this.losingLabel.Name = "losingLabel";
      this.losingLabel.Size = new System.Drawing.Size(180, 26);
      this.losingLabel.TabIndex = 11;
      this.losingLabel.Text = "Losing Message:";
      this.losingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tyingLabel
      // 
      this.tyingLabel.AutoSize = true;
      this.tyingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tyingLabel.Location = new System.Drawing.Point(3, 52);
      this.tyingLabel.Name = "tyingLabel";
      this.tyingLabel.Size = new System.Drawing.Size(180, 26);
      this.tyingLabel.TabIndex = 12;
      this.tyingLabel.Text = "Tying Message:";
      this.tyingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // wonLabel
      // 
      this.wonLabel.AutoSize = true;
      this.wonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.wonLabel.Location = new System.Drawing.Point(3, 78);
      this.wonLabel.Name = "wonLabel";
      this.wonLabel.Size = new System.Drawing.Size(180, 26);
      this.wonLabel.TabIndex = 13;
      this.wonLabel.Text = "Won Message:";
      this.wonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lostLabel
      // 
      this.lostLabel.AutoSize = true;
      this.lostLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lostLabel.Location = new System.Drawing.Point(3, 104);
      this.lostLabel.Name = "lostLabel";
      this.lostLabel.Size = new System.Drawing.Size(180, 26);
      this.lostLabel.TabIndex = 14;
      this.lostLabel.Text = "Lost Message:";
      this.lostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tiedLabel
      // 
      this.tiedLabel.AutoSize = true;
      this.tiedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tiedLabel.Location = new System.Drawing.Point(3, 130);
      this.tiedLabel.Name = "tiedLabel";
      this.tiedLabel.Size = new System.Drawing.Size(180, 26);
      this.tiedLabel.TabIndex = 15;
      this.tiedLabel.Text = "Tied Message:";
      this.tiedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // archiveInfoGroup
      // 
      this.archiveInfoGroup.AutoSize = true;
      this.archiveInfoGroup.Controls.Add(this.archiveTable);
      this.archiveInfoGroup.Dock = System.Windows.Forms.DockStyle.Fill;
      this.archiveInfoGroup.Location = new System.Drawing.Point(1, 1);
      this.archiveInfoGroup.Margin = new System.Windows.Forms.Padding(1);
      this.archiveInfoGroup.Name = "archiveInfoGroup";
      this.archiveInfoGroup.Size = new System.Drawing.Size(750, 279);
      this.archiveInfoGroup.TabIndex = 0;
      this.archiveInfoGroup.TabStop = false;
      this.archiveInfoGroup.Text = "Archive Information";
      // 
      // archiveTable
      // 
      this.archiveTable.AutoSize = true;
      this.archiveTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.archiveTable.ColumnCount = 2;
      this.archiveTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
      this.archiveTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
      this.archiveTable.Controls.Add(this.archiveName, 1, 0);
      this.archiveTable.Controls.Add(this.archiveNameLabel, 0, 0);
      this.archiveTable.Controls.Add(this.archiveDescLabel, 0, 1);
      this.archiveTable.Controls.Add(this.archiveDesc, 1, 1);
      this.archiveTable.Controls.Add(this.archiveURLLabel, 0, 5);
      this.archiveTable.Controls.Add(this.updateURL, 1, 5);
      this.archiveTable.Controls.Add(this.versionLabel, 0, 2);
      this.archiveTable.Controls.Add(this.version, 1, 2);
      this.archiveTable.Controls.Add(this.author, 1, 3);
      this.archiveTable.Controls.Add(this.license, 1, 4);
      this.archiveTable.Controls.Add(this.authorLabel, 0, 3);
      this.archiveTable.Controls.Add(this.licenseLabel, 0, 4);
      this.archiveTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.archiveTable.Location = new System.Drawing.Point(3, 16);
      this.archiveTable.Margin = new System.Windows.Forms.Padding(0);
      this.archiveTable.Name = "archiveTable";
      this.archiveTable.RowCount = 6;
      this.archiveTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.archiveTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.archiveTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.archiveTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.archiveTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.archiveTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.archiveTable.Size = new System.Drawing.Size(744, 260);
      this.archiveTable.TabIndex = 0;
      // 
      // archiveName
      // 
      this.archiveName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.archiveName.Location = new System.Drawing.Point(114, 3);
      this.archiveName.Name = "archiveName";
      this.archiveName.Size = new System.Drawing.Size(627, 20);
      this.archiveName.TabIndex = 0;
      this.archiveName.TextChanged += new System.EventHandler(this.SetArchiveName);
      // 
      // archiveNameLabel
      // 
      this.archiveNameLabel.AutoSize = true;
      this.archiveNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.archiveNameLabel.Location = new System.Drawing.Point(3, 0);
      this.archiveNameLabel.Name = "archiveNameLabel";
      this.archiveNameLabel.Size = new System.Drawing.Size(105, 26);
      this.archiveNameLabel.TabIndex = 3;
      this.archiveNameLabel.Text = "Archive Name:";
      this.archiveNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // archiveDescLabel
      // 
      this.archiveDescLabel.AutoSize = true;
      this.archiveDescLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.archiveDescLabel.Location = new System.Drawing.Point(3, 26);
      this.archiveDescLabel.Name = "archiveDescLabel";
      this.archiveDescLabel.Size = new System.Drawing.Size(105, 130);
      this.archiveDescLabel.TabIndex = 4;
      this.archiveDescLabel.Text = "Archive Description:";
      // 
      // archiveDesc
      // 
      this.archiveDesc.Dock = System.Windows.Forms.DockStyle.Fill;
      this.archiveDesc.Location = new System.Drawing.Point(114, 29);
      this.archiveDesc.Multiline = true;
      this.archiveDesc.Name = "archiveDesc";
      this.archiveDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.archiveDesc.Size = new System.Drawing.Size(627, 124);
      this.archiveDesc.TabIndex = 1;
      this.archiveDesc.TextChanged += new System.EventHandler(this.SetArchiveDesc);
      // 
      // archiveURLLabel
      // 
      this.archiveURLLabel.AutoSize = true;
      this.archiveURLLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.archiveURLLabel.Location = new System.Drawing.Point(3, 234);
      this.archiveURLLabel.Name = "archiveURLLabel";
      this.archiveURLLabel.Size = new System.Drawing.Size(105, 26);
      this.archiveURLLabel.TabIndex = 5;
      this.archiveURLLabel.Text = "Update URL:";
      this.archiveURLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // updateURL
      // 
      this.updateURL.Dock = System.Windows.Forms.DockStyle.Fill;
      this.updateURL.Location = new System.Drawing.Point(114, 237);
      this.updateURL.Name = "updateURL";
      this.updateURL.Size = new System.Drawing.Size(627, 20);
      this.updateURL.TabIndex = 2;
      this.updateURL.TextChanged += new System.EventHandler(this.SetArchiveURL);
      // 
      // versionLabel
      // 
      this.versionLabel.AutoSize = true;
      this.versionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.versionLabel.Location = new System.Drawing.Point(3, 156);
      this.versionLabel.Name = "versionLabel";
      this.versionLabel.Size = new System.Drawing.Size(105, 26);
      this.versionLabel.TabIndex = 6;
      this.versionLabel.Text = "Version:";
      this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // version
      // 
      this.version.Dock = System.Windows.Forms.DockStyle.Fill;
      this.version.Location = new System.Drawing.Point(114, 159);
      this.version.Name = "version";
      this.version.Size = new System.Drawing.Size(627, 20);
      this.version.TabIndex = 7;
      this.version.TextChanged += new System.EventHandler(this.SetArchiveVersion);
      // 
      // author
      // 
      this.author.Dock = System.Windows.Forms.DockStyle.Fill;
      this.author.Location = new System.Drawing.Point(114, 185);
      this.author.Name = "author";
      this.author.Size = new System.Drawing.Size(627, 20);
      this.author.TabIndex = 8;
      this.author.TextChanged += new System.EventHandler(this.SetAuthor);
      // 
      // license
      // 
      this.license.Dock = System.Windows.Forms.DockStyle.Fill;
      this.license.Location = new System.Drawing.Point(114, 211);
      this.license.Name = "license";
      this.license.Size = new System.Drawing.Size(627, 20);
      this.license.TabIndex = 9;
      this.license.TextChanged += new System.EventHandler(this.SetLicense);
      // 
      // authorLabel
      // 
      this.authorLabel.AutoSize = true;
      this.authorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.authorLabel.Location = new System.Drawing.Point(3, 182);
      this.authorLabel.Name = "authorLabel";
      this.authorLabel.Size = new System.Drawing.Size(105, 26);
      this.authorLabel.TabIndex = 10;
      this.authorLabel.Text = "Author:";
      this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // licenseLabel
      // 
      this.licenseLabel.AutoSize = true;
      this.licenseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.licenseLabel.Location = new System.Drawing.Point(3, 208);
      this.licenseLabel.Name = "licenseLabel";
      this.licenseLabel.Size = new System.Drawing.Size(105, 26);
      this.licenseLabel.TabIndex = 11;
      this.licenseLabel.Text = "License:";
      this.licenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // questionsTab
      // 
      this.questionsTab.Controls.Add(this.splitContainer);
      this.questionsTab.Location = new System.Drawing.Point(4, 22);
      this.questionsTab.Margin = new System.Windows.Forms.Padding(0);
      this.questionsTab.Name = "questionsTab";
      this.questionsTab.Padding = new System.Windows.Forms.Padding(3);
      this.questionsTab.Size = new System.Drawing.Size(776, 511);
      this.questionsTab.TabIndex = 1;
      this.questionsTab.Text = "Questions";
      this.questionsTab.UseVisualStyleBackColor = true;
      // 
      // splitContainer
      // 
      this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer.Location = new System.Drawing.Point(3, 3);
      this.splitContainer.Margin = new System.Windows.Forms.Padding(0);
      this.splitContainer.Name = "splitContainer";
      // 
      // splitContainer.Panel1
      // 
      this.splitContainer.Panel1.Controls.Add(this.nodeTable);
      // 
      // splitContainer.Panel2
      // 
      this.splitContainer.Panel2.Controls.Add(this.panel2Table);
      this.splitContainer.Size = new System.Drawing.Size(770, 505);
      this.splitContainer.SplitterDistance = 272;
      this.splitContainer.TabIndex = 0;
      // 
      // nodeTable
      // 
      this.nodeTable.ColumnCount = 1;
      this.nodeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.nodeTable.Controls.Add(this.nodeEditTable, 0, 1);
      this.nodeTable.Controls.Add(this.topicsTree, 0, 0);
      this.nodeTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.nodeTable.Location = new System.Drawing.Point(0, 0);
      this.nodeTable.Margin = new System.Windows.Forms.Padding(0);
      this.nodeTable.Name = "nodeTable";
      this.nodeTable.RowCount = 2;
      this.nodeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
      this.nodeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.nodeTable.Size = new System.Drawing.Size(272, 505);
      this.nodeTable.TabIndex = 0;
      // 
      // nodeEditTable
      // 
      this.nodeEditTable.ColumnCount = 2;
      this.nodeEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.83099F));
      this.nodeEditTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.16901F));
      this.nodeEditTable.Controls.Add(this.addTopic, 0, 0);
      this.nodeEditTable.Controls.Add(this.addQuestion, 0, 1);
      this.nodeEditTable.Controls.Add(this.removeCurrentTopic, 1, 0);
      this.nodeEditTable.Controls.Add(this.removeCurrentQuestion, 1, 1);
      this.nodeEditTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.nodeEditTable.Location = new System.Drawing.Point(0, 454);
      this.nodeEditTable.Margin = new System.Windows.Forms.Padding(0);
      this.nodeEditTable.Name = "nodeEditTable";
      this.nodeEditTable.RowCount = 2;
      this.nodeEditTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.nodeEditTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.nodeEditTable.Size = new System.Drawing.Size(272, 51);
      this.nodeEditTable.TabIndex = 0;
      // 
      // addTopic
      // 
      this.addTopic.Dock = System.Windows.Forms.DockStyle.Fill;
      this.addTopic.Location = new System.Drawing.Point(0, 0);
      this.addTopic.Margin = new System.Windows.Forms.Padding(0);
      this.addTopic.Name = "addTopic";
      this.addTopic.Size = new System.Drawing.Size(127, 25);
      this.addTopic.TabIndex = 0;
      this.addTopic.Text = "Add Topic";
      this.addTopic.UseVisualStyleBackColor = true;
      this.addTopic.Click += new System.EventHandler(this.AddTopic);
      // 
      // addQuestion
      // 
      this.addQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
      this.addQuestion.Location = new System.Drawing.Point(0, 25);
      this.addQuestion.Margin = new System.Windows.Forms.Padding(0);
      this.addQuestion.Name = "addQuestion";
      this.addQuestion.Size = new System.Drawing.Size(127, 26);
      this.addQuestion.TabIndex = 1;
      this.addQuestion.Text = "Add Question";
      this.addQuestion.UseVisualStyleBackColor = true;
      this.addQuestion.Click += new System.EventHandler(this.AddQuestion);
      // 
      // removeCurrentTopic
      // 
      this.removeCurrentTopic.Dock = System.Windows.Forms.DockStyle.Fill;
      this.removeCurrentTopic.Location = new System.Drawing.Point(127, 0);
      this.removeCurrentTopic.Margin = new System.Windows.Forms.Padding(0);
      this.removeCurrentTopic.Name = "removeCurrentTopic";
      this.removeCurrentTopic.Size = new System.Drawing.Size(145, 25);
      this.removeCurrentTopic.TabIndex = 2;
      this.removeCurrentTopic.Text = "Remove Current Topic";
      this.removeCurrentTopic.UseVisualStyleBackColor = true;
      this.removeCurrentTopic.Click += new System.EventHandler(this.RemoveTopic);
      // 
      // removeCurrentQuestion
      // 
      this.removeCurrentQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
      this.removeCurrentQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
      this.removeCurrentQuestion.Location = new System.Drawing.Point(127, 25);
      this.removeCurrentQuestion.Margin = new System.Windows.Forms.Padding(0);
      this.removeCurrentQuestion.Name = "removeCurrentQuestion";
      this.removeCurrentQuestion.Size = new System.Drawing.Size(145, 26);
      this.removeCurrentQuestion.TabIndex = 3;
      this.removeCurrentQuestion.Text = "Remove Current Question";
      this.removeCurrentQuestion.UseVisualStyleBackColor = true;
      this.removeCurrentQuestion.Click += new System.EventHandler(this.RemoveQuestion);
      // 
      // topicsTree
      // 
      this.topicsTree.Dock = System.Windows.Forms.DockStyle.Fill;
      this.topicsTree.HideSelection = false;
      this.topicsTree.Location = new System.Drawing.Point(3, 3);
      this.topicsTree.Name = "topicsTree";
      this.topicsTree.Size = new System.Drawing.Size(266, 448);
      this.topicsTree.TabIndex = 1;
      this.topicsTree.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.BeforeNodeNameChange);
      this.topicsTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.AfterNodeNameChange);
      this.topicsTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.NodeClicked);
      // 
      // panel2Table
      // 
      this.panel2Table.ColumnCount = 1;
      this.panel2Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.panel2Table.Controls.Add(this.questionInfoGroup, 0, 0);
      this.panel2Table.Controls.Add(this.answersGroup, 0, 1);
      this.panel2Table.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2Table.Location = new System.Drawing.Point(0, 0);
      this.panel2Table.Margin = new System.Windows.Forms.Padding(0);
      this.panel2Table.Name = "panel2Table";
      this.panel2Table.RowCount = 2;
      this.panel2Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.panel2Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.panel2Table.Size = new System.Drawing.Size(494, 505);
      this.panel2Table.TabIndex = 0;
      // 
      // questionInfoGroup
      // 
      this.questionInfoGroup.Controls.Add(this.panel2SubTable);
      this.questionInfoGroup.Dock = System.Windows.Forms.DockStyle.Fill;
      this.questionInfoGroup.Location = new System.Drawing.Point(3, 3);
      this.questionInfoGroup.Name = "questionInfoGroup";
      this.questionInfoGroup.Size = new System.Drawing.Size(488, 246);
      this.questionInfoGroup.TabIndex = 0;
      this.questionInfoGroup.TabStop = false;
      this.questionInfoGroup.Text = "Question Information";
      // 
      // panel2SubTable
      // 
      this.panel2SubTable.ColumnCount = 2;
      this.panel2SubTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.panel2SubTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
      this.panel2SubTable.Controls.Add(this.questionLabel, 0, 0);
      this.panel2SubTable.Controls.Add(this.pointsLabel, 0, 1);
      this.panel2SubTable.Controls.Add(this.imageLabel, 0, 2);
      this.panel2SubTable.Controls.Add(this.image, 1, 2);
      this.panel2SubTable.Controls.Add(this.question, 1, 0);
      this.panel2SubTable.Controls.Add(this.points, 1, 1);
      this.panel2SubTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2SubTable.Location = new System.Drawing.Point(3, 16);
      this.panel2SubTable.Margin = new System.Windows.Forms.Padding(0);
      this.panel2SubTable.Name = "panel2SubTable";
      this.panel2SubTable.RowCount = 3;
      this.panel2SubTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.panel2SubTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.panel2SubTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
      this.panel2SubTable.Size = new System.Drawing.Size(482, 227);
      this.panel2SubTable.TabIndex = 0;
      // 
      // questionLabel
      // 
      this.questionLabel.AutoSize = true;
      this.questionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.questionLabel.Location = new System.Drawing.Point(3, 0);
      this.questionLabel.Name = "questionLabel";
      this.questionLabel.Size = new System.Drawing.Size(90, 45);
      this.questionLabel.TabIndex = 0;
      this.questionLabel.Text = "Question:";
      this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // pointsLabel
      // 
      this.pointsLabel.AutoSize = true;
      this.pointsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pointsLabel.Location = new System.Drawing.Point(3, 45);
      this.pointsLabel.Name = "pointsLabel";
      this.pointsLabel.Size = new System.Drawing.Size(90, 45);
      this.pointsLabel.TabIndex = 1;
      this.pointsLabel.Text = "Points:";
      this.pointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // imageLabel
      // 
      this.imageLabel.AutoSize = true;
      this.imageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.imageLabel.Location = new System.Drawing.Point(3, 90);
      this.imageLabel.Name = "imageLabel";
      this.imageLabel.Size = new System.Drawing.Size(90, 137);
      this.imageLabel.TabIndex = 2;
      this.imageLabel.Text = "Image:";
      this.imageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // image
      // 
      this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.image.Dock = System.Windows.Forms.DockStyle.Fill;
      this.image.Location = new System.Drawing.Point(99, 93);
      this.image.Name = "image";
      this.image.Size = new System.Drawing.Size(380, 131);
      this.image.TabIndex = 3;
      this.image.TabStop = false;
      this.image.Click += new System.EventHandler(this.SetImage);
      // 
      // question
      // 
      this.question.AcceptsReturn = true;
      this.question.AcceptsTab = true;
      this.question.Dock = System.Windows.Forms.DockStyle.Fill;
      this.question.Location = new System.Drawing.Point(99, 3);
      this.question.Multiline = true;
      this.question.Name = "question";
      this.question.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.question.Size = new System.Drawing.Size(380, 39);
      this.question.TabIndex = 4;
      this.question.TextChanged += new System.EventHandler(this.SetQuestion);
      // 
      // points
      // 
      this.points.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.points.Location = new System.Drawing.Point(99, 57);
      this.points.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
      this.points.Name = "points";
      this.points.Size = new System.Drawing.Size(378, 20);
      this.points.TabIndex = 5;
      this.points.ThousandsSeparator = true;
      this.points.ValueChanged += new System.EventHandler(this.SetPoints);
      // 
      // answersGroup
      // 
      this.answersGroup.Controls.Add(this.answerTable);
      this.answersGroup.Dock = System.Windows.Forms.DockStyle.Fill;
      this.answersGroup.Location = new System.Drawing.Point(0, 252);
      this.answersGroup.Margin = new System.Windows.Forms.Padding(0);
      this.answersGroup.Name = "answersGroup";
      this.answersGroup.Size = new System.Drawing.Size(494, 253);
      this.answersGroup.TabIndex = 1;
      this.answersGroup.TabStop = false;
      this.answersGroup.Text = "Answers";
      // 
      // answerTable
      // 
      this.answerTable.ColumnCount = 1;
      this.answerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.answerTable.Controls.Add(this.addAnswer, 0, 1);
      this.answerTable.Controls.Add(this.answersTable, 0, 0);
      this.answerTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.answerTable.Location = new System.Drawing.Point(3, 16);
      this.answerTable.Margin = new System.Windows.Forms.Padding(0);
      this.answerTable.Name = "answerTable";
      this.answerTable.RowCount = 2;
      this.answerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
      this.answerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.answerTable.Size = new System.Drawing.Size(488, 234);
      this.answerTable.TabIndex = 0;
      // 
      // addAnswer
      // 
      this.addAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.addAnswer.Location = new System.Drawing.Point(0, 210);
      this.addAnswer.Margin = new System.Windows.Forms.Padding(0);
      this.addAnswer.Name = "addAnswer";
      this.addAnswer.Size = new System.Drawing.Size(488, 24);
      this.addAnswer.TabIndex = 0;
      this.addAnswer.Text = "Add Answer";
      this.addAnswer.UseVisualStyleBackColor = true;
      this.addAnswer.Click += new System.EventHandler(this.AddAnswer);
      // 
      // answersTable
      // 
      this.answersTable.AutoScroll = true;
      this.answersTable.AutoSize = true;
      this.answersTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.answersTable.ColumnCount = 1;
      this.answersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.answersTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.answersTable.Location = new System.Drawing.Point(0, 0);
      this.answersTable.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
      this.answersTable.Name = "answersTable";
      this.answersTable.RowCount = 1;
      this.answersTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.answersTable.Size = new System.Drawing.Size(487, 210);
      this.answersTable.TabIndex = 1;
      // 
      // teamsTab
      // 
      this.teamsTab.Controls.Add(this.teamTable);
      this.teamsTab.Location = new System.Drawing.Point(4, 22);
      this.teamsTab.Name = "teamsTab";
      this.teamsTab.Padding = new System.Windows.Forms.Padding(3);
      this.teamsTab.Size = new System.Drawing.Size(776, 511);
      this.teamsTab.TabIndex = 2;
      this.teamsTab.Text = "Teams";
      this.teamsTab.UseVisualStyleBackColor = true;
      // 
      // teamTable
      // 
      this.teamTable.ColumnCount = 1;
      this.teamTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.teamTable.Controls.Add(this.addTeam, 0, 1);
      this.teamTable.Controls.Add(this.teamsTable, 0, 0);
      this.teamTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.teamTable.Location = new System.Drawing.Point(3, 3);
      this.teamTable.Name = "teamTable";
      this.teamTable.RowCount = 2;
      this.teamTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
      this.teamTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.teamTable.Size = new System.Drawing.Size(770, 505);
      this.teamTable.TabIndex = 0;
      // 
      // addTeam
      // 
      this.addTeam.Dock = System.Windows.Forms.DockStyle.Fill;
      this.addTeam.Location = new System.Drawing.Point(3, 457);
      this.addTeam.Name = "addTeam";
      this.addTeam.Size = new System.Drawing.Size(764, 45);
      this.addTeam.TabIndex = 0;
      this.addTeam.Text = "Add Team";
      this.addTeam.UseVisualStyleBackColor = true;
      this.addTeam.Click += new System.EventHandler(this.AddTeam);
      // 
      // teamsTable
      // 
      this.teamsTable.AutoScroll = true;
      this.teamsTable.AutoSize = true;
      this.teamsTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.teamsTable.ColumnCount = 1;
      this.teamsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.teamsTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.teamsTable.Location = new System.Drawing.Point(3, 3);
      this.teamsTable.Name = "teamsTable";
      this.teamsTable.RowCount = 1;
      this.teamsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.teamsTable.Size = new System.Drawing.Size(764, 448);
      this.teamsTable.TabIndex = 1;
      // 
      // mainMenu
      // 
      this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.reloadToolStripMenuItem});
      this.mainMenu.Location = new System.Drawing.Point(0, 0);
      this.mainMenu.Name = "mainMenu";
      this.mainMenu.Size = new System.Drawing.Size(784, 24);
      this.mainMenu.TabIndex = 1;
      this.mainMenu.Text = "mainMenu";
      // 
      // importToolStripMenuItem
      // 
      this.importToolStripMenuItem.Name = "importToolStripMenuItem";
      this.importToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
      this.importToolStripMenuItem.Text = "Import";
      this.importToolStripMenuItem.Click += new System.EventHandler(this.ImportArchive);
      // 
      // exportToolStripMenuItem
      // 
      this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
      this.exportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
      this.exportToolStripMenuItem.Text = "Export";
      this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportArchive);
      // 
      // saveToolStripMenuItem1
      // 
      this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
      this.saveToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
      this.saveToolStripMenuItem1.Text = "Save";
      this.saveToolStripMenuItem1.Click += new System.EventHandler(this.SaveArchive);
      // 
      // reloadToolStripMenuItem
      // 
      this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
      this.reloadToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
      this.reloadToolStripMenuItem.Text = "Reload";
      this.reloadToolStripMenuItem.Click += new System.EventHandler(this.ReloadArchive);
      // 
      // colorDialog
      // 
      this.colorDialog.AnyColor = true;
      // 
      // openImage
      // 
      this.openImage.Filter = "Image Files (*.bmp, *.jpg, *.jpeg)|*.bmp;*.jpg;*.jpeg";
      // 
      // openSound
      // 
      this.openSound.Filter = "Sound Files (*.wav)|*.wav";
      // 
      // fontDialog
      // 
      this.fontDialog.FontMustExist = true;
      // 
      // openArchive
      // 
      this.openArchive.Title = "Choose what Content Archive to edit";
      this.openArchive.Filter = "School Game Content Archive (*.sgca)|*.sgca";
      // 
      // saveArchiveDialog
      // 
      this.saveArchiveDialog.Title = "Choose where to export your Content Archive";
      this.saveArchiveDialog.DefaultExt = "sgca";
      this.saveArchiveDialog.Filter = "School Game Content Archive (*.sgca)|*.sgca";
      // 
      // MainScreen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 561);
      this.Controls.Add(this.tabControl);
      this.Controls.Add(this.mainMenu);
      this.MainMenuStrip = this.mainMenu;
      this.Name = "MainScreen";
      this.Text = "School Game Content Creator";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
      this.tabControl.ResumeLayout(false);
      this.generalTab.ResumeLayout(false);
      this.generalTable.ResumeLayout(false);
      this.generalTable.PerformLayout();
      this.timeInfoGroup.ResumeLayout(false);
      this.timeInfoGroup.PerformLayout();
      this.timeTable.ResumeLayout(false);
      this.timeTable.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.beforeAnswer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.afterAnswer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.delayScore)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.delayGO)).EndInit();
      this.soundInfoGroup.ResumeLayout(false);
      this.soundInfoGroup.PerformLayout();
      this.soundTable.ResumeLayout(false);
      this.soundTable.PerformLayout();
      this.generalInfoGroup.ResumeLayout(false);
      this.generalInfoGroup.PerformLayout();
      this.generalSTable.ResumeLayout(false);
      this.generalSTable.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bkgImage)).EndInit();
      this.archiveInfoGroup.ResumeLayout(false);
      this.archiveInfoGroup.PerformLayout();
      this.archiveTable.ResumeLayout(false);
      this.archiveTable.PerformLayout();
      this.questionsTab.ResumeLayout(false);
      this.splitContainer.Panel1.ResumeLayout(false);
      this.splitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
      this.splitContainer.ResumeLayout(false);
      this.nodeTable.ResumeLayout(false);
      this.nodeEditTable.ResumeLayout(false);
      this.panel2Table.ResumeLayout(false);
      this.questionInfoGroup.ResumeLayout(false);
      this.panel2SubTable.ResumeLayout(false);
      this.panel2SubTable.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.points)).EndInit();
      this.answersGroup.ResumeLayout(false);
      this.answerTable.ResumeLayout(false);
      this.answerTable.PerformLayout();
      this.teamsTab.ResumeLayout(false);
      this.teamTable.ResumeLayout(false);
      this.teamTable.PerformLayout();
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
    private System.Windows.Forms.TableLayoutPanel generalTable;
    private System.Windows.Forms.GroupBox timeInfoGroup;
    private System.Windows.Forms.GroupBox soundInfoGroup;
    private System.Windows.Forms.GroupBox generalInfoGroup;
    private System.Windows.Forms.GroupBox archiveInfoGroup;
    private System.Windows.Forms.TableLayoutPanel archiveTable;
    private System.Windows.Forms.TextBox archiveName;
    private System.Windows.Forms.TextBox archiveDesc;
    private System.Windows.Forms.Label archiveNameLabel;
    private System.Windows.Forms.Label archiveDescLabel;
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
    private System.Windows.Forms.SplitContainer splitContainer;
    private System.Windows.Forms.TableLayoutPanel panel2Table;
    private System.Windows.Forms.GroupBox questionInfoGroup;
    private System.Windows.Forms.GroupBox answersGroup;
    private System.Windows.Forms.TableLayoutPanel panel2SubTable;
    private System.Windows.Forms.TableLayoutPanel answerTable;
    private System.Windows.Forms.Button addAnswer;
    private System.Windows.Forms.TableLayoutPanel answersTable;
    private System.Windows.Forms.Label questionLabel;
    private System.Windows.Forms.Label pointsLabel;
    private System.Windows.Forms.Label imageLabel;
    private System.Windows.Forms.PictureBox image;
    private System.Windows.Forms.TextBox question;
    private System.Windows.Forms.NumericUpDown points;
    private System.Windows.Forms.TableLayoutPanel nodeTable;
    private System.Windows.Forms.TableLayoutPanel nodeEditTable;
    private System.Windows.Forms.Button addTopic;
    private System.Windows.Forms.Button addQuestion;
    private System.Windows.Forms.Button removeCurrentTopic;
    private System.Windows.Forms.Button removeCurrentQuestion;
    private System.Windows.Forms.TableLayoutPanel teamTable;
    private System.Windows.Forms.Button addTeam;
    private System.Windows.Forms.TableLayoutPanel teamsTable;
    private System.Windows.Forms.TextBox winning;
    private System.Windows.Forms.TextBox losing;
    private System.Windows.Forms.TextBox tying;
    private System.Windows.Forms.TextBox won;
    private System.Windows.Forms.TextBox lost;
    private System.Windows.Forms.TextBox tied;
    private System.Windows.Forms.Label winingLabel;
    private System.Windows.Forms.Label losingLabel;
    private System.Windows.Forms.Label tyingLabel;
    private System.Windows.Forms.Label wonLabel;
    private System.Windows.Forms.Label lostLabel;
    private System.Windows.Forms.Label tiedLabel;
    private System.Windows.Forms.TextBox updateURL;
    private System.Windows.Forms.Label archiveURLLabel;
    private Controls.TreeLE topicsTree;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
    private System.Windows.Forms.Label versionLabel;
    private System.Windows.Forms.TextBox version;
    private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    private System.Windows.Forms.TextBox author;
    private System.Windows.Forms.TextBox license;
    private System.Windows.Forms.Label authorLabel;
    private System.Windows.Forms.Label licenseLabel;
  }
}