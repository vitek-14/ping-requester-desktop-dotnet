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
            lblTarget.Text = TargetParser();
            lblSRL.Text = SrlParser();
            lblTimeStamp.Text = TimeStampParser();
            backColor = bgColor;

            tlpSession.BackColor = backColor;
        }

        private string TargetParser()
        {
            return $"{this.session.PingTarget} ({this.session.Ipv4})";
        }

        private string SrlParser()
        {
            return $"{this.session.Sent}/{this.session.Received}/{this.session.Lost}";
        }

        private string TimeStampParser()
        {
            return this.session.Start.ToString();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            var preferences = _data.Preferences.GetById(this.session.UserPreferencesId);
            var dialogResult = new SessionDetails(this.session, preferences).ShowDialog();

            // action for delete
            if (dialogResult == DialogResult.No)
            {
                _data.Sessions.Delete(this.session);
                SessionDeleted.Invoke(this, EventArgs.Empty);
                return;
            }

            // action for use preferences
            if (dialogResult == DialogResult.Yes)
            {
                ;
            }
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
