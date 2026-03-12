namespace PingRequester.Client
{
    partial class SessionRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpSession = new TableLayoutPanel();
            lblTarget = new Label();
            lblSRL = new Label();
            lblTimeStamp = new Label();
            btnPreferences = new Button();
            tlpSession.SuspendLayout();
            SuspendLayout();
            // 
            // tlpSession
            // 
            tlpSession.ColumnCount = 4;
            tlpSession.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.9086189F));
            tlpSession.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.2520885F));
            tlpSession.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.0821F));
            tlpSession.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.75719F));
            tlpSession.Controls.Add(lblTarget, 0, 0);
            tlpSession.Controls.Add(lblSRL, 1, 0);
            tlpSession.Controls.Add(lblTimeStamp, 2, 0);
            tlpSession.Controls.Add(btnPreferences, 3, 0);
            tlpSession.Dock = DockStyle.Fill;
            tlpSession.Location = new Point(0, 0);
            tlpSession.Name = "tlpSession";
            tlpSession.RowCount = 1;
            tlpSession.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSession.Size = new Size(590, 46);
            tlpSession.TabIndex = 0;
            // 
            // lblTarget
            // 
            lblTarget.AutoEllipsis = true;
            lblTarget.Dock = DockStyle.Fill;
            lblTarget.Location = new Point(3, 0);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(176, 46);
            lblTarget.TabIndex = 0;
            lblTarget.Text = "www.seznam.cz";
            lblTarget.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSRL
            // 
            lblSRL.AutoSize = true;
            lblSRL.Dock = DockStyle.Fill;
            lblSRL.Location = new Point(185, 0);
            lblSRL.Name = "lblSRL";
            lblSRL.Size = new Size(95, 46);
            lblSRL.TabIndex = 1;
            lblSRL.Text = "200/200/0";
            lblSRL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTimeStamp
            // 
            lblTimeStamp.AutoSize = true;
            lblTimeStamp.Dock = DockStyle.Fill;
            lblTimeStamp.Location = new Point(286, 0);
            lblTimeStamp.Name = "lblTimeStamp";
            lblTimeStamp.Size = new Size(147, 46);
            lblTimeStamp.TabIndex = 2;
            lblTimeStamp.Text = "14:21 11. 02. 2025";
            lblTimeStamp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnPreferences
            // 
            btnPreferences.Dock = DockStyle.Fill;
            btnPreferences.Location = new Point(439, 3);
            btnPreferences.Name = "btnPreferences";
            btnPreferences.Size = new Size(148, 40);
            btnPreferences.TabIndex = 3;
            btnPreferences.Text = "Preferences";
            btnPreferences.UseVisualStyleBackColor = true;
            // 
            // SessionRow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpSession);
            Name = "SessionRow";
            Size = new Size(590, 46);
            tlpSession.ResumeLayout(false);
            tlpSession.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpSession;
        private Label lblTarget;
        private Label lblSRL;
        private Label lblTimeStamp;
        private Button btnPreferences;
    }
}
