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
    /// Displays session's all available data including user preferences used in the session.
    /// </summary>
    public partial class SessionDetails : Form
    {
        private RequestRunSession session;
        private UserPreferences preferences;

        /// <summary>
        /// Default constructor of the class.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="preferences"></param>
        public SessionDetails(RequestRunSession session, UserPreferences preferences)
        {
            InitializeComponent();

            this.session = session;
            this.preferences = preferences;

            ParseData();
        }

        /// <summary>
        /// Parses data from the session and user preferences to the UI.
        /// </summary>
        private void ParseData()
        {
            // session
            lblTargetActive.Text = session.PingTarget;
            lblIpv4Active.Text = session.Ipv4;
            lblStartActive.Text = session.Start.ToString();
            lblEndActive.Text = session.End.ToString();
            lblPacketSizeActive.Text = session.PacketSize.ToString();
            lblSRLActive.Text = $"{session.Sent}/{session.Received}/{session.Lost}";
            lblMaxRespTimeActive.Text = session.MaxResponseTimeMs.ToString();
            lblMinRespTimeActive.Text = session.MinResponseTimeMs.ToString();
            lblAverageRespTimeActive.Text = session.AverageResponseTimeMs.ToString();

            // preferences
            lblPingTargetActive.Text = preferences.PingTarget;
            lblModeActive.Text = preferences.Mode;
            lblRefreshRateActive.Text = preferences.RefreshRate.ToString();
            lblInfLoopActive.Text = preferences.InfiniteLoop.ToString();
            lblStopWhenSuccessActive.Text = preferences.StopWhenSuccess.ToString();
            lblPRCountActive.Text = preferences.PingRequestCount.ToString();
            lblAttemptsActive.Text = preferences.Attempts.ToString();
            lblPacketSizePActive.Text = preferences.PacketSize.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnUsePreferences_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
