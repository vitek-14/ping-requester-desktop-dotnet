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
            pictureBox1 = new PictureBox();
            lblLineSeparator = new Label();
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
            lblPacketSize = new Label();
            nudPacketSize = new NumericUpDown();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            pnlInfo.SuspendLayout();
            pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfPR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAttempts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRefreshRate).BeginInit();
            pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPacketSize).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlTop.BackColor = SystemColors.ButtonHighlight;
            pnlTop.Controls.Add(pictureBox1);
            pnlTop.Controls.Add(lblLineSeparator);
            pnlTop.Controls.Add(menuStrip1);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(811, 143);
            pnlTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Ping_Requester_Poster_6;
            pictureBox1.Location = new Point(0, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(811, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblLineSeparator
            // 
            lblLineSeparator.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLineSeparator.BorderStyle = BorderStyle.Fixed3D;
            lblLineSeparator.Location = new Point(5, 138);
            lblLineSeparator.Name = "lblLineSeparator";
            lblLineSeparator.Size = new Size(800, 2);
            lblLineSeparator.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(811, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { preferencesToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(76, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // preferencesToolStripMenuItem
            // 
            preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            preferencesToolStripMenuItem.Size = new Size(168, 26);
            preferencesToolStripMenuItem.Text = "Preferences";
            preferencesToolStripMenuItem.Click += preferencesToolStripMenuItem_Click;
            // 
            // pnlInfo
            // 
            pnlInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlInfo.Controls.Add(lblInfo);
            pnlInfo.Dock = DockStyle.Bottom;
            pnlInfo.Location = new Point(0, 552);
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
            lblInfo.Size = new Size(70, 22);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Info: ";
            // 
            // pnlControls
            // 
            pnlControls.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlControls.Controls.Add(nudPacketSize);
            pnlControls.Controls.Add(lblPacketSize);
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
            pnlControls.Size = new Size(332, 441);
            pnlControls.TabIndex = 2;
            // 
            // lblNumberOfPR
            // 
            lblNumberOfPR.AutoSize = true;
            lblNumberOfPR.Font = new Font("Calibri", 10.2F);
            lblNumberOfPR.ForeColor = SystemColors.ActiveCaptionText;
            lblNumberOfPR.Location = new Point(12, 183);
            lblNumberOfPR.Name = "lblNumberOfPR";
            lblNumberOfPR.Size = new Size(183, 21);
            lblNumberOfPR.TabIndex = 4;
            lblNumberOfPR.Text = "Number of ping requests";
            // 
            // nudNumberOfPR
            // 
            nudNumberOfPR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudNumberOfPR.Location = new Point(229, 181);
            nudNumberOfPR.Name = "nudNumberOfPR";
            nudNumberOfPR.Size = new Size(67, 27);
            nudNumberOfPR.TabIndex = 3;
            // 
            // cmbMode
            // 
            cmbMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMode.FormattingEnabled = true;
            cmbMode.Location = new Point(172, 74);
            cmbMode.Name = "cmbMode";
            cmbMode.Size = new Size(124, 28);
            cmbMode.TabIndex = 15;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Calibri", 10.2F);
            lblMode.ForeColor = SystemColors.ActiveCaptionText;
            lblMode.Location = new Point(12, 77);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(51, 21);
            lblMode.TabIndex = 14;
            lblMode.Text = "Mode";
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnStop.ForeColor = Color.IndianRed;
            btnStop.Location = new Point(204, 352);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(77, 36);
            btnStop.TabIndex = 13;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // btnSendRequest
            // 
            btnSendRequest.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnSendRequest.ForeColor = SystemColors.Highlight;
            btnSendRequest.Location = new Point(28, 352);
            btnSendRequest.Name = "btnSendRequest";
            btnSendRequest.Size = new Size(130, 36);
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
            lblAttempts.Location = new Point(12, 220);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(75, 21);
            lblAttempts.TabIndex = 11;
            lblAttempts.Text = "Attempts";
            // 
            // chbInfiniteLoop
            // 
            chbInfiniteLoop.AutoSize = true;
            chbInfiniteLoop.Font = new Font("Calibri", 10.2F);
            chbInfiniteLoop.ForeColor = SystemColors.ActiveCaptionText;
            chbInfiniteLoop.Location = new Point(12, 146);
            chbInfiniteLoop.Name = "chbInfiniteLoop";
            chbInfiniteLoop.Size = new Size(116, 25);
            chbInfiniteLoop.TabIndex = 2;
            chbInfiniteLoop.Text = "Infinite loop";
            chbInfiniteLoop.UseVisualStyleBackColor = true;
            chbInfiniteLoop.Click += chbInfiniteLoop_Click;
            // 
            // nudAttempts
            // 
            nudAttempts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudAttempts.Location = new Point(229, 218);
            nudAttempts.Name = "nudAttempts";
            nudAttempts.Size = new Size(67, 27);
            nudAttempts.TabIndex = 10;
            // 
            // nudRefreshRate
            // 
            nudRefreshRate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudRefreshRate.Location = new Point(229, 111);
            nudRefreshRate.Name = "nudRefreshRate";
            nudRefreshRate.Size = new Size(67, 27);
            nudRefreshRate.TabIndex = 9;
            // 
            // lblRefreshRate
            // 
            lblRefreshRate.AutoSize = true;
            lblRefreshRate.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblRefreshRate.ForeColor = SystemColors.ActiveCaptionText;
            lblRefreshRate.Location = new Point(12, 113);
            lblRefreshRate.Name = "lblRefreshRate";
            lblRefreshRate.Size = new Size(115, 21);
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
            lblPingTarget.Size = new Size(86, 21);
            lblPingTarget.TabIndex = 0;
            lblPingTarget.Text = "Ping target";
            // 
            // txbPingTarget
            // 
            txbPingTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbPingTarget.Location = new Point(12, 38);
            txbPingTarget.Name = "txbPingTarget";
            txbPingTarget.Size = new Size(284, 27);
            txbPingTarget.TabIndex = 1;
            // 
            // pnlData
            // 
            pnlData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlData.Dock = DockStyle.Right;
            pnlData.Location = new Point(338, 0);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(473, 441);
            pnlData.TabIndex = 3;
            // 
            // pnlMiddle
            // 
            pnlMiddle.Controls.Add(pnlData);
            pnlMiddle.Controls.Add(pnlControls);
            pnlMiddle.Dock = DockStyle.Fill;
            pnlMiddle.Location = new Point(0, 143);
            pnlMiddle.Name = "pnlMiddle";
            pnlMiddle.Size = new Size(811, 441);
            pnlMiddle.TabIndex = 1;
            // 
            // lblPacketSize
            // 
            lblPacketSize.AutoSize = true;
            lblPacketSize.Font = new Font("Calibri", 10.2F);
            lblPacketSize.ForeColor = SystemColors.ActiveCaptionText;
            lblPacketSize.Location = new Point(12, 258);
            lblPacketSize.Name = "lblPacketSize";
            lblPacketSize.Size = new Size(138, 21);
            lblPacketSize.TabIndex = 16;
            lblPacketSize.Text = "Packet Size (bytes)";
            // 
            // nudPacketSize
            // 
            nudPacketSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudPacketSize.Location = new Point(229, 256);
            nudPacketSize.Name = "nudPacketSize";
            nudPacketSize.Size = new Size(67, 27);
            nudPacketSize.TabIndex = 17;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(811, 584);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)nudPacketSize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
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
        private PictureBox pictureBox1;
        private NumericUpDown nudPacketSize;
        private Label lblPacketSize;

        public string PingTarget { get => txbPingTarget.Text; }
        public string Mode { get => cmbMode.Text; }
        public int RefreshRate { get => (int)nudRefreshRate.Value; }
        public bool InfiniteLoop { get => chbInfiniteLoop.Checked; }
        public int NumberOfPR { get => (int)nudNumberOfPR.Value; }
        public int Attempts { get => (int)nudAttempts.Value; }
        public int PacketSize { get => (int)nudPacketSize.Value; }
    }
}
