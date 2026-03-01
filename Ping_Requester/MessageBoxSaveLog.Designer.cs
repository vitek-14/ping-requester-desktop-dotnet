namespace PingRequester.Client
{
    partial class MessageBoxSaveLog
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
            panel1 = new Panel();
            pcbWarningIcon = new PictureBox();
            lblSecondaryMessage = new Label();
            lblMessage = new Label();
            btnSaveAndClose = new Button();
            btnCancel = new Button();
            btnClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbWarningIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pcbWarningIcon);
            panel1.Controls.Add(lblSecondaryMessage);
            panel1.Controls.Add(lblMessage);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 129);
            panel1.TabIndex = 0;
            // 
            // pcbWarningIcon
            // 
            pcbWarningIcon.Location = new Point(24, 35);
            pcbWarningIcon.Name = "pcbWarningIcon";
            pcbWarningIcon.Size = new Size(63, 62);
            pcbWarningIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbWarningIcon.TabIndex = 2;
            pcbWarningIcon.TabStop = false;
            // 
            // lblSecondaryMessage
            // 
            lblSecondaryMessage.AutoSize = true;
            lblSecondaryMessage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblSecondaryMessage.ForeColor = Color.DimGray;
            lblSecondaryMessage.Location = new Point(93, 67);
            lblSecondaryMessage.Name = "lblSecondaryMessage";
            lblSecondaryMessage.Size = new Size(309, 20);
            lblSecondaryMessage.TabIndex = 1;
            lblSecondaryMessage.Text = "(This window can be disabled in the settings.)";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblMessage.Location = new Point(93, 44);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(220, 23);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Unsaved log in the console.";
            // 
            // btnSaveAndClose
            // 
            btnSaveAndClose.Location = new Point(86, 138);
            btnSaveAndClose.Name = "btnSaveAndClose";
            btnSaveAndClose.Size = new Size(141, 34);
            btnSaveAndClose.TabIndex = 1;
            btnSaveAndClose.Text = "Save and close";
            btnSaveAndClose.UseVisualStyleBackColor = true;
            btnSaveAndClose.Click += btnSaveAndClose_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(332, 138);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 34);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(233, 138);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 34);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // MessageBoxSaveLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 181);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveAndClose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MessageBoxSaveLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Warning";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbWarningIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblSecondaryMessage;
        private Label lblMessage;
        private PictureBox pcbWarningIcon;
        private Button btnSaveAndClose;
        private Button btnCancel;
        private Button btnClose;
    }
}