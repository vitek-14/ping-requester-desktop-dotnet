using PingRequester.Client.controlls;

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
            lblTarget = new OneLineLabel();
            lblSRL = new Label();
            lblTimeStamp = new Label();
            btnDetails = new Button();
            lblTarget = new OneLineLabel();
            tlpSession.SuspendLayout();
            SuspendLayout();
            // 
            // tlpSession
            // 
            tlpSession.BackColor = Color.White;
            tlpSession.ColumnCount = 5;
            tlpSession.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.6599979F));
            tlpSession.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.1099987F));
            tlpSession.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.8599987F));
            tlpSession.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.96999931F));
            tlpSession.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.3999977F));
            tlpSession.Controls.Add(lblSRL, 1, 0);
            tlpSession.Controls.Add(lblTimeStamp, 2, 0);
            tlpSession.Controls.Add(btnDetails, 4, 0);
            tlpSession.Controls.Add(lblTarget, 0, 0);
            tlpSession.Dock = DockStyle.Fill;
            tlpSession.Location = new Point(0, 0);
            tlpSession.Name = "tlpSession";
            tlpSession.RowCount = 1;
            tlpSession.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSession.Size = new Size(590, 46);
            tlpSession.TabIndex = 0;
            tlpSession.MouseEnter += MouseEnter;
            tlpSession.MouseLeave += MouseLeave;
            // 
            // lblTarget
            // 
            lblTarget.AutoEllipsis = true;
            lblTarget.Dock = DockStyle.Fill;
            lblTarget.FlatStyle = FlatStyle.Flat;
            lblTarget.ForeColor = Color.Black;
            lblTarget.Location = new Point(3, 0);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(174, 46);
            lblTarget.TabIndex = 0;
            lblTarget.Text = "www.seznam.cz";
            lblTarget.TextAlign = ContentAlignment.MiddleLeft;
            lblTarget.MouseEnter += MouseEnter;
            lblTarget.MouseLeave += MouseLeave;
            // 
            // lblSRL
            // 
            lblSRL.AutoSize = true;
            lblSRL.Dock = DockStyle.Fill;
            lblSRL.ForeColor = Color.Black;
            lblSRL.Location = new Point(183, 0);
            lblSRL.Name = "lblSRL";
            lblSRL.Size = new Size(94, 46);
            lblSRL.TabIndex = 1;
            lblSRL.Text = "200/200/0";
            lblSRL.TextAlign = ContentAlignment.MiddleCenter;
            lblSRL.MouseEnter += MouseEnter;
            lblSRL.MouseLeave += MouseLeave;
            // 
            // lblTimeStamp
            // 
            lblTimeStamp.AutoSize = true;
            lblTimeStamp.Dock = DockStyle.Fill;
            lblTimeStamp.ForeColor = Color.Black;
            lblTimeStamp.Location = new Point(283, 0);
            lblTimeStamp.Name = "lblTimeStamp";
            lblTimeStamp.Size = new Size(146, 46);
            lblTimeStamp.TabIndex = 2;
            lblTimeStamp.Text = "14:21 11. 02. 2025";
            lblTimeStamp.TextAlign = ContentAlignment.MiddleLeft;
            lblTimeStamp.MouseEnter += MouseEnter;
            lblTimeStamp.MouseLeave += MouseLeave;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = Color.Transparent;
            btnDetails.Dock = DockStyle.Fill;
            btnDetails.FlatAppearance.BorderSize = 0;
            btnDetails.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDetails.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDetails.FlatStyle = FlatStyle.Flat;
            btnDetails.ForeColor = Color.DodgerBlue;
            btnDetails.Location = new Point(470, 3);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(117, 40);
            btnDetails.TabIndex = 3;
            btnDetails.Text = "Show details";
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Click += btnDetails_Click;
            btnDetails.MouseEnter += btnDetails_MouseEnter;
            btnDetails.MouseLeave += btnDetails_MouseLeave;
            // 
            // lblTarget
            // 
            lblTarget.AutoEllipsis = true;
            lblTarget.Dock = DockStyle.Fill;
            lblTarget.FlatStyle = FlatStyle.Flat;
            lblTarget.ForeColor = Color.Black;
            lblTarget.Location = new Point(3, 0);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(174, 46);
            lblTarget.TabIndex = 0;
            lblTarget.Text = "www.seznam.cz";
            lblTarget.TextAlign = ContentAlignment.MiddleLeft;
            lblTarget.MouseEnter += MouseEnter;
            lblTarget.MouseLeave += MouseLeave;
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
        private Label lblSRL;
        private Label lblTimeStamp;
        private Button btnDetails;
        private OneLineLabel lblTarget;
    }
}
