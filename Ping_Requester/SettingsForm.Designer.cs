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
            pnlActions = new Panel();
            chbShowNotification = new CheckBox();
            chbMakeSound = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblLineSeparator = new Label();
            grbNotification = new GroupBox();
            pnlSettingsControls.SuspendLayout();
            pnlActions.SuspendLayout();
            grbNotification.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSettingsControls
            // 
            pnlSettingsControls.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSettingsControls.Controls.Add(grbNotification);
            pnlSettingsControls.Controls.Add(lblLineSeparator);
            pnlSettingsControls.Location = new Point(0, 0);
            pnlSettingsControls.Name = "pnlSettingsControls";
            pnlSettingsControls.Size = new Size(329, 384);
            pnlSettingsControls.TabIndex = 0;
            // 
            // pnlActions
            // 
            pnlActions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlActions.Controls.Add(btnSave);
            pnlActions.Controls.Add(btnCancel);
            pnlActions.Location = new Point(0, 384);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(329, 66);
            pnlActions.TabIndex = 1;
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
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.Location = new Point(95, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 37);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.Location = new Point(213, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 37);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblLineSeparator
            // 
            lblLineSeparator.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLineSeparator.BorderStyle = BorderStyle.Fixed3D;
            lblLineSeparator.Location = new Point(19, 376);
            lblLineSeparator.Name = "lblLineSeparator";
            lblLineSeparator.Size = new Size(289, 3);
            lblLineSeparator.TabIndex = 30;
            // 
            // grbNotification
            // 
            grbNotification.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grbNotification.Controls.Add(chbShowNotification);
            grbNotification.Controls.Add(chbMakeSound);
            grbNotification.Location = new Point(12, 12);
            grbNotification.Name = "grbNotification";
            grbNotification.Size = new Size(305, 97);
            grbNotification.TabIndex = 31;
            grbNotification.TabStop = false;
            grbNotification.Text = "Notification";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 450);
            Controls.Add(pnlActions);
            Controls.Add(pnlSettingsControls);
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            pnlSettingsControls.ResumeLayout(false);
            pnlActions.ResumeLayout(false);
            grbNotification.ResumeLayout(false);
            grbNotification.PerformLayout();
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
    }
}