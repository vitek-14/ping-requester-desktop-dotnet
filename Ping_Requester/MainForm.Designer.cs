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
            btnSendRequest = new Button();
            lblNumberOfTries = new Label();
            lblNumberOfPR = new Label();
            chbInfiniteLoop = new CheckBox();
            nudNumberOfTries = new NumericUpDown();
            nudNumberOfPR = new NumericUpDown();
            nudSpaceBetweenPR = new NumericUpDown();
            label2 = new Label();
            lblWhenSuccess = new Label();
            chbShowNotification = new CheckBox();
            chbMakeSound = new CheckBox();
            lblPingTarget = new Label();
            txbPingTarget = new TextBox();
            pnlData = new Panel();
            pnlMiddle = new Panel();
            btnStop = new Button();
            pnlTop.SuspendLayout();
            menuStrip1.SuspendLayout();
            pnlInfo.SuspendLayout();
            pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfTries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfPR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSpaceBetweenPR).BeginInit();
            pnlMiddle.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlTop.Controls.Add(lblPingRequester);
            pnlTop.Controls.Add(menuStrip1);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(811, 77);
            pnlTop.TabIndex = 0;
            // 
            // lblPingRequester
            // 
            lblPingRequester.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPingRequester.AutoSize = true;
            lblPingRequester.Font = new Font("Calibri", 24F);
            lblPingRequester.ForeColor = SystemColors.HotTrack;
            lblPingRequester.Location = new Point(272, 21);
            lblPingRequester.Name = "lblPingRequester";
            lblPingRequester.Size = new Size(267, 49);
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
            // 
            // pnlInfo
            // 
            pnlInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlInfo.Controls.Add(lblInfo);
            pnlInfo.Dock = DockStyle.Bottom;
            pnlInfo.Location = new Point(0, 453);
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
            pnlControls.Controls.Add(btnStop);
            pnlControls.Controls.Add(btnSendRequest);
            pnlControls.Controls.Add(lblNumberOfTries);
            pnlControls.Controls.Add(lblNumberOfPR);
            pnlControls.Controls.Add(chbInfiniteLoop);
            pnlControls.Controls.Add(nudNumberOfTries);
            pnlControls.Controls.Add(nudNumberOfPR);
            pnlControls.Controls.Add(nudSpaceBetweenPR);
            pnlControls.Controls.Add(label2);
            pnlControls.Controls.Add(lblWhenSuccess);
            pnlControls.Controls.Add(chbShowNotification);
            pnlControls.Controls.Add(chbMakeSound);
            pnlControls.Controls.Add(lblPingTarget);
            pnlControls.Controls.Add(txbPingTarget);
            pnlControls.Dock = DockStyle.Left;
            pnlControls.Location = new Point(0, 0);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new Size(386, 406);
            pnlControls.TabIndex = 2;
            // 
            // btnSendRequest
            // 
            btnSendRequest.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnSendRequest.ForeColor = SystemColors.Highlight;
            btnSendRequest.Location = new Point(32, 248);
            btnSendRequest.Name = "btnSendRequest";
            btnSendRequest.Size = new Size(149, 36);
            btnSendRequest.TabIndex = 12;
            btnSendRequest.Text = "Send Request";
            btnSendRequest.UseVisualStyleBackColor = true;
            btnSendRequest.Click += btnSendRequest_Click;
            // 
            // lblNumberOfTries
            // 
            lblNumberOfTries.Anchor = AnchorStyles.Left;
            lblNumberOfTries.AutoSize = true;
            lblNumberOfTries.Font = new Font("Calibri", 10.2F);
            lblNumberOfTries.ForeColor = SystemColors.ActiveCaptionText;
            lblNumberOfTries.Location = new Point(12, 210);
            lblNumberOfTries.Name = "lblNumberOfTries";
            lblNumberOfTries.Size = new Size(120, 21);
            lblNumberOfTries.TabIndex = 11;
            lblNumberOfTries.Text = "Number of tries";
            // 
            // lblNumberOfPR
            // 
            lblNumberOfPR.AutoSize = true;
            lblNumberOfPR.Font = new Font("Calibri", 10.2F);
            lblNumberOfPR.ForeColor = SystemColors.ActiveCaptionText;
            lblNumberOfPR.Location = new Point(12, 132);
            lblNumberOfPR.Name = "lblNumberOfPR";
            lblNumberOfPR.Size = new Size(183, 21);
            lblNumberOfPR.TabIndex = 4;
            lblNumberOfPR.Text = "Number of ping requests";
            // 
            // chbInfiniteLoop
            // 
            chbInfiniteLoop.AutoSize = true;
            chbInfiniteLoop.Font = new Font("Calibri", 10.2F);
            chbInfiniteLoop.ForeColor = SystemColors.ActiveCaptionText;
            chbInfiniteLoop.Location = new Point(12, 174);
            chbInfiniteLoop.Name = "chbInfiniteLoop";
            chbInfiniteLoop.Size = new Size(116, 25);
            chbInfiniteLoop.TabIndex = 2;
            chbInfiniteLoop.Text = "Infinite loop";
            chbInfiniteLoop.UseVisualStyleBackColor = true;
            chbInfiniteLoop.Click += chbInfiniteLoop_Click;
            // 
            // nudNumberOfTries
            // 
            nudNumberOfTries.Anchor = AnchorStyles.Left;
            nudNumberOfTries.Location = new Point(285, 208);
            nudNumberOfTries.Name = "nudNumberOfTries";
            nudNumberOfTries.Size = new Size(65, 27);
            nudNumberOfTries.TabIndex = 10;
            // 
            // nudNumberOfPR
            // 
            nudNumberOfPR.Location = new Point(285, 130);
            nudNumberOfPR.Name = "nudNumberOfPR";
            nudNumberOfPR.Size = new Size(65, 27);
            nudNumberOfPR.TabIndex = 3;
            // 
            // nudSpaceBetweenPR
            // 
            nudSpaceBetweenPR.Location = new Point(285, 93);
            nudSpaceBetweenPR.Name = "nudSpaceBetweenPR";
            nudSpaceBetweenPR.Size = new Size(65, 27);
            nudSpaceBetweenPR.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(199, 21);
            label2.TabIndex = 8;
            label2.Text = "Space between requests (s)";
            // 
            // lblWhenSuccess
            // 
            lblWhenSuccess.AutoSize = true;
            lblWhenSuccess.Font = new Font("Calibri", 10.2F);
            lblWhenSuccess.ForeColor = SystemColors.ActiveCaptionText;
            lblWhenSuccess.Location = new Point(12, 294);
            lblWhenSuccess.Name = "lblWhenSuccess";
            lblWhenSuccess.Size = new Size(112, 21);
            lblWhenSuccess.TabIndex = 7;
            lblWhenSuccess.Text = "When success:";
            // 
            // chbShowNotification
            // 
            chbShowNotification.AutoSize = true;
            chbShowNotification.Font = new Font("Calibri", 10.2F);
            chbShowNotification.ForeColor = SystemColors.ActiveCaptionText;
            chbShowNotification.Location = new Point(12, 326);
            chbShowNotification.Name = "chbShowNotification";
            chbShowNotification.Size = new Size(152, 25);
            chbShowNotification.TabIndex = 6;
            chbShowNotification.Text = "Show notification";
            chbShowNotification.UseVisualStyleBackColor = true;
            // 
            // chbMakeSound
            // 
            chbMakeSound.AutoSize = true;
            chbMakeSound.Font = new Font("Calibri", 10.2F);
            chbMakeSound.ForeColor = SystemColors.ActiveCaptionText;
            chbMakeSound.Location = new Point(223, 326);
            chbMakeSound.Name = "chbMakeSound";
            chbMakeSound.Size = new Size(117, 25);
            chbMakeSound.TabIndex = 5;
            chbMakeSound.Text = "Make sound";
            chbMakeSound.UseVisualStyleBackColor = true;
            // 
            // lblPingTarget
            // 
            lblPingTarget.AutoSize = true;
            lblPingTarget.Font = new Font("Calibri", 10.2F);
            lblPingTarget.ForeColor = SystemColors.ActiveCaptionText;
            lblPingTarget.Location = new Point(12, 21);
            lblPingTarget.Name = "lblPingTarget";
            lblPingTarget.Size = new Size(86, 21);
            lblPingTarget.TabIndex = 0;
            lblPingTarget.Text = "Ping target";
            // 
            // txbPingTarget
            // 
            txbPingTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbPingTarget.Location = new Point(12, 48);
            txbPingTarget.Name = "txbPingTarget";
            txbPingTarget.Size = new Size(338, 27);
            txbPingTarget.TabIndex = 1;
            // 
            // pnlData
            // 
            pnlData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlData.Dock = DockStyle.Right;
            pnlData.Location = new Point(392, 0);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(417, 406);
            pnlData.TabIndex = 3;
            // 
            // pnlMiddle
            // 
            pnlMiddle.BorderStyle = BorderStyle.FixedSingle;
            pnlMiddle.Controls.Add(pnlData);
            pnlMiddle.Controls.Add(pnlControls);
            pnlMiddle.Dock = DockStyle.Fill;
            pnlMiddle.Location = new Point(0, 77);
            pnlMiddle.Name = "pnlMiddle";
            pnlMiddle.Size = new Size(811, 408);
            pnlMiddle.TabIndex = 1;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnStop.ForeColor = Color.IndianRed;
            btnStop.Location = new Point(223, 248);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(86, 36);
            btnStop.TabIndex = 13;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(811, 485);
            Controls.Add(pnlInfo);
            Controls.Add(pnlMiddle);
            Controls.Add(pnlTop);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            pnlControls.ResumeLayout(false);
            pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfTries).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfPR).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSpaceBetweenPR).EndInit();
            pnlMiddle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Label lblPingRequester;
        private Panel pnlInfo;
        private Label lblInfo;
        private Panel pnlControls;
        private Label lblNumberOfTries;
        private Label lblNumberOfPR;
        private CheckBox chbInfiniteLoop;
        private NumericUpDown nudNumberOfTries;
        private NumericUpDown nudNumberOfPR;
        private NumericUpDown nudSpaceBetweenPR;
        private Label label2;
        private Label lblWhenSuccess;
        private CheckBox chbShowNotification;
        private CheckBox chbMakeSound;
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
    }
}
