using PingRequester.BusinessLayer;
using PingRequester.Data;
using PingRequester.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingRequester.Client
{
    public partial class SessionRow : UserControl
    {
        private RequestRunSession session;
        private int preferencesId;
        private Color backColor;
        private PingRequestData _data;

        public event EventHandler SessionDeleted;

        public SessionRow(RequestRunSession session, Color bgColor)
        {
            InitializeComponent();

            _data = new PingRequestData();

            this.session = session;

            this.preferencesId = this.session.UserPreferencesId;
            lblTarget.Text = TargetParser(this.session);
            lblSRL.Text = SrlParser(this.session);
            lblTimeStamp.Text = TimeStampParser(this.session);
            backColor = bgColor;

            tlpSession.BackColor = backColor;
        }

        private string TargetParser(RequestRunSession session)
        {
            return $"{session.PingTarget} ({session.Ipv4})";
        }

        private string SrlParser(RequestRunSession session)
        {
            return $"{session.Sent}/{session.Received}/{session.Lost}";
        }

        private string TimeStampParser(RequestRunSession session)
        {
            return session.Start.ToString();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            var dialogResult = new SessionDetails().ShowDialog();

            // action for delete
            if (dialogResult == DialogResult.No)
            {
                _data.Sessions.Delete(this.session);

                SessionDeleted.Invoke(this, EventArgs.Empty);
            }

            // action for use preferences
        }

        private void OnMouseEnter()
        {
            tlpSession.BackColor = Color.LightBlue;
        }

        private void OnMouseLeave()
        {
            tlpSession.BackColor = backColor;
        }

        private void lblTarget_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter();
        }

        private void lblTarget_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave();
        }

        private void lblSRL_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter();
        }

        private void lblSRL_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave();
        }

        private void lblTimeStamp_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter();
        }

        private void lblTimeStamp_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave();
        }

        private void btnDetails_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter();
        }

        private void btnDetails_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave();
        }

        private void tlpSession_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter();
        }

        private void tlpSession_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave();
        }
    }
}
