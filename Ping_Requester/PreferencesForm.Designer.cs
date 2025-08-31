namespace PingRequester.Client
{
    partial class PreferencesForm
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
            lblPingTarget = new Label();
            txbPingTarget = new TextBox();
            cmbMode = new ComboBox();
            lblMode = new Label();
            lblNumberOfPR = new Label();
            nudNumberOfPR = new NumericUpDown();
            lblAttempts = new Label();
            chbInfiniteLoop = new CheckBox();
            nudAttempts = new NumericUpDown();
            nudRefreshRate = new NumericUpDown();
            lblRefreshRate = new Label();
            chbShowNotification = new CheckBox();
            chbMakeSound = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            nudPacketSize = new NumericUpDown();
            lblPacketSize = new Label();
            lblLineSeparator = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfPR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAttempts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRefreshRate).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPacketSize).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblPingTarget
            // 
            lblPingTarget.AutoSize = true;
            lblPingTarget.Font = new Font("Calibri", 10.2F);
            lblPingTarget.ForeColor = SystemColors.ActiveCaptionText;
            lblPingTarget.Location = new Point(18, 17);
            lblPingTarget.Name = "lblPingTarget";
            lblPingTarget.Size = new Size(86, 21);
            lblPingTarget.TabIndex = 2;
            lblPingTarget.Text = "Ping target";
            // 
            // txbPingTarget
            // 
            txbPingTarget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txbPingTarget.Location = new Point(129, 13);
            txbPingTarget.Name = "txbPingTarget";
            txbPingTarget.Size = new Size(205, 27);
            txbPingTarget.TabIndex = 3;
            // 
            // cmbMode
            // 
            cmbMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMode.FormattingEnabled = true;
            cmbMode.Location = new Point(213, 49);
            cmbMode.Name = "cmbMode";
            cmbMode.Size = new Size(122, 28);
            cmbMode.TabIndex = 17;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Calibri", 10.2F);
            lblMode.ForeColor = SystemColors.ActiveCaptionText;
            lblMode.Location = new Point(18, 52);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(51, 21);
            lblMode.TabIndex = 16;
            lblMode.Text = "Mode";
            // 
            // lblNumberOfPR
            // 
            lblNumberOfPR.AutoSize = true;
            lblNumberOfPR.Font = new Font("Calibri", 10.2F);
            lblNumberOfPR.ForeColor = SystemColors.ActiveCaptionText;
            lblNumberOfPR.Location = new Point(18, 122);
            lblNumberOfPR.Name = "lblNumberOfPR";
            lblNumberOfPR.Size = new Size(183, 21);
            lblNumberOfPR.TabIndex = 20;
            lblNumberOfPR.Text = "Number of ping requests";
            // 
            // nudNumberOfPR
            // 
            nudNumberOfPR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudNumberOfPR.Location = new Point(270, 120);
            nudNumberOfPR.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudNumberOfPR.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNumberOfPR.Name = "nudNumberOfPR";
            nudNumberOfPR.Size = new Size(65, 27);
            nudNumberOfPR.TabIndex = 19;
            nudNumberOfPR.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblAttempts
            // 
            lblAttempts.AutoSize = true;
            lblAttempts.Font = new Font("Calibri", 10.2F);
            lblAttempts.ForeColor = SystemColors.ActiveCaptionText;
            lblAttempts.Location = new Point(18, 155);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(75, 21);
            lblAttempts.TabIndex = 24;
            lblAttempts.Text = "Attempts";
            // 
            // chbInfiniteLoop
            // 
            chbInfiniteLoop.AutoSize = true;
            chbInfiniteLoop.Font = new Font("Calibri", 10.2F);
            chbInfiniteLoop.ForeColor = SystemColors.ActiveCaptionText;
            chbInfiniteLoop.Location = new Point(18, 291);
            chbInfiniteLoop.Name = "chbInfiniteLoop";
            chbInfiniteLoop.Size = new Size(116, 25);
            chbInfiniteLoop.TabIndex = 18;
            chbInfiniteLoop.Text = "Infinite loop";
            chbInfiniteLoop.UseVisualStyleBackColor = true;
            // 
            // nudAttempts
            // 
            nudAttempts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudAttempts.Location = new Point(270, 157);
            nudAttempts.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAttempts.Name = "nudAttempts";
            nudAttempts.Size = new Size(65, 27);
            nudAttempts.TabIndex = 23;
            // 
            // nudRefreshRate
            // 
            nudRefreshRate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudRefreshRate.Location = new Point(270, 85);
            nudRefreshRate.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            nudRefreshRate.Name = "nudRefreshRate";
            nudRefreshRate.Size = new Size(65, 27);
            nudRefreshRate.TabIndex = 22;
            // 
            // lblRefreshRate
            // 
            lblRefreshRate.AutoSize = true;
            lblRefreshRate.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblRefreshRate.ForeColor = SystemColors.ActiveCaptionText;
            lblRefreshRate.Location = new Point(18, 87);
            lblRefreshRate.Name = "lblRefreshRate";
            lblRefreshRate.Size = new Size(115, 21);
            lblRefreshRate.TabIndex = 21;
            lblRefreshRate.Text = "Refresh rate (s)";
            // 
            // chbShowNotification
            // 
            chbShowNotification.AutoSize = true;
            chbShowNotification.Font = new Font("Calibri", 10.2F);
            chbShowNotification.ForeColor = SystemColors.ActiveCaptionText;
            chbShowNotification.Location = new Point(18, 227);
            chbShowNotification.Name = "chbShowNotification";
            chbShowNotification.Size = new Size(152, 25);
            chbShowNotification.TabIndex = 26;
            chbShowNotification.Text = "Show notification";
            chbShowNotification.UseVisualStyleBackColor = true;
            // 
            // chbMakeSound
            // 
            chbMakeSound.AutoSize = true;
            chbMakeSound.Font = new Font("Calibri", 10.2F);
            chbMakeSound.ForeColor = SystemColors.ActiveCaptionText;
            chbMakeSound.Location = new Point(18, 259);
            chbMakeSound.Name = "chbMakeSound";
            chbMakeSound.Size = new Size(117, 25);
            chbMakeSound.TabIndex = 25;
            chbMakeSound.Text = "Make sound";
            chbMakeSound.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.Location = new Point(129, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 37);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.Location = new Point(247, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 37);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(nudPacketSize);
            panel1.Controls.Add(lblPacketSize);
            panel1.Controls.Add(lblLineSeparator);
            panel1.Controls.Add(lblPingTarget);
            panel1.Controls.Add(txbPingTarget);
            panel1.Controls.Add(lblMode);
            panel1.Controls.Add(chbShowNotification);
            panel1.Controls.Add(cmbMode);
            panel1.Controls.Add(chbMakeSound);
            panel1.Controls.Add(lblRefreshRate);
            panel1.Controls.Add(lblNumberOfPR);
            panel1.Controls.Add(nudRefreshRate);
            panel1.Controls.Add(nudNumberOfPR);
            panel1.Controls.Add(nudAttempts);
            panel1.Controls.Add(lblAttempts);
            panel1.Controls.Add(chbInfiniteLoop);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 338);
            panel1.TabIndex = 29;
            // 
            // nudPacketSize
            // 
            nudPacketSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudPacketSize.Location = new Point(270, 193);
            nudPacketSize.Maximum = new decimal(new int[] { 65500, 0, 0, 0 });
            nudPacketSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPacketSize.Name = "nudPacketSize";
            nudPacketSize.Size = new Size(65, 27);
            nudPacketSize.TabIndex = 30;
            nudPacketSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblPacketSize
            // 
            lblPacketSize.AutoSize = true;
            lblPacketSize.Font = new Font("Calibri", 10.2F);
            lblPacketSize.ForeColor = SystemColors.ActiveCaptionText;
            lblPacketSize.Location = new Point(18, 191);
            lblPacketSize.Name = "lblPacketSize";
            lblPacketSize.Size = new Size(138, 21);
            lblPacketSize.TabIndex = 31;
            lblPacketSize.Text = "Packet Size (bytes)";
            // 
            // lblLineSeparator
            // 
            lblLineSeparator.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLineSeparator.BorderStyle = BorderStyle.Fixed3D;
            lblLineSeparator.Location = new Point(11, 330);
            lblLineSeparator.Name = "lblLineSeparator";
            lblLineSeparator.Size = new Size(336, 3);
            lblLineSeparator.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnCancel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 338);
            panel2.Name = "panel2";
            panel2.Size = new Size(358, 55);
            panel2.TabIndex = 30;
            // 
            // PreferencesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 393);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PreferencesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Preferences";
            Load += PreferencesForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudNumberOfPR).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAttempts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRefreshRate).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPacketSize).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblPingTarget;
        private TextBox txbPingTarget;
        private ComboBox cmbMode;
        private Label lblMode;
        private Label lblNumberOfPR;
        private NumericUpDown nudNumberOfPR;
        private Label lblAttempts;
        private CheckBox chbInfiniteLoop;
        private NumericUpDown nudAttempts;
        private NumericUpDown nudRefreshRate;
        private Label lblRefreshRate;
        private CheckBox chbShowNotification;
        private CheckBox chbMakeSound;
        private Button btnSave;
        private Button btnCancel;
        private Panel panel1;
        private Panel panel2;
        private Label lblLineSeparator;
        private NumericUpDown nudPacketSize;
        private Label lblPacketSize;
    }
}