namespace PingRequester.Client
{
    partial class Preferences
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
            lblPingTarget.Location = new Point(18, 17);
            lblPingTarget.Name = "lblPingTarget";
            lblPingTarget.Size = new Size(86, 21);
            lblPingTarget.TabIndex = 2;
            lblPingTarget.Text = "Ping target";
            // 
            // txbPingTarget
            // 
            txbPingTarget.Location = new Point(165, 14);
            txbPingTarget.Name = "txbPingTarget";
            txbPingTarget.Size = new Size(212, 27);
            txbPingTarget.TabIndex = 3;
            // 
            // cmbMode
            // 
            cmbMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMode.FormattingEnabled = true;
            cmbMode.Location = new Point(255, 49);
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
            lblNumberOfPR.Location = new Point(18, 118);
            lblNumberOfPR.Name = "lblNumberOfPR";
            lblNumberOfPR.Size = new Size(183, 21);
            lblNumberOfPR.TabIndex = 20;
            lblNumberOfPR.Text = "Number of ping requests";
            // 
            // nudNumberOfPR
            // 
            nudNumberOfPR.Location = new Point(312, 120);
            nudNumberOfPR.Name = "nudNumberOfPR";
            nudNumberOfPR.Size = new Size(65, 27);
            nudNumberOfPR.TabIndex = 19;
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
            chbInfiniteLoop.Location = new Point(18, 253);
            chbInfiniteLoop.Name = "chbInfiniteLoop";
            chbInfiniteLoop.Size = new Size(116, 25);
            chbInfiniteLoop.TabIndex = 18;
            chbInfiniteLoop.Text = "Infinite loop";
            chbInfiniteLoop.UseVisualStyleBackColor = true;
            // 
            // nudAttempts
            // 
            nudAttempts.Location = new Point(312, 157);
            nudAttempts.Name = "nudAttempts";
            nudAttempts.Size = new Size(65, 27);
            nudAttempts.TabIndex = 23;
            // 
            // nudRefreshRate
            // 
            nudRefreshRate.Location = new Point(312, 85);
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
            chbShowNotification.Location = new Point(18, 190);
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
            chbMakeSound.Location = new Point(18, 221);
            chbMakeSound.Name = "chbMakeSound";
            chbMakeSound.Size = new Size(117, 25);
            chbMakeSound.TabIndex = 25;
            chbMakeSound.Text = "Make sound";
            chbMakeSound.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.Location = new Point(172, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 37);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.Location = new Point(289, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 37);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
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
            panel1.Size = new Size(400, 290);
            panel1.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnCancel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 290);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 60);
            panel2.TabIndex = 30;
            // 
            // Preferences
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 350);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Preferences";
            Text = "Preferences";
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
    }
}