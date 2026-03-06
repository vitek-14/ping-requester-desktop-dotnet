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
            grbLogs = new GroupBox();
            txbDateTimeTemplate = new TextBox();
            lblTemplate = new Label();
            lblLogFilesPath = new Label();
            btnFolderBrowserDialog = new Button();
            chbAskToSaveLogBeforeClosing = new CheckBox();
            txbLogFilesPath = new TextBox();
            grbNotification = new GroupBox();
            chbAlertOnPingCompletion = new CheckBox();
            chbAlertOnSuccess = new CheckBox();
            chbMakeSound = new CheckBox();
            tabPage2 = new TabPage();
            cmbColorTheme = new ComboBox();
            lblColorTheme = new Label();
            chbClearConsole = new CheckBox();
            lblLineSeparator = new Label();
            pnlActions = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            pnlSettingsControls.SuspendLayout();
            tbc.SuspendLayout();
            tbpGeneral.SuspendLayout();
            grbLogs.SuspendLayout();
            grbNotification.SuspendLayout();
            tabPage2.SuspendLayout();
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
            tbc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            tbpGeneral.Controls.Add(grbLogs);
            tbpGeneral.Controls.Add(grbNotification);
            tbpGeneral.Location = new Point(4, 29);
            tbpGeneral.Name = "tbpGeneral";
            tbpGeneral.Padding = new Padding(3);
            tbpGeneral.Size = new Size(450, 302);
            tbpGeneral.TabIndex = 0;
            tbpGeneral.Text = "General";
            // 
            // grbLogs
            // 
            grbLogs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grbLogs.Controls.Add(txbDateTimeTemplate);
            grbLogs.Controls.Add(lblTemplate);
            grbLogs.Controls.Add(lblLogFilesPath);
            grbLogs.Controls.Add(btnFolderBrowserDialog);
            grbLogs.Controls.Add(chbAskToSaveLogBeforeClosing);
            grbLogs.Controls.Add(txbLogFilesPath);
            grbLogs.Location = new Point(8, 112);
            grbLogs.Name = "grbLogs";
            grbLogs.Size = new Size(434, 142);
            grbLogs.TabIndex = 35;
            grbLogs.TabStop = false;
            grbLogs.Text = "Logs";
            // 
            // txbDateTimeTemplate
            // 
            txbDateTimeTemplate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbDateTimeTemplate.Location = new Point(154, 67);
            txbDateTimeTemplate.Name = "txbDateTimeTemplate";
            txbDateTimeTemplate.Size = new Size(233, 27);
            txbDateTimeTemplate.TabIndex = 36;
            // 
            // lblTemplate
            // 
            lblTemplate.AutoSize = true;
            lblTemplate.Location = new Point(7, 70);
            lblTemplate.Name = "lblTemplate";
            lblTemplate.Size = new Size(141, 20);
            lblTemplate.TabIndex = 35;
            lblTemplate.Text = "DateTime template:";
            // 
            // lblLogFilesPath
            // 
            lblLogFilesPath.AutoSize = true;
            lblLogFilesPath.Location = new Point(7, 33);
            lblLogFilesPath.Name = "lblLogFilesPath";
            lblLogFilesPath.Size = new Size(102, 20);
            lblLogFilesPath.TabIndex = 32;
            lblLogFilesPath.Text = "Log files path:";
            // 
            // btnFolderBrowserDialog
            // 
            btnFolderBrowserDialog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFolderBrowserDialog.BackgroundImage = Properties.Resources.folder;
            btnFolderBrowserDialog.BackgroundImageLayout = ImageLayout.Zoom;
            btnFolderBrowserDialog.FlatAppearance.BorderSize = 0;
            btnFolderBrowserDialog.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFolderBrowserDialog.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFolderBrowserDialog.FlatStyle = FlatStyle.Flat;
            btnFolderBrowserDialog.Location = new Point(388, 29);
            btnFolderBrowserDialog.Name = "btnFolderBrowserDialog";
            btnFolderBrowserDialog.Size = new Size(40, 29);
            btnFolderBrowserDialog.TabIndex = 34;
            btnFolderBrowserDialog.UseVisualStyleBackColor = true;
            btnFolderBrowserDialog.Click += btnFolderBrowserDialog_Click;
            // 
            // chbAskToSaveLogBeforeClosing
            // 
            chbAskToSaveLogBeforeClosing.AutoSize = true;
            chbAskToSaveLogBeforeClosing.Font = new Font("Calibri", 10.2F);
            chbAskToSaveLogBeforeClosing.ForeColor = SystemColors.ActiveCaptionText;
            chbAskToSaveLogBeforeClosing.Location = new Point(10, 102);
            chbAskToSaveLogBeforeClosing.Name = "chbAskToSaveLogBeforeClosing";
            chbAskToSaveLogBeforeClosing.Size = new Size(237, 25);
            chbAskToSaveLogBeforeClosing.TabIndex = 29;
            chbAskToSaveLogBeforeClosing.Text = "Ask to save log before closing";
            chbAskToSaveLogBeforeClosing.UseVisualStyleBackColor = true;
            // 
            // txbLogFilesPath
            // 
            txbLogFilesPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbLogFilesPath.Location = new Point(118, 29);
            txbLogFilesPath.Name = "txbLogFilesPath";
            txbLogFilesPath.Size = new Size(269, 27);
            txbLogFilesPath.TabIndex = 33;
            // 
            // grbNotification
            // 
            grbNotification.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grbNotification.Controls.Add(chbAlertOnPingCompletion);
            grbNotification.Controls.Add(chbAlertOnSuccess);
            grbNotification.Controls.Add(chbMakeSound);
            grbNotification.Location = new Point(8, 9);
            grbNotification.Name = "grbNotification";
            grbNotification.Size = new Size(434, 97);
            grbNotification.TabIndex = 31;
            grbNotification.TabStop = false;
            grbNotification.Text = "Windows Notification";
            // 
            // chbAlertOnPingCompletion
            // 
            chbAlertOnPingCompletion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chbAlertOnPingCompletion.AutoSize = true;
            chbAlertOnPingCompletion.Font = new Font("Calibri", 10.2F);
            chbAlertOnPingCompletion.ForeColor = SystemColors.ActiveCaptionText;
            chbAlertOnPingCompletion.Location = new Point(214, 26);
            chbAlertOnPingCompletion.Name = "chbAlertOnPingCompletion";
            chbAlertOnPingCompletion.Size = new Size(204, 25);
            chbAlertOnPingCompletion.TabIndex = 29;
            chbAlertOnPingCompletion.Text = "Alert on ping completion";
            chbAlertOnPingCompletion.UseVisualStyleBackColor = true;
            // 
            // chbAlertOnSuccess
            // 
            chbAlertOnSuccess.AutoSize = true;
            chbAlertOnSuccess.Font = new Font("Calibri", 10.2F);
            chbAlertOnSuccess.ForeColor = SystemColors.ActiveCaptionText;
            chbAlertOnSuccess.Location = new Point(7, 26);
            chbAlertOnSuccess.Name = "chbAlertOnSuccess";
            chbAlertOnSuccess.Size = new Size(144, 25);
            chbAlertOnSuccess.TabIndex = 28;
            chbAlertOnSuccess.Text = "Alert on success";
            chbAlertOnSuccess.UseVisualStyleBackColor = true;
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
            tabPage2.Controls.Add(cmbColorTheme);
            tabPage2.Controls.Add(lblColorTheme);
            tabPage2.Controls.Add(chbClearConsole);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(450, 302);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Console";
            // 
            // cmbColorTheme
            // 
            cmbColorTheme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColorTheme.FormattingEnabled = true;
            cmbColorTheme.Location = new Point(8, 72);
            cmbColorTheme.Name = "cmbColorTheme";
            cmbColorTheme.Size = new Size(153, 28);
            cmbColorTheme.TabIndex = 2;
            // 
            // lblColorTheme
            // 
            lblColorTheme.AutoSize = true;
            lblColorTheme.Location = new Point(8, 49);
            lblColorTheme.Name = "lblColorTheme";
            lblColorTheme.Size = new Size(91, 20);
            lblColorTheme.TabIndex = 1;
            lblColorTheme.Text = "Color theme";
            // 
            // chbClearConsole
            // 
            chbClearConsole.AutoSize = true;
            chbClearConsole.Location = new Point(8, 11);
            chbClearConsole.Name = "chbClearConsole";
            chbClearConsole.Size = new Size(380, 24);
            chbClearConsole.TabIndex = 0;
            chbClearConsole.Text = "Clear console when ping request session is initialized\r\n";
            chbClearConsole.UseVisualStyleBackColor = true;
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
            btnSave.Location = new Point(220, 11);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 33);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.Location = new Point(345, 11);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 33);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 418);
            Controls.Add(pnlActions);
            Controls.Add(pnlSettingsControls);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += Settings_Load;
            pnlSettingsControls.ResumeLayout(false);
            tbc.ResumeLayout(false);
            tbpGeneral.ResumeLayout(false);
            grbLogs.ResumeLayout(false);
            grbLogs.PerformLayout();
            grbNotification.ResumeLayout(false);
            grbNotification.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            pnlActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSettingsControls;
        private CheckBox chbAlertOnSuccess;
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
        private CheckBox chbAlertOnPingCompletion;
        private TextBox txbLogFilesPath;
        private Label lblLogFilesPath;
        private Button btnFolderBrowserDialog;
        private FolderBrowserDialog folderBrowserDialog1;
        private GroupBox grbLogs;
        private Label lblTemplate;
        private TextBox txbDateTimeTemplate;
        private CheckBox chbClearConsole;
        private Label lblColorTheme;
        private ComboBox cmbColorTheme;
    }
}