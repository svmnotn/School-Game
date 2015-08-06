namespace SchoolGame.Game.UI {
  partial class Splash {
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
      this.components = new System.ComponentModel.Container();
      this.Loading = new System.Windows.Forms.Label();
      this.LoadingBar = new System.Windows.Forms.ProgressBar();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // Loading
      // 
      this.Loading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.Loading.AutoSize = true;
      this.Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Loading.ForeColor = System.Drawing.SystemColors.ControlLight;
      this.Loading.Location = new System.Drawing.Point(193, 181);
      this.Loading.Margin = new System.Windows.Forms.Padding(0);
      this.Loading.Name = "Loading";
      this.Loading.Size = new System.Drawing.Size(391, 108);
      this.Loading.TabIndex = 0;
      this.Loading.Text = "Loading";
      this.Loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // LoadingBar
      // 
      this.LoadingBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.LoadingBar.Location = new System.Drawing.Point(12, 491);
      this.LoadingBar.Name = "LoadingBar";
      this.LoadingBar.Size = new System.Drawing.Size(760, 58);
      this.LoadingBar.TabIndex = 1;
      // 
      // timer
      // 
      this.timer.Enabled = true;
      this.timer.Interval = 5;
      this.timer.Tick += new System.EventHandler(this.OnTick);
      // 
      // Splash
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.ClientSize = new System.Drawing.Size(784, 561);
      this.Controls.Add(this.LoadingBar);
      this.Controls.Add(this.Loading);
      this.Cursor = System.Windows.Forms.Cursors.AppStarting;
      this.Name = "Splash";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label Loading;
    private System.Windows.Forms.Timer timer;
    internal System.Windows.Forms.ProgressBar LoadingBar;
  }
}