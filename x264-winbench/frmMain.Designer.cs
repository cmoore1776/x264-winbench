namespace x264_winbench
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.clb1080p60 = new System.Windows.Forms.CheckedListBox();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.clb720p60 = new System.Windows.Forms.CheckedListBox();
            this.clb720p30 = new System.Windows.Forms.CheckedListBox();
            this.clb1080p30 = new System.Windows.Forms.CheckedListBox();
            this.cb720p30 = new System.Windows.Forms.CheckBox();
            this.cb720p60 = new System.Windows.Forms.CheckBox();
            this.cb1080p30 = new System.Windows.Forms.CheckBox();
            this.cb1080p60 = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(62, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // clb1080p60
            // 
            this.clb1080p60.FormattingEnabled = true;
            this.clb1080p60.Items.AddRange(new object[] {
            "ultrafast",
            "superfast",
            "veryfast",
            "faster",
            "fast",
            "medium",
            "slow",
            "veryslow"});
            this.clb1080p60.Location = new System.Drawing.Point(255, 109);
            this.clb1080p60.Name = "clb1080p60";
            this.clb1080p60.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clb1080p60.Size = new System.Drawing.Size(75, 124);
            this.clb1080p60.TabIndex = 1;
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(12, 41);
            this.progBar.Maximum = 32;
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(318, 23);
            this.progBar.TabIndex = 3;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(80, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(62, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // clb720p60
            // 
            this.clb720p60.FormattingEnabled = true;
            this.clb720p60.Items.AddRange(new object[] {
            "ultrafast",
            "superfast",
            "veryfast",
            "faster",
            "fast",
            "medium",
            "slow",
            "veryslow"});
            this.clb720p60.Location = new System.Drawing.Point(93, 109);
            this.clb720p60.Name = "clb720p60";
            this.clb720p60.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clb720p60.Size = new System.Drawing.Size(75, 124);
            this.clb720p60.TabIndex = 5;
            // 
            // clb720p30
            // 
            this.clb720p30.FormattingEnabled = true;
            this.clb720p30.Items.AddRange(new object[] {
            "ultrafast",
            "superfast",
            "veryfast",
            "faster",
            "fast",
            "medium",
            "slow",
            "veryslow"});
            this.clb720p30.Location = new System.Drawing.Point(12, 109);
            this.clb720p30.Name = "clb720p30";
            this.clb720p30.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clb720p30.Size = new System.Drawing.Size(75, 124);
            this.clb720p30.TabIndex = 9;
            // 
            // clb1080p30
            // 
            this.clb1080p30.FormattingEnabled = true;
            this.clb1080p30.Items.AddRange(new object[] {
            "ultrafast",
            "superfast",
            "veryfast",
            "faster",
            "fast",
            "medium",
            "slow",
            "veryslow"});
            this.clb1080p30.Location = new System.Drawing.Point(174, 109);
            this.clb1080p30.Name = "clb1080p30";
            this.clb1080p30.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clb1080p30.Size = new System.Drawing.Size(75, 124);
            this.clb1080p30.TabIndex = 7;
            // 
            // cb720p30
            // 
            this.cb720p30.AutoSize = true;
            this.cb720p30.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cb720p30.Checked = true;
            this.cb720p30.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb720p30.Location = new System.Drawing.Point(27, 70);
            this.cb720p30.Name = "cb720p30";
            this.cb720p30.Size = new System.Drawing.Size(47, 31);
            this.cb720p30.TabIndex = 11;
            this.cb720p30.Text = "720p30";
            this.cb720p30.UseVisualStyleBackColor = true;
            this.cb720p30.CheckedChanged += new System.EventHandler(this.cb720p30_CheckedChanged);
            // 
            // cb720p60
            // 
            this.cb720p60.AutoSize = true;
            this.cb720p60.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cb720p60.Checked = true;
            this.cb720p60.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb720p60.Location = new System.Drawing.Point(106, 72);
            this.cb720p60.Name = "cb720p60";
            this.cb720p60.Size = new System.Drawing.Size(47, 31);
            this.cb720p60.TabIndex = 12;
            this.cb720p60.Text = "720p60";
            this.cb720p60.UseVisualStyleBackColor = true;
            this.cb720p60.CheckedChanged += new System.EventHandler(this.cb720p60_CheckedChanged);
            // 
            // cb1080p30
            // 
            this.cb1080p30.AutoSize = true;
            this.cb1080p30.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cb1080p30.Checked = true;
            this.cb1080p30.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb1080p30.Location = new System.Drawing.Point(189, 70);
            this.cb1080p30.Name = "cb1080p30";
            this.cb1080p30.Size = new System.Drawing.Size(53, 31);
            this.cb1080p30.TabIndex = 13;
            this.cb1080p30.Text = "1080p30";
            this.cb1080p30.UseVisualStyleBackColor = true;
            this.cb1080p30.CheckedChanged += new System.EventHandler(this.cb1080p30_CheckedChanged);
            // 
            // cb1080p60
            // 
            this.cb1080p60.AutoSize = true;
            this.cb1080p60.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cb1080p60.Checked = true;
            this.cb1080p60.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb1080p60.Location = new System.Drawing.Point(270, 70);
            this.cb1080p60.Name = "cb1080p60";
            this.cb1080p60.Size = new System.Drawing.Size(53, 31);
            this.cb1080p60.TabIndex = 14;
            this.cb1080p60.Text = "1080p60";
            this.cb1080p60.UseVisualStyleBackColor = true;
            this.cb1080p60.CheckedChanged += new System.EventHandler(this.cb1080p60_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(148, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(182, 23);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Waiting to start...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 245);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cb1080p60);
            this.Controls.Add(this.cb1080p30);
            this.Controls.Add(this.cb720p60);
            this.Controls.Add(this.cb720p30);
            this.Controls.Add(this.clb720p30);
            this.Controls.Add(this.clb1080p30);
            this.Controls.Add(this.clb720p60);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.clb1080p60);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "x264-winbench";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckedListBox clb1080p60;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckedListBox clb720p60;
        private System.Windows.Forms.CheckedListBox clb720p30;
        private System.Windows.Forms.CheckedListBox clb1080p30;
        private System.Windows.Forms.CheckBox cb720p30;
        private System.Windows.Forms.CheckBox cb720p60;
        private System.Windows.Forms.CheckBox cb1080p30;
        private System.Windows.Forms.CheckBox cb1080p60;
        private System.Windows.Forms.Label lblStatus;
    }
}

