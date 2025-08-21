namespace Ping_Requester
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
            pnlMiddle = new Panel();
            pnlData = new Panel();
            pnlControls = new Panel();
            lblNumberOfTries = new Label();
            nudNumberOfTries = new NumericUpDown();
            pnlInfiniteLoop = new Panel();
            chbInfiniteLoop = new CheckBox();
            lblNumberOfPR = new Label();
            nudNumberOfPR = new NumericUpDown();
            nudSpaceBetweenPR = new NumericUpDown();
            label2 = new Label();
            lblWhenSuccess = new Label();
            chbShowNotification = new CheckBox();
            chbMakeSound = new CheckBox();
            lblPingTarget = new Label();
            txbPingTarget = new TextBox();
            pnlInfo = new Panel();
            lblInfo = new Label();
            pnlTop.SuspendLayout();
            pnlMiddle.SuspendLayout();
            pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfTries).BeginInit();
            pnlInfiniteLoop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfPR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSpaceBetweenPR).BeginInit();
            pnlInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlTop.Controls.Add(lblPingRequester);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(811, 82);
            pnlTop.TabIndex = 0;
            // 
            // lblPingRequester
            // 
            lblPingRequester.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPingRequester.AutoSize = true;
            lblPingRequester.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblPingRequester.ForeColor = SystemColors.HotTrack;
            lblPingRequester.Location = new Point(233, 17);
            lblPingRequester.Name = "lblPingRequester";
            lblPingRequester.Size = new Size(328, 47);
            lblPingRequester.TabIndex = 0;
            lblPingRequester.Text = "Ping Requester";
            lblPingRequester.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlMiddle
            // 
            pnlMiddle.BorderStyle = BorderStyle.FixedSingle;
            pnlMiddle.Controls.Add(pnlData);
            pnlMiddle.Controls.Add(pnlControls);
            pnlMiddle.Dock = DockStyle.Top;
            pnlMiddle.Location = new Point(0, 82);
            pnlMiddle.Name = "pnlMiddle";
            pnlMiddle.Size = new Size(811, 349);
            pnlMiddle.TabIndex = 1;
            // 
            // pnlData
            // 
            pnlData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlData.Dock = DockStyle.Fill;
            pnlData.Location = new Point(382, 0);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(427, 347);
            pnlData.TabIndex = 3;
            // 
            // pnlControls
            // 
            pnlControls.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlControls.BorderStyle = BorderStyle.FixedSingle;
            pnlControls.Controls.Add(lblNumberOfTries);
            pnlControls.Controls.Add(nudNumberOfTries);
            pnlControls.Controls.Add(pnlInfiniteLoop);
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
            pnlControls.Size = new Size(382, 347);
            pnlControls.TabIndex = 2;
            // 
            // lblNumberOfTries
            // 
            lblNumberOfTries.Anchor = AnchorStyles.Left;
            lblNumberOfTries.AutoSize = true;
            lblNumberOfTries.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblNumberOfTries.ForeColor = SystemColors.ActiveCaptionText;
            lblNumberOfTries.Location = new Point(12, 138);
            lblNumberOfTries.Name = "lblNumberOfTries";
            lblNumberOfTries.Size = new Size(144, 20);
            lblNumberOfTries.TabIndex = 11;
            lblNumberOfTries.Text = "Number of tries";
            // 
            // nudNumberOfTries
            // 
            nudNumberOfTries.Anchor = AnchorStyles.Left;
            nudNumberOfTries.Location = new Point(279, 136);
            nudNumberOfTries.Name = "nudNumberOfTries";
            nudNumberOfTries.Size = new Size(65, 27);
            nudNumberOfTries.TabIndex = 10;
            // 
            // pnlInfiniteLoop
            // 
            pnlInfiniteLoop.Controls.Add(chbInfiniteLoop);
            pnlInfiniteLoop.Controls.Add(lblNumberOfPR);
            pnlInfiniteLoop.Controls.Add(nudNumberOfPR);
            pnlInfiniteLoop.Location = new Point(12, 186);
            pnlInfiniteLoop.Name = "pnlInfiniteLoop";
            pnlInfiniteLoop.Size = new Size(344, 77);
            pnlInfiniteLoop.TabIndex = 10;
            // 
            // chbInfiniteLoop
            // 
            chbInfiniteLoop.AutoSize = true;
            chbInfiniteLoop.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chbInfiniteLoop.ForeColor = SystemColors.ActiveCaptionText;
            chbInfiniteLoop.Location = new Point(3, 11);
            chbInfiniteLoop.Name = "chbInfiniteLoop";
            chbInfiniteLoop.Size = new Size(148, 24);
            chbInfiniteLoop.TabIndex = 2;
            chbInfiniteLoop.Text = "Infinite loop";
            chbInfiniteLoop.UseVisualStyleBackColor = true;
            // 
            // lblNumberOfPR
            // 
            lblNumberOfPR.AutoSize = true;
            lblNumberOfPR.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblNumberOfPR.ForeColor = SystemColors.ActiveCaptionText;
            lblNumberOfPR.Location = new Point(3, 47);
            lblNumberOfPR.Name = "lblNumberOfPR";
            lblNumberOfPR.Size = new Size(216, 20);
            lblNumberOfPR.TabIndex = 4;
            lblNumberOfPR.Text = "Number of ping requests";
            // 
            // nudNumberOfPR
            // 
            nudNumberOfPR.Location = new Point(267, 45);
            nudNumberOfPR.Name = "nudNumberOfPR";
            nudNumberOfPR.Size = new Size(65, 27);
            nudNumberOfPR.TabIndex = 3;
            // 
            // nudSpaceBetweenPR
            // 
            nudSpaceBetweenPR.Location = new Point(279, 93);
            nudSpaceBetweenPR.Name = "nudSpaceBetweenPR";
            nudSpaceBetweenPR.Size = new Size(65, 27);
            nudSpaceBetweenPR.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(243, 20);
            label2.TabIndex = 8;
            label2.Text = "Space between requests (s)";
            // 
            // lblWhenSuccess
            // 
            lblWhenSuccess.AutoSize = true;
            lblWhenSuccess.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblWhenSuccess.ForeColor = SystemColors.ActiveCaptionText;
            lblWhenSuccess.Location = new Point(12, 277);
            lblWhenSuccess.Name = "lblWhenSuccess";
            lblWhenSuccess.Size = new Size(126, 20);
            lblWhenSuccess.TabIndex = 7;
            lblWhenSuccess.Text = "When success:";
            // 
            // chbShowNotification
            // 
            chbShowNotification.AutoSize = true;
            chbShowNotification.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chbShowNotification.ForeColor = SystemColors.ActiveCaptionText;
            chbShowNotification.Location = new Point(12, 309);
            chbShowNotification.Name = "chbShowNotification";
            chbShowNotification.Size = new Size(184, 24);
            chbShowNotification.TabIndex = 6;
            chbShowNotification.Text = "Show notification";
            chbShowNotification.UseVisualStyleBackColor = true;
            // 
            // chbMakeSound
            // 
            chbMakeSound.AutoSize = true;
            chbMakeSound.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chbMakeSound.ForeColor = SystemColors.ActiveCaptionText;
            chbMakeSound.Location = new Point(223, 309);
            chbMakeSound.Name = "chbMakeSound";
            chbMakeSound.Size = new Size(121, 24);
            chbMakeSound.TabIndex = 5;
            chbMakeSound.Text = "Make sound";
            chbMakeSound.UseVisualStyleBackColor = true;
            // 
            // lblPingTarget
            // 
            lblPingTarget.AutoSize = true;
            lblPingTarget.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblPingTarget.ForeColor = SystemColors.ActiveCaptionText;
            lblPingTarget.Location = new Point(12, 21);
            lblPingTarget.Name = "lblPingTarget";
            lblPingTarget.Size = new Size(108, 20);
            lblPingTarget.TabIndex = 0;
            lblPingTarget.Text = "Ping target";
            // 
            // txbPingTarget
            // 
            txbPingTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbPingTarget.Location = new Point(12, 48);
            txbPingTarget.Name = "txbPingTarget";
            txbPingTarget.Size = new Size(332, 27);
            txbPingTarget.TabIndex = 1;
            // 
            // pnlInfo
            // 
            pnlInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlInfo.Controls.Add(lblInfo);
            pnlInfo.Dock = DockStyle.Fill;
            pnlInfo.Location = new Point(0, 431);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(811, 54);
            pnlInfo.TabIndex = 2;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblInfo.ForeColor = SystemColors.InfoText;
            lblInfo.Location = new Point(10, 16);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(70, 22);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Info: ";
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
            pnlMiddle.ResumeLayout(false);
            pnlControls.ResumeLayout(false);
            pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfTries).EndInit();
            pnlInfiniteLoop.ResumeLayout(false);
            pnlInfiniteLoop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfPR).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSpaceBetweenPR).EndInit();
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Label lblPingRequester;
        private Panel pnlMiddle;
        private Panel pnlInfo;
        private Label lblInfo;
        private Label lblPingTarget;
        private TextBox txbPingTarget;
        private Panel pnlControls;
        private Panel pnlData;
        private Label lblWhenSuccess;
        private CheckBox chbShowNotification;
        private CheckBox chbMakeSound;
        private Label label2;
        private NumericUpDown nudSpaceBetweenPR;
        private Panel pnlInfiniteLoop;
        private Label lblNumberOfTries;
        private CheckBox chbInfiniteLoop;
        private Label lblNumberOfPR;
        private NumericUpDown nudNumberOfPR;
        private NumericUpDown nudNumberOfTries;
    }
}
