namespace PingRequester.Client
{
    partial class SettingsForm
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
            pnlSettingsControls = new Panel();
            tbc = new TabControl();
            tbpGeneral = new TabPage();
            grbNotification = new GroupBox();
            chbShowNotification = new CheckBox();
            chbMakeSound = new CheckBox();
            tabPage2 = new TabPage();
            lblLineSeparator = new Label();
            pnlActions = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            chbAskToSaveLogBeforeClosing = new CheckBox();
            pnlSettingsControls.SuspendLayout();
            tbc.SuspendLayout();
            tbpGeneral.SuspendLayout();
            grbNotification.SuspendLayout();
            pnlActions.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSettingsControls
            // 
            pnlSettingsControls.Controls.Add(tbc);
            pnlSettingsControls.Controls.Add(lblLineSeparator);
            pnlSettingsControls.Dock = DockStyle.Top;
            pnlSettingsControls.Location = new Point(0, 0);
            pnlSettingsControls.Name = "pnlSettingsControls";
            pnlSettingsControls.Size = new Size(458, 363);
            pnlSettingsControls.TabIndex = 0;
            // 
            // tbc
            // 
            tbc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbc.Controls.Add(tbpGeneral);
            tbc.Controls.Add(tabPage2);
            tbc.Location = new Point(0, 0);
            tbc.Name = "tbc";
            tbc.SelectedIndex = 0;
            tbc.Size = new Size(458, 335);
            tbc.TabIndex = 32;
            // 
            // tbpGeneral
            // 
            tbpGeneral.BackColor = Color.Transparent;
            tbpGeneral.Controls.Add(chbAskToSaveLogBeforeClosing);
            tbpGeneral.Controls.Add(grbNotification);
            tbpGeneral.Location = new Point(4, 29);
            tbpGeneral.Name = "tbpGeneral";
            tbpGeneral.Padding = new Padding(3);
            tbpGeneral.Size = new Size(450, 302);
            tbpGeneral.TabIndex = 0;
            tbpGeneral.Text = "General";
            // 
            // grbNotification
            // 
            grbNotification.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grbNotification.Controls.Add(chbShowNotification);
            grbNotification.Controls.Add(chbMakeSound);
            grbNotification.Location = new Point(8, 9);
            grbNotification.Name = "grbNotification";
            grbNotification.Size = new Size(434, 97);
            grbNotification.TabIndex = 31;
            grbNotification.TabStop = false;
            grbNotification.Text = "Windows Notification";
            // 
            // chbShowNotification
            // 
            chbShowNotification.AutoSize = true;
            chbShowNotification.Font = new Font("Calibri", 10.2F);
            chbShowNotification.ForeColor = SystemColors.ActiveCaptionText;
            chbShowNotification.Location = new Point(7, 26);
            chbShowNotification.Name = "chbShowNotification";
            chbShowNotification.Size = new Size(152, 25);
            chbShowNotification.TabIndex = 28;
            chbShowNotification.Text = "Show notification";
            chbShowNotification.UseVisualStyleBackColor = true;
            // 
            // chbMakeSound
            // 
            chbMakeSound.AutoSize = true;
            chbMakeSound.Font = new Font("Calibri", 10.2F);
            chbMakeSound.ForeColor = SystemColors.ActiveCaptionText;
            chbMakeSound.Location = new Point(7, 58);
            chbMakeSound.Name = "chbMakeSound";
            chbMakeSound.Size = new Size(117, 25);
            chbMakeSound.TabIndex = 27;
            chbMakeSound.Text = "Make sound";
            chbMakeSound.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Transparent;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(450, 302);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Console";
            // 
            // lblLineSeparator
            // 
            lblLineSeparator.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLineSeparator.BorderStyle = BorderStyle.Fixed3D;
            lblLineSeparator.Location = new Point(19, 355);
            lblLineSeparator.Name = "lblLineSeparator";
            lblLineSeparator.Size = new Size(418, 3);
            lblLineSeparator.TabIndex = 30;
            // 
            // pnlActions
            // 
            pnlActions.Controls.Add(btnSave);
            pnlActions.Controls.Add(btnCancel);
            pnlActions.Dock = DockStyle.Fill;
            pnlActions.Location = new Point(0, 363);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(458, 55);
            pnlActions.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.Location = new Point(201, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 37);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.Location = new Point(327, 8);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 37);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // chbAskToSaveLogBeforeClosing
            // 
            chbAskToSaveLogBeforeClosing.AutoSize = true;
            chbAskToSaveLogBeforeClosing.Font = new Font("Calibri", 10.2F);
            chbAskToSaveLogBeforeClosing.ForeColor = SystemColors.ActiveCaptionText;
            chbAskToSaveLogBeforeClosing.Location = new Point(15, 116);
            chbAskToSaveLogBeforeClosing.Name = "chbAskToSaveLogBeforeClosing";
            chbAskToSaveLogBeforeClosing.Size = new Size(237, 25);
            chbAskToSaveLogBeforeClosing.TabIndex = 29;
            chbAskToSaveLogBeforeClosing.Text = "Ask to save log before closing";
            chbAskToSaveLogBeforeClosing.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 418);
            Controls.Add(pnlActions);
            Controls.Add(pnlSettingsControls);
            Name = "SettingsForm";
            Text = "Settings";
            Load += Settings_Load;
            pnlSettingsControls.ResumeLayout(false);
            tbc.ResumeLayout(false);
            tbpGeneral.ResumeLayout(false);
            tbpGeneral.PerformLayout();
            grbNotification.ResumeLayout(false);
            grbNotification.PerformLayout();
            pnlActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSettingsControls;
        private CheckBox chbShowNotification;
        private CheckBox chbMakeSound;
        private Panel pnlActions;
        private Button btnSave;
        private Button btnCancel;
        private Label lblLineSeparator;
        private GroupBox grbNotification;
        private TabControl tbc;
        private TabPage tbpGeneral;
        private TabPage tabPage2;
        private CheckBox chbAskToSaveLogBeforeClosing;
    }
}