namespace PingRequester.Client
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTop = new Panel();
            lblPingRequester = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            preferencesToolStripMenuItem = new ToolStripMenuItem();
            pnlInfo = new Panel();
            lblInfo = new Label();
            pnlControls = new Panel();
            lblNumberOfPR = new Label();
            nudNumberOfPR = new NumericUpDown();
            cmbMode = new ComboBox();
            lblMode = new Label();
            btnStop = new Button();
            btnSendRequest = new Button();
            lblAttempts = new Label();
            chbInfiniteLoop = new CheckBox();
            nudAttempts = new NumericUpDown();
            nudRefreshRate = new NumericUpDown();
            lblRefreshRate = new Label();
            lblPingTarget = new Label();
            txbPingTarget = new TextBox();
            pnlData = new Panel();
            pnlMiddle = new Panel();
            lblLineSeparator = new Label();
            pnlTop.SuspendLayout();
            menuStrip1.SuspendLayout();
            pnlInfo.SuspendLayout();
            pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfPR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAttempts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRefreshRate).BeginInit();
            pnlMiddle.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlTop.Controls.Add(lblLineSeparator);
            pnlTop.Controls.Add(lblPingRequester);
            pnlTop.Controls.Add(menuStrip1);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(811, 87);
            pnlTop.TabIndex = 0;
            // 
            // lblPingRequester
            // 
            lblPingRequester.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPingRequester.AutoSize = true;
            lblPingRequester.Font = new Font("Calibri", 24F);
            lblPingRequester.ForeColor = SystemColors.HotTrack;
            lblPingRequester.Location = new Point(299, 35);
            lblPingRequester.Name = "lblPingRequester";
            lblPingRequester.Size = new Size(213, 39);
            lblPingRequester.TabIndex = 0;
            lblPingRequester.Text = "Ping Requester";
            lblPingRequester.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(811, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(90, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { preferencesToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // preferencesToolStripMenuItem
            // 
            preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            preferencesToolStripMenuItem.Size = new Size(135, 22);
            preferencesToolStripMenuItem.Text = "Preferences";
            preferencesToolStripMenuItem.Click += preferencesToolStripMenuItem_Click;
            // 
            // pnlInfo
            // 
            pnlInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlInfo.Controls.Add(lblInfo);
            pnlInfo.Dock = DockStyle.Bottom;
            pnlInfo.Location = new Point(0, 480);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(811, 32);
            pnlInfo.TabIndex = 2;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblInfo.ForeColor = SystemColors.InfoText;
            lblInfo.Location = new Point(10, 3);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(56, 18);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Info: ";
            // 
            // pnlControls
            // 
            pnlControls.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlControls.Controls.Add(lblNumberOfPR);
            pnlControls.Controls.Add(nudNumberOfPR);
            pnlControls.Controls.Add(cmbMode);
            pnlControls.Controls.Add(lblMode);
            pnlControls.Controls.Add(btnStop);
            pnlControls.Controls.Add(btnSendRequest);
            pnlControls.Controls.Add(lblAttempts);
            pnlControls.Controls.Add(chbInfiniteLoop);
            pnlControls.Controls.Add(nudAttempts);
            pnlControls.Controls.Add(nudRefreshRate);
            pnlControls.Controls.Add(lblRefreshRate);
            pnlControls.Controls.Add(lblPingTarget);
            pnlControls.Controls.Add(txbPingTarget);
            pnlControls.Dock = DockStyle.Left;
            pnlControls.Location = new Point(0, 0);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new Size(386, 425);
            pnlControls.TabIndex = 2;
            // 
            // lblNumberOfPR
            // 
            lblNumberOfPR.AutoSize = true;
            lblNumberOfPR.Font = new Font("Calibri", 10.2F);
            lblNumberOfPR.ForeColor = SystemColors.ActiveCaptionText;
            lblNumberOfPR.Location = new Point(12, 207);
            lblNumberOfPR.Name = "lblNumberOfPR";
            lblNumberOfPR.Size = new Size(146, 17);
            lblNumberOfPR.TabIndex = 4;
            lblNumberOfPR.Text = "Number of ping requests";
            // 
            // nudNumberOfPR
            // 
            nudNumberOfPR.Location = new Point(285, 205);
            nudNumberOfPR.Name = "nudNumberOfPR";
            nudNumberOfPR.Size = new Size(65, 23);
            nudNumberOfPR.TabIndex = 3;
            // 
            // cmbMode
            // 
            cmbMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMode.FormattingEnabled = true;
            cmbMode.Location = new Point(228, 85);
            cmbMode.Name = "cmbMode";
            cmbMode.Size = new Size(122, 23);
            cmbMode.TabIndex = 15;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Calibri", 10.2F);
            lblMode.ForeColor = SystemColors.ActiveCaptionText;
            lblMode.Location = new Point(12, 88);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(41, 17);
            lblMode.TabIndex = 14;
            lblMode.Text = "Mode";
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnStop.ForeColor = Color.IndianRed;
            btnStop.Location = new Point(223, 332);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(86, 36);
            btnStop.TabIndex = 13;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // btnSendRequest
            // 
            btnSendRequest.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnSendRequest.ForeColor = SystemColors.Highlight;
            btnSendRequest.Location = new Point(32, 332);
            btnSendRequest.Name = "btnSendRequest";
            btnSendRequest.Size = new Size(149, 36);
            btnSendRequest.TabIndex = 12;
            btnSendRequest.Text = "Send Request";
            btnSendRequest.UseVisualStyleBackColor = true;
            btnSendRequest.Click += btnSendRequest_Click;
            // 
            // lblAttempts
            // 
            lblAttempts.AutoSize = true;
            lblAttempts.Font = new Font("Calibri", 10.2F);
            lblAttempts.ForeColor = SystemColors.ActiveCaptionText;
            lblAttempts.Location = new Point(12, 244);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(60, 17);
            lblAttempts.TabIndex = 11;
            lblAttempts.Text = "Attempts";
            // 
            // chbInfiniteLoop
            // 
            chbInfiniteLoop.AutoSize = true;
            chbInfiniteLoop.Font = new Font("Calibri", 10.2F);
            chbInfiniteLoop.ForeColor = SystemColors.ActiveCaptionText;
            chbInfiniteLoop.Location = new Point(12, 170);
            chbInfiniteLoop.Name = "chbInfiniteLoop";
            chbInfiniteLoop.Size = new Size(94, 21);
            chbInfiniteLoop.TabIndex = 2;
            chbInfiniteLoop.Text = "Infinite loop";
            chbInfiniteLoop.UseVisualStyleBackColor = true;
            chbInfiniteLoop.Click += chbInfiniteLoop_Click;
            // 
            // nudAttempts
            // 
            nudAttempts.Location = new Point(285, 242);
            nudAttempts.Name = "nudAttempts";
            nudAttempts.Size = new Size(65, 23);
            nudAttempts.TabIndex = 10;
            // 
            // nudRefreshRate
            // 
            nudRefreshRate.Location = new Point(285, 127);
            nudRefreshRate.Name = "nudRefreshRate";
            nudRefreshRate.Size = new Size(65, 23);
            nudRefreshRate.TabIndex = 9;
            // 
            // lblRefreshRate
            // 
            lblRefreshRate.AutoSize = true;
            lblRefreshRate.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblRefreshRate.ForeColor = SystemColors.ActiveCaptionText;
            lblRefreshRate.Location = new Point(12, 129);
            lblRefreshRate.Name = "lblRefreshRate";
            lblRefreshRate.Size = new Size(94, 17);
            lblRefreshRate.TabIndex = 8;
            lblRefreshRate.Text = "Refresh rate (s)";
            // 
            // lblPingTarget
            // 
            lblPingTarget.AutoSize = true;
            lblPingTarget.Font = new Font("Calibri", 10.2F);
            lblPingTarget.ForeColor = SystemColors.ActiveCaptionText;
            lblPingTarget.Location = new Point(12, 11);
            lblPingTarget.Name = "lblPingTarget";
            lblPingTarget.Size = new Size(71, 17);
            lblPingTarget.TabIndex = 0;
            lblPingTarget.Text = "Ping target";
            // 
            // txbPingTarget
            // 
            txbPingTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbPingTarget.Location = new Point(12, 38);
            txbPingTarget.Name = "txbPingTarget";
            txbPingTarget.Size = new Size(338, 23);
            txbPingTarget.TabIndex = 1;
            // 
            // pnlData
            // 
            pnlData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlData.Dock = DockStyle.Right;
            pnlData.Location = new Point(394, 0);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(417, 425);
            pnlData.TabIndex = 3;
            // 
            // pnlMiddle
            // 
            pnlMiddle.Controls.Add(pnlData);
            pnlMiddle.Controls.Add(pnlControls);
            pnlMiddle.Dock = DockStyle.Fill;
            pnlMiddle.Location = new Point(0, 87);
            pnlMiddle.Name = "pnlMiddle";
            pnlMiddle.Size = new Size(811, 425);
            pnlMiddle.TabIndex = 1;
            // 
            // lblLineSeparator
            // 
            lblLineSeparator.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLineSeparator.BorderStyle = BorderStyle.Fixed3D;
            lblLineSeparator.Location = new Point(5, 78);
            lblLineSeparator.Name = "lblLineSeparator";
            lblLineSeparator.Size = new Size(800, 2);
            lblLineSeparator.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(811, 512);
            Controls.Add(pnlInfo);
            Controls.Add(pnlMiddle);
            Controls.Add(pnlTop);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Ping Requester";
            Load += MainForm_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            pnlControls.ResumeLayout(false);
            pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfPR).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAttempts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRefreshRate).EndInit();
            pnlMiddle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Label lblPingRequester;
        private Panel pnlInfo;
        private Label lblInfo;
        private Panel pnlControls;
        private Label lblAttempts;
        private Label lblNumberOfPR;
        private CheckBox chbInfiniteLoop;
        private NumericUpDown nudAttempts;
        private NumericUpDown nudNumberOfPR;
        private NumericUpDown nudRefreshRate;
        private Label lblRefreshRate;
        private Label lblPingTarget;
        private TextBox txbPingTarget;
        private Panel pnlData;
        private Panel pnlMiddle;
        private Button btnSendRequest;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem preferencesToolStripMenuItem;
        private Button btnStop;
        private ComboBox cmbMode;
        private Label lblMode;
        private Label lblLineSeparator;

        public string PingTarget { get => txbPingTarget.Text; }
        public string Mode { get => cmbMode.Text; }
        public int RefreshRate { get => (int)nudRefreshRate.Value; }
        public bool InfiniteLoop { get => chbInfiniteLoop.Checked; }
        public int NumberOfPR { get => (int)nudNumberOfPR.Value; }
        public int Attempts { get => (int)nudAttempts.Value; }
    }
}
