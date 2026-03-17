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
    /// <summary>
    /// User control used as a session's visual for the table in the MainForm.
    /// </summary>
    public partial class SessionRow : UserControl
    {
        private RequestRunSession session;
        private Color backColor;
        private PingRequestData _data;
        private int preferencesId;

        public event EventHandler SessionDeleted;
        public event EventHandler UsePreferences;

        /// <summary>
        /// Default constructor of the class.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="bgColor"></param>
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

        public int PreferencesId { get => preferencesId; }

        /// <summary>
        /// Parses target (both ip and domain).
        /// </summary>
        private string TargetParser()
        {
            return $"{this.session.PingTarget} ({this.session.Ipv4})";
        }

        /// <summary>
        /// Parses number of: sent, recieved and lost packets into a string.
        /// </summary>
        private string SrlParser()
        {
            return $"{this.session.Sent}/{this.session.Received}/{this.session.Lost}";
        }

        /// <summary>
        /// Parses DateTime into the string.
        /// </summary>
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
                UsePreferences.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Handles the mouse enter event by changing the background color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMouseEnter(object sender, EventArgs e)
        {
            tlpSession.BackColor = Color.LightBlue;
        }

        /// <summary>
        /// Resets the background color of tlpSession when the mouse leaves the control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMouseLeave(object sender, EventArgs e)
        {
            tlpSession.BackColor = backColor;
        }
    }
}
