namespace PingRequester.Client
{
    partial class MessageBoxChangesAfterRestart
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
            lblMessage = new Label();
            pcbInfoIcon = new PictureBox();
            btnOk = new Button();
            btnRestart = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbInfoIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblMessage);
            panel1.Controls.Add(pcbInfoIcon);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 138);
            panel1.TabIndex = 0;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblMessage.Location = new Point(90, 47);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(280, 46);
            lblMessage.TabIndex = 4;
            lblMessage.Text = "Some changes will be applied after \r\nrestarting the application.";
            // 
            // pcbInfoIcon
            // 
            pcbInfoIcon.Location = new Point(21, 39);
            pcbInfoIcon.Name = "pcbInfoIcon";
            pcbInfoIcon.Size = new Size(63, 62);
            pcbInfoIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbInfoIcon.TabIndex = 3;
            pcbInfoIcon.TabStop = false;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(92, 145);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(97, 34);
            btnOk.TabIndex = 1;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(213, 145);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(183, 34);
            btnRestart.TabIndex = 2;
            btnRestart.Text = "Restart immediately";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // MessageBoxChangesAfterRestart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 187);
            ControlBox = false;
            Controls.Add(btnRestart);
            Controls.Add(btnOk);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MessageBoxChangesAfterRestart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Info";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbInfoIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pcbInfoIcon;
        private Label lblMessage;
        private Button btnOk;
        private Button btnRestart;
    }
}