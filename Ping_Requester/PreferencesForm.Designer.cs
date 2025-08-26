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
            lblLineSeparator = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfPR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAttempts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRefreshRate).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblPingTarget
            // 
            lblPingTarget.AutoSize = true;
            lblPingTarget.Font = new Font("Calibri", 10.2F);
            lblPingTarget.ForeColor = SystemColors.ActiveCaptionText;
            lblPingTarget.Location = new Point(16, 13);
            lblPingTarget.Name = "lblPingTarget";
            lblPingTarget.Size = new Size(71, 17);
            lblPingTarget.TabIndex = 2;
            lblPingTarget.Text = "Ping target";
            // 
            // txbPingTarget
            // 
            txbPingTarget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txbPingTarget.Location = new Point(113, 10);
            txbPingTarget.Margin = new Padding(3, 2, 3, 2);
            txbPingTarget.Name = "txbPingTarget";
            txbPingTarget.Size = new Size(180, 23);
            txbPingTarget.TabIndex = 3;
            // 
            // cmbMode
            // 
            cmbMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMode.FormattingEnabled = true;
            cmbMode.Location = new Point(186, 37);
            cmbMode.Margin = new Padding(3, 2, 3, 2);
            cmbMode.Name = "cmbMode";
            cmbMode.Size = new Size(107, 23);
            cmbMode.TabIndex = 17;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Calibri", 10.2F);
            lblMode.ForeColor = SystemColors.ActiveCaptionText;
            lblMode.Location = new Point(16, 39);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(41, 17);
            lblMode.TabIndex = 16;
            lblMode.Text = "Mode";
            // 
            // lblNumberOfPR
            // 
            lblNumberOfPR.AutoSize = true;
            lblNumberOfPR.Font = new Font("Calibri", 10.2F);
            lblNumberOfPR.ForeColor = SystemColors.ActiveCaptionText;
            lblNumberOfPR.Location = new Point(16, 88);
            lblNumberOfPR.Name = "lblNumberOfPR";
            lblNumberOfPR.Size = new Size(146, 17);
            lblNumberOfPR.TabIndex = 20;
            lblNumberOfPR.Text = "Number of ping requests";
            // 
            // nudNumberOfPR
            // 
            nudNumberOfPR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudNumberOfPR.Location = new Point(236, 90);
            nudNumberOfPR.Margin = new Padding(3, 2, 3, 2);
            nudNumberOfPR.Name = "nudNumberOfPR";
            nudNumberOfPR.Size = new Size(57, 23);
            nudNumberOfPR.TabIndex = 19;
            // 
            // lblAttempts
            // 
            lblAttempts.AutoSize = true;
            lblAttempts.Font = new Font("Calibri", 10.2F);
            lblAttempts.ForeColor = SystemColors.ActiveCaptionText;
            lblAttempts.Location = new Point(16, 116);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(60, 17);
            lblAttempts.TabIndex = 24;
            lblAttempts.Text = "Attempts";
            // 
            // chbInfiniteLoop
            // 
            chbInfiniteLoop.AutoSize = true;
            chbInfiniteLoop.Font = new Font("Calibri", 10.2F);
            chbInfiniteLoop.ForeColor = SystemColors.ActiveCaptionText;
            chbInfiniteLoop.Location = new Point(16, 190);
            chbInfiniteLoop.Margin = new Padding(3, 2, 3, 2);
            chbInfiniteLoop.Name = "chbInfiniteLoop";
            chbInfiniteLoop.Size = new Size(94, 21);
            chbInfiniteLoop.TabIndex = 18;
            chbInfiniteLoop.Text = "Infinite loop";
            chbInfiniteLoop.UseVisualStyleBackColor = true;
            // 
            // nudAttempts
            // 
            nudAttempts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudAttempts.Location = new Point(236, 118);
            nudAttempts.Margin = new Padding(3, 2, 3, 2);
            nudAttempts.Name = "nudAttempts";
            nudAttempts.Size = new Size(57, 23);
            nudAttempts.TabIndex = 23;
            // 
            // nudRefreshRate
            // 
            nudRefreshRate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudRefreshRate.Location = new Point(236, 64);
            nudRefreshRate.Margin = new Padding(3, 2, 3, 2);
            nudRefreshRate.Name = "nudRefreshRate";
            nudRefreshRate.Size = new Size(57, 23);
            nudRefreshRate.TabIndex = 22;
            // 
            // lblRefreshRate
            // 
            lblRefreshRate.AutoSize = true;
            lblRefreshRate.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblRefreshRate.ForeColor = SystemColors.ActiveCaptionText;
            lblRefreshRate.Location = new Point(16, 65);
            lblRefreshRate.Name = "lblRefreshRate";
            lblRefreshRate.Size = new Size(94, 17);
            lblRefreshRate.TabIndex = 21;
            lblRefreshRate.Text = "Refresh rate (s)";
            // 
            // chbShowNotification
            // 
            chbShowNotification.AutoSize = true;
            chbShowNotification.Font = new Font("Calibri", 10.2F);
            chbShowNotification.ForeColor = SystemColors.ActiveCaptionText;
            chbShowNotification.Location = new Point(16, 142);
            chbShowNotification.Margin = new Padding(3, 2, 3, 2);
            chbShowNotification.Name = "chbShowNotification";
            chbShowNotification.Size = new Size(124, 21);
            chbShowNotification.TabIndex = 26;
            chbShowNotification.Text = "Show notification";
            chbShowNotification.UseVisualStyleBackColor = true;
            // 
            // chbMakeSound
            // 
            chbMakeSound.AutoSize = true;
            chbMakeSound.Font = new Font("Calibri", 10.2F);
            chbMakeSound.ForeColor = SystemColors.ActiveCaptionText;
            chbMakeSound.Location = new Point(16, 166);
            chbMakeSound.Margin = new Padding(3, 2, 3, 2);
            chbMakeSound.Name = "chbMakeSound";
            chbMakeSound.Size = new Size(95, 21);
            chbMakeSound.TabIndex = 25;
            chbMakeSound.Text = "Make sound";
            chbMakeSound.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.Location = new Point(113, 3);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(77, 28);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.Location = new Point(216, 3);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(77, 28);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 223);
            panel1.TabIndex = 29;
            // 
            // lblLineSeparator
            // 
            lblLineSeparator.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLineSeparator.BorderStyle = BorderStyle.Fixed3D;
            lblLineSeparator.Location = new Point(10, 219);
            lblLineSeparator.Name = "lblLineSeparator";
            lblLineSeparator.Size = new Size(294, 2);
            lblLineSeparator.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnCancel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 223);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(313, 39);
            panel2.TabIndex = 30;
            // 
            // PreferencesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 262);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
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
    }
}