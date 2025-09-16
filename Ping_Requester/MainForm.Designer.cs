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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlTop = new Panel();
            pictureBox1 = new PictureBox();
            lblLineSeparator = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem1 = new ToolStripMenuItem();
            preferencesToolStripMenuItem = new ToolStripMenuItem();
            pnlInfo = new Panel();
            lblInfo = new Label();
            pnlControls = new Panel();
            chbStopWhenSuccess = new CheckBox();
            nudPacketSize = new NumericUpDown();
            lblPacketSize = new Label();
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
            tbc = new TabControl();
            tbpRequestRun = new TabPage();
            btnCopyIPAddress = new Button();
            btnCopyPinging = new Button();
            grbRoundTripTimes = new GroupBox();
            lblAverageActive = new Label();
            lblAverage = new Label();
            lblMinimumActive = new Label();
            lblMinimum = new Label();
            lblMaximumActive = new Label();
            lblMaximum = new Label();
            grbPackets = new GroupBox();
            lblLostActive = new Label();
            lblLost = new Label();
            lblRecievedActive = new Label();
            lblRecieved = new Label();
            lblSentActive = new Label();
            lblSent = new Label();
            lblPacketSizeRRActive = new Label();
            lblPacketSizeRR = new Label();
            lblIpAddressActive = new Label();
            lblIpAddress = new Label();
            lblPingingActive = new Label();
            lblPinging = new Label();
            tbpDatabase = new TabPage();
            tbpOutput = new TabPage();
            btnClear = new Button();
            rtbConsole = new RichTextBox();
            pnlMiddle = new Panel();
            ttpMainForm = new ToolTip(components);
            btnSaveLog = new Button();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            pnlInfo.SuspendLayout();
            pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPacketSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfPR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAttempts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRefreshRate).BeginInit();
            pnlData.SuspendLayout();
            tbc.SuspendLayout();
            tbpRequestRun.SuspendLayout();
            grbRoundTripTimes.SuspendLayout();
            grbPackets.SuspendLayout();
            tbpOutput.SuspendLayout();
            pnlMiddle.SuspendLayout();
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
            pnlTop.Size = new Size(951, 143);
            pnlTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Ping_Requester_Poster_6;
            pictureBox1.Location = new Point(0, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(951, 104);
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
            lblLineSeparator.Size = new Size(940, 2);
            lblLineSeparator.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(951, 28);
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
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem1, preferencesToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(58, 24);
            settingsToolStripMenuItem.Text = "Tools";
            // 
            // settingsToolStripMenuItem1
            // 
            settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            settingsToolStripMenuItem1.Size = new Size(168, 26);
            settingsToolStripMenuItem1.Text = "Settings";
            settingsToolStripMenuItem1.Click += settingsToolStripMenuItem1_Click;
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
            pnlInfo.Location = new Point(0, 593);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(951, 32);
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
            pnlControls.Controls.Add(chbStopWhenSuccess);
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
            pnlControls.Size = new Size(332, 482);
            pnlControls.TabIndex = 2;
            // 
            // chbStopWhenSuccess
            // 
            chbStopWhenSuccess.AutoSize = true;
            chbStopWhenSuccess.Font = new Font("Calibri", 10.2F);
            chbStopWhenSuccess.ForeColor = SystemColors.ActiveCaptionText;
            chbStopWhenSuccess.Location = new Point(150, 146);
            chbStopWhenSuccess.Name = "chbStopWhenSuccess";
            chbStopWhenSuccess.Size = new Size(162, 25);
            chbStopWhenSuccess.TabIndex = 18;
            chbStopWhenSuccess.Text = "Stop when success";
            ttpMainForm.SetToolTip(chbStopWhenSuccess, "If checked, requesting will stop.\r\nThis function is allowed only when infinite loop is enabled.");
            chbStopWhenSuccess.UseVisualStyleBackColor = true;
            // 
            // nudPacketSize
            // 
            nudPacketSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudPacketSize.Location = new Point(245, 256);
            nudPacketSize.Maximum = new decimal(new int[] { 65500, 0, 0, 0 });
            nudPacketSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPacketSize.Name = "nudPacketSize";
            nudPacketSize.Size = new Size(67, 27);
            nudPacketSize.TabIndex = 17;
            nudPacketSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            ttpMainForm.SetToolTip(lblPacketSize, "If the packet exceeds the maximum transmission unit, it will be automatically fragmented.");
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
            nudNumberOfPR.Location = new Point(245, 181);
            nudNumberOfPR.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudNumberOfPR.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNumberOfPR.Name = "nudNumberOfPR";
            nudNumberOfPR.Size = new Size(67, 27);
            nudNumberOfPR.TabIndex = 3;
            nudNumberOfPR.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbMode
            // 
            cmbMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMode.FormattingEnabled = true;
            cmbMode.Location = new Point(188, 74);
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
            ttpMainForm.SetToolTip(lblMode, "Mode determines wheter to reset attempts counter after successful connection or not.\r\nAggressive - does not reset attempts counter\r\nPrecise - does reset attempt counter");
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnStop.ForeColor = Color.IndianRed;
            btnStop.Location = new Point(208, 352);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(93, 36);
            btnStop.TabIndex = 13;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnSendRequest
            // 
            btnSendRequest.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnSendRequest.ForeColor = SystemColors.Highlight;
            btnSendRequest.Location = new Point(35, 352);
            btnSendRequest.Name = "btnSendRequest";
            btnSendRequest.Size = new Size(146, 36);
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
            nudAttempts.Location = new Point(245, 218);
            nudAttempts.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAttempts.Name = "nudAttempts";
            nudAttempts.Size = new Size(67, 27);
            nudAttempts.TabIndex = 10;
            // 
            // nudRefreshRate
            // 
            nudRefreshRate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudRefreshRate.Location = new Point(245, 111);
            nudRefreshRate.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
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
            ttpMainForm.SetToolTip(lblRefreshRate, "Elapsed time in seconds between individual requests.");
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
            ttpMainForm.SetToolTip(lblPingTarget, "Can be URL or IPv4 address.");
            // 
            // txbPingTarget
            // 
            txbPingTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbPingTarget.Location = new Point(12, 38);
            txbPingTarget.Name = "txbPingTarget";
            txbPingTarget.Size = new Size(300, 27);
            txbPingTarget.TabIndex = 1;
            txbPingTarget.TextChanged += txbPingTarget_TextChanged;
            // 
            // pnlData
            // 
            pnlData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlData.Controls.Add(tbc);
            pnlData.Location = new Point(338, 0);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(613, 482);
            pnlData.TabIndex = 3;
            // 
            // tbc
            // 
            tbc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbc.Controls.Add(tbpRequestRun);
            tbc.Controls.Add(tbpDatabase);
            tbc.Controls.Add(tbpOutput);
            tbc.Location = new Point(3, 3);
            tbc.Name = "tbc";
            tbc.SelectedIndex = 0;
            tbc.Size = new Size(604, 441);
            tbc.TabIndex = 0;
            tbc.SelectedIndexChanged += tbc_SelectedIndexChanged;
            // 
            // tbpRequestRun
            // 
            tbpRequestRun.Controls.Add(btnCopyIPAddress);
            tbpRequestRun.Controls.Add(btnCopyPinging);
            tbpRequestRun.Controls.Add(grbRoundTripTimes);
            tbpRequestRun.Controls.Add(grbPackets);
            tbpRequestRun.Controls.Add(lblPacketSizeRRActive);
            tbpRequestRun.Controls.Add(lblPacketSizeRR);
            tbpRequestRun.Controls.Add(lblIpAddressActive);
            tbpRequestRun.Controls.Add(lblIpAddress);
            tbpRequestRun.Controls.Add(lblPingingActive);
            tbpRequestRun.Controls.Add(lblPinging);
            tbpRequestRun.Location = new Point(4, 29);
            tbpRequestRun.Name = "tbpRequestRun";
            tbpRequestRun.Padding = new Padding(3);
            tbpRequestRun.Size = new Size(596, 408);
            tbpRequestRun.TabIndex = 0;
            tbpRequestRun.Text = "Request Run";
            tbpRequestRun.UseVisualStyleBackColor = true;
            // 
            // btnCopyIPAddress
            // 
            btnCopyIPAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopyIPAddress.BackgroundImage = Properties.Resources.copy_to_clipboard;
            btnCopyIPAddress.BackgroundImageLayout = ImageLayout.Zoom;
            btnCopyIPAddress.FlatAppearance.BorderSize = 0;
            btnCopyIPAddress.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCopyIPAddress.FlatStyle = FlatStyle.Flat;
            btnCopyIPAddress.Location = new Point(535, 43);
            btnCopyIPAddress.Name = "btnCopyIPAddress";
            btnCopyIPAddress.Size = new Size(37, 28);
            btnCopyIPAddress.TabIndex = 15;
            ttpMainForm.SetToolTip(btnCopyIPAddress, "Copy");
            btnCopyIPAddress.UseVisualStyleBackColor = true;
            btnCopyIPAddress.Click += btnCopyIPAddress_Click;
            // 
            // btnCopyPinging
            // 
            btnCopyPinging.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopyPinging.BackgroundImage = Properties.Resources.copy_to_clipboard;
            btnCopyPinging.BackgroundImageLayout = ImageLayout.Zoom;
            btnCopyPinging.FlatAppearance.BorderSize = 0;
            btnCopyPinging.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCopyPinging.FlatStyle = FlatStyle.Flat;
            btnCopyPinging.Location = new Point(535, 15);
            btnCopyPinging.Name = "btnCopyPinging";
            btnCopyPinging.Size = new Size(37, 28);
            btnCopyPinging.TabIndex = 14;
            ttpMainForm.SetToolTip(btnCopyPinging, "Copy");
            btnCopyPinging.UseVisualStyleBackColor = true;
            btnCopyPinging.Click += btnCopyPinging_Click;
            // 
            // grbRoundTripTimes
            // 
            grbRoundTripTimes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grbRoundTripTimes.Controls.Add(lblAverageActive);
            grbRoundTripTimes.Controls.Add(lblAverage);
            grbRoundTripTimes.Controls.Add(lblMinimumActive);
            grbRoundTripTimes.Controls.Add(lblMinimum);
            grbRoundTripTimes.Controls.Add(lblMaximumActive);
            grbRoundTripTimes.Controls.Add(lblMaximum);
            grbRoundTripTimes.Location = new Point(18, 233);
            grbRoundTripTimes.Name = "grbRoundTripTimes";
            grbRoundTripTimes.Size = new Size(554, 125);
            grbRoundTripTimes.TabIndex = 13;
            grbRoundTripTimes.TabStop = false;
            grbRoundTripTimes.Text = "Approximate round trip times";
            // 
            // lblAverageActive
            // 
            lblAverageActive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAverageActive.AutoSize = true;
            lblAverageActive.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblAverageActive.ForeColor = SystemColors.ActiveCaptionText;
            lblAverageActive.Location = new Point(321, 88);
            lblAverageActive.Name = "lblAverageActive";
            lblAverageActive.Size = new Size(40, 21);
            lblAverageActive.TabIndex = 12;
            lblAverageActive.Text = "- ms";
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblAverage.ForeColor = SystemColors.ActiveCaptionText;
            lblAverage.Location = new Point(6, 88);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(71, 21);
            lblAverage.TabIndex = 11;
            lblAverage.Text = "Average:";
            // 
            // lblMinimumActive
            // 
            lblMinimumActive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMinimumActive.AutoSize = true;
            lblMinimumActive.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblMinimumActive.ForeColor = SystemColors.ActiveCaptionText;
            lblMinimumActive.Location = new Point(321, 59);
            lblMinimumActive.Name = "lblMinimumActive";
            lblMinimumActive.Size = new Size(40, 21);
            lblMinimumActive.TabIndex = 10;
            lblMinimumActive.Text = "- ms";
            // 
            // lblMinimum
            // 
            lblMinimum.AutoSize = true;
            lblMinimum.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblMinimum.ForeColor = SystemColors.ActiveCaptionText;
            lblMinimum.Location = new Point(6, 59);
            lblMinimum.Name = "lblMinimum";
            lblMinimum.Size = new Size(84, 21);
            lblMinimum.TabIndex = 9;
            lblMinimum.Text = "Minimum:";
            // 
            // lblMaximumActive
            // 
            lblMaximumActive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMaximumActive.AutoSize = true;
            lblMaximumActive.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblMaximumActive.ForeColor = SystemColors.ActiveCaptionText;
            lblMaximumActive.Location = new Point(321, 31);
            lblMaximumActive.Name = "lblMaximumActive";
            lblMaximumActive.Size = new Size(40, 21);
            lblMaximumActive.TabIndex = 8;
            lblMaximumActive.Text = "- ms";
            // 
            // lblMaximum
            // 
            lblMaximum.AutoSize = true;
            lblMaximum.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblMaximum.ForeColor = SystemColors.ActiveCaptionText;
            lblMaximum.Location = new Point(6, 31);
            lblMaximum.Name = "lblMaximum";
            lblMaximum.Size = new Size(81, 21);
            lblMaximum.TabIndex = 7;
            lblMaximum.Text = "Maximum";
            // 
            // grbPackets
            // 
            grbPackets.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grbPackets.Controls.Add(lblLostActive);
            grbPackets.Controls.Add(lblLost);
            grbPackets.Controls.Add(lblRecievedActive);
            grbPackets.Controls.Add(lblRecieved);
            grbPackets.Controls.Add(lblSentActive);
            grbPackets.Controls.Add(lblSent);
            grbPackets.Location = new Point(18, 103);
            grbPackets.Name = "grbPackets";
            grbPackets.Size = new Size(554, 125);
            grbPackets.TabIndex = 6;
            grbPackets.TabStop = false;
            grbPackets.Text = "Packets";
            // 
            // lblLostActive
            // 
            lblLostActive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLostActive.AutoSize = true;
            lblLostActive.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblLostActive.ForeColor = SystemColors.ActiveCaptionText;
            lblLostActive.Location = new Point(321, 88);
            lblLostActive.Name = "lblLostActive";
            lblLostActive.Size = new Size(15, 21);
            lblLostActive.TabIndex = 12;
            lblLostActive.Text = "-";
            // 
            // lblLost
            // 
            lblLost.AutoSize = true;
            lblLost.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblLost.ForeColor = SystemColors.ActiveCaptionText;
            lblLost.Location = new Point(6, 88);
            lblLost.Name = "lblLost";
            lblLost.Size = new Size(44, 21);
            lblLost.TabIndex = 11;
            lblLost.Text = "Lost:";
            // 
            // lblRecievedActive
            // 
            lblRecievedActive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRecievedActive.AutoSize = true;
            lblRecievedActive.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblRecievedActive.ForeColor = SystemColors.ActiveCaptionText;
            lblRecievedActive.Location = new Point(321, 59);
            lblRecievedActive.Name = "lblRecievedActive";
            lblRecievedActive.Size = new Size(15, 21);
            lblRecievedActive.TabIndex = 10;
            lblRecievedActive.Text = "-";
            // 
            // lblRecieved
            // 
            lblRecieved.AutoSize = true;
            lblRecieved.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblRecieved.ForeColor = SystemColors.ActiveCaptionText;
            lblRecieved.Location = new Point(6, 59);
            lblRecieved.Name = "lblRecieved";
            lblRecieved.Size = new Size(76, 21);
            lblRecieved.TabIndex = 9;
            lblRecieved.Text = "Recieved:";
            // 
            // lblSentActive
            // 
            lblSentActive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSentActive.AutoSize = true;
            lblSentActive.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblSentActive.ForeColor = SystemColors.ActiveCaptionText;
            lblSentActive.Location = new Point(321, 31);
            lblSentActive.Name = "lblSentActive";
            lblSentActive.Size = new Size(15, 21);
            lblSentActive.TabIndex = 8;
            lblSentActive.Text = "-";
            // 
            // lblSent
            // 
            lblSent.AutoSize = true;
            lblSent.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblSent.ForeColor = SystemColors.ActiveCaptionText;
            lblSent.Location = new Point(6, 31);
            lblSent.Name = "lblSent";
            lblSent.Size = new Size(46, 21);
            lblSent.TabIndex = 7;
            lblSent.Text = "Sent:";
            // 
            // lblPacketSizeRRActive
            // 
            lblPacketSizeRRActive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPacketSizeRRActive.AutoSize = true;
            lblPacketSizeRRActive.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblPacketSizeRRActive.ForeColor = SystemColors.ActiveCaptionText;
            lblPacketSizeRRActive.Location = new Point(339, 75);
            lblPacketSizeRRActive.Name = "lblPacketSizeRRActive";
            lblPacketSizeRRActive.Size = new Size(15, 21);
            lblPacketSizeRRActive.TabIndex = 5;
            lblPacketSizeRRActive.Text = "-";
            // 
            // lblPacketSizeRR
            // 
            lblPacketSizeRR.AutoSize = true;
            lblPacketSizeRR.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblPacketSizeRR.ForeColor = SystemColors.ActiveCaptionText;
            lblPacketSizeRR.Location = new Point(18, 73);
            lblPacketSizeRR.Name = "lblPacketSizeRR";
            lblPacketSizeRR.Size = new Size(142, 21);
            lblPacketSizeRR.TabIndex = 4;
            lblPacketSizeRR.Text = "Packet size (bytes):";
            // 
            // lblIpAddressActive
            // 
            lblIpAddressActive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIpAddressActive.AutoSize = true;
            lblIpAddressActive.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblIpAddressActive.ForeColor = SystemColors.ActiveCaptionText;
            lblIpAddressActive.Location = new Point(339, 47);
            lblIpAddressActive.Name = "lblIpAddressActive";
            lblIpAddressActive.Size = new Size(15, 21);
            lblIpAddressActive.TabIndex = 3;
            lblIpAddressActive.Text = "-";
            // 
            // lblIpAddress
            // 
            lblIpAddress.AutoSize = true;
            lblIpAddress.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblIpAddress.ForeColor = SystemColors.ActiveCaptionText;
            lblIpAddress.Location = new Point(18, 45);
            lblIpAddress.Name = "lblIpAddress";
            lblIpAddress.Size = new Size(86, 21);
            lblIpAddress.TabIndex = 2;
            lblIpAddress.Text = "IP address:";
            // 
            // lblPingingActive
            // 
            lblPingingActive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPingingActive.AutoSize = true;
            lblPingingActive.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblPingingActive.ForeColor = SystemColors.ActiveCaptionText;
            lblPingingActive.Location = new Point(339, 17);
            lblPingingActive.Name = "lblPingingActive";
            lblPingingActive.Size = new Size(15, 21);
            lblPingingActive.TabIndex = 1;
            lblPingingActive.Text = "-";
            // 
            // lblPinging
            // 
            lblPinging.AutoSize = true;
            lblPinging.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblPinging.ForeColor = SystemColors.ActiveCaptionText;
            lblPinging.Location = new Point(18, 15);
            lblPinging.Name = "lblPinging";
            lblPinging.Size = new Size(66, 21);
            lblPinging.TabIndex = 0;
            lblPinging.Text = "Pinging:";
            ttpMainForm.SetToolTip(lblPinging, "Hostname returned by DNS server.");
            // 
            // tbpDatabase
            // 
            tbpDatabase.Location = new Point(4, 29);
            tbpDatabase.Name = "tbpDatabase";
            tbpDatabase.Padding = new Padding(3);
            tbpDatabase.Size = new Size(596, 408);
            tbpDatabase.TabIndex = 1;
            tbpDatabase.Text = "Database";
            tbpDatabase.UseVisualStyleBackColor = true;
            // 
            // tbpOutput
            // 
            tbpOutput.Controls.Add(btnSaveLog);
            tbpOutput.Controls.Add(btnClear);
            tbpOutput.Controls.Add(rtbConsole);
            tbpOutput.Location = new Point(4, 29);
            tbpOutput.Name = "tbpOutput";
            tbpOutput.Padding = new Padding(3);
            tbpOutput.Size = new Size(596, 408);
            tbpOutput.TabIndex = 2;
            tbpOutput.Text = "Output";
            tbpOutput.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(483, 374);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 28);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // rtbConsole
            // 
            rtbConsole.BackColor = Color.Black;
            rtbConsole.Dock = DockStyle.Top;
            rtbConsole.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rtbConsole.ForeColor = Color.White;
            rtbConsole.Location = new Point(3, 3);
            rtbConsole.Name = "rtbConsole";
            rtbConsole.ReadOnly = true;
            rtbConsole.Size = new Size(590, 365);
            rtbConsole.TabIndex = 0;
            rtbConsole.Text = "";
            // 
            // pnlMiddle
            // 
            pnlMiddle.Controls.Add(pnlData);
            pnlMiddle.Controls.Add(pnlControls);
            pnlMiddle.Dock = DockStyle.Fill;
            pnlMiddle.Location = new Point(0, 143);
            pnlMiddle.Name = "pnlMiddle";
            pnlMiddle.Size = new Size(951, 482);
            pnlMiddle.TabIndex = 1;
            // 
            // btnSaveLog
            // 
            btnSaveLog.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnSaveLog.ForeColor = Color.Black;
            btnSaveLog.Location = new Point(360, 374);
            btnSaveLog.Name = "btnSaveLog";
            btnSaveLog.Size = new Size(107, 28);
            btnSaveLog.TabIndex = 20;
            btnSaveLog.Text = "Save log";
            btnSaveLog.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(951, 625);
            Controls.Add(pnlInfo);
            Controls.Add(pnlMiddle);
            Controls.Add(pnlTop);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
            ((System.ComponentModel.ISupportInitialize)nudPacketSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfPR).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAttempts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRefreshRate).EndInit();
            pnlData.ResumeLayout(false);
            tbc.ResumeLayout(false);
            tbpRequestRun.ResumeLayout(false);
            tbpRequestRun.PerformLayout();
            grbRoundTripTimes.ResumeLayout(false);
            grbRoundTripTimes.PerformLayout();
            grbPackets.ResumeLayout(false);
            grbPackets.PerformLayout();
            tbpOutput.ResumeLayout(false);
            pnlMiddle.ResumeLayout(false);
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
        private TabControl tbc;
        private TabPage tbpRequestRun;
        private TabPage tbpDatabase;
        private TabPage tbpOutput;
        private Label lblPacketSizeRRActive;
        private Label lblPacketSizeRR;
        private Label lblIpAddressActive;
        private Label lblIpAddress;
        private Label lblPingingActive;
        private Label lblPinging;
        private GroupBox grbPackets;
        private Label lblLostActive;
        private Label lblLost;
        private Label lblRecievedActive;
        private Label lblRecieved;
        private Label lblSentActive;
        private Label lblSent;
        private GroupBox grbRoundTripTimes;
        private Label lblAverageActive;
        private Label lblAverage;
        private Label lblMinimumActive;
        private Label lblMinimum;
        private Label lblMaximumActive;
        private Label lblMaximum;
        private RichTextBox rtbConsole;
        private CheckBox chbStopWhenSuccess;
        private ToolStripMenuItem settingsToolStripMenuItem1;
        private ToolTip ttpMainForm;
        private Button btnCopyPinging;
        private Button btnCopyIPAddress;
        private Button btnClear;
        private Button btnSaveLog;

        public string PingTarget { get => txbPingTarget.Text; }
        public string Mode { get => cmbMode.Text; }
        public int RefreshRate { get => (int)nudRefreshRate.Value; }
        public bool InfiniteLoop { get => chbInfiniteLoop.Checked; }
        public bool StopWhenSuccess { get => chbStopWhenSuccess.Checked; }
        public int NumberOfPR { get => (int)nudNumberOfPR.Value; }
        public int Attempts { get => (int)nudAttempts.Value; }
        public int PacketSize { get => (int)nudPacketSize.Value; }
    }
}
