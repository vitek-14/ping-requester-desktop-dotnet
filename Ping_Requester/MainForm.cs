using PingRequester.BusinessLayer;
using PingRequester.Data;
using PingRequester.Data.DataObjects;

namespace PingRequester.Client
{
    /// <summary>
    /// Main Form class of the app.
    /// </summary>
    public partial class MainForm : Form, IRequestRunWidgetService
    {
        private ConsoleWriter console;
        private Requester requester;
        private bool controlsLocked;
        private Stack<Control> mainControls;

        /// <summary>
        /// Default constructor of the MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.controlsLocked = false;
            // Prepare console writer 
            this.console = new ConsoleWriter(rtbConsole, lblInfo);
            // create queue of main controls
            this.mainControls = new Stack<Control>();
            this.mainControls.Push(lblPingTarget);
            this.mainControls.Push(txbPingTarget);
            this.mainControls.Push(lblMode);
            this.mainControls.Push(cmbMode);
            this.mainControls.Push(lblRefreshRate);
            this.mainControls.Push(nudRefreshRate);
            this.mainControls.Push(chbInfiniteLoop);
            this.mainControls.Push(lblNumberOfPR);
            this.mainControls.Push(nudNumberOfPR);
            this.mainControls.Push(lblAttempts);
            this.mainControls.Push(nudAttempts);
            this.mainControls.Push(lblPacketSize);
            this.mainControls.Push(nudPacketSize);
            this.mainControls.Push(btnSendRequest);
        }

        /// <summary>
        /// Refreshes Request Run UI tab with data passed from RequestRun instance.
        /// </summary>
        /// <param name="requestRun"></param>
        public void OverwriteRequestRunUI(RequestRun requestRun)
        {
            lblSentActive.Text = requestRun.PacketsSent.ToString();
            lblRecievedActive.Text = requestRun.PacketsRecieved.ToString();
            lblLostActive.Text = requestRun.PacketsLost.ToString();
            lblMaximumActive.Text = $"{requestRun.MaxTime} ms";
            lblMinimumActive.Text = $"{requestRun.MinTime} ms";
            lblAverageActive.Text = $"{Math.Round(requestRun.AverageTime, 2)} ms";
        }

        /// <summary>
        /// Called when MainForm is created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initial values
            string fileName = "config/PreferencesConfig.json";
            var jsonService = new JsonService<Preferences>(fileName);
            var preferences = jsonService.LoadFileContent();

            // Combo Box - items
            cmbMode.Items.Add("Aggressive");
            cmbMode.Items.Add("Precise");

            // set components
            txbPingTarget.Text = preferences.PingTarget;
            cmbMode.Text = preferences.Mode;
            nudRefreshRate.Value = (decimal)preferences.RefreshRate;
            chbInfiniteLoop.Checked = preferences.InfiniteLoop;
            nudNumberOfPR.Value = (decimal)preferences.NumberOfPR;
            nudAttempts.Value = (decimal)preferences.Attempts;
            nudPacketSize.Value = (decimal)preferences.PacketSize;

            // check for infinite loop chb state and set controls state accordingly
            SetLockOnInfiniteLoopControls();

            // set stop button state
            btnStop.Enabled = false;
        }

        /// <summary>
        /// Changes Enabled property and colors text of labels.
        /// Method operates with private bool field numberOfTriesState
        /// </summary>
        private void SetLockOnInfiniteLoopControls()
        {
            bool numberOfTriesState = !chbInfiniteLoop.Checked;

            if (numberOfTriesState)
            {
                lblAttempts.ForeColor = System.Drawing.Color.Black;
                lblNumberOfPR.ForeColor = System.Drawing.Color.Black;
                nudAttempts.Enabled = true;
                nudNumberOfPR.Enabled = true;
            }
            else
            {
                lblAttempts.ForeColor = System.Drawing.Color.LightGray;
                lblNumberOfPR.ForeColor = System.Drawing.Color.LightGray;
                nudAttempts.Enabled = false;
                nudNumberOfPR.Enabled = false;
            }
        }

        /// <summary>
        /// Changes Enabled property of all input controls on the left side of the UI.
        /// </summary>
        private void SetLockOnControls()
        {
            if (this.controlsLocked)
            {
                foreach (var control in this.mainControls)
                    control.Enabled = true;
            }
            else
            {
                foreach (var control in this.mainControls)
                    control.Enabled = false;
            }

            btnStop.Enabled = !btnStop.Enabled;
            this.controlsLocked = !this.controlsLocked;
        }

        private void chbInfiniteLoop_Click(object sender, EventArgs e)
        {
            SetLockOnInfiniteLoopControls();
        }

        private async void btnSendRequest_Click(object sender, EventArgs e)
        {
            // lock controls
            SetLockOnControls();

            // create requester
            console.LogInfo("Creating Requester.");

            requester = new Requester(this)
            {
                RequestedAddress = txbPingTarget.Text,
                Mode = cmbMode.Text,
                RefreshRate = (int)nudRefreshRate.Value,
                NumberOfPR = (int)nudNumberOfPR.Value,
                Attempts = (int)nudAttempts.Value,
                InfiniteLoop = chbInfiniteLoop.Checked,
                PacketSize = (int)nudPacketSize.Value,
                StopSignal = false
            };

            // log warning if infinite loop is turned on
            if (requester.InfiniteLoop)
                console.LogWarning("Infinite loop is turned ON");

            // create request service instance
            var service = new RequestService(requester, this.console);

            // create RequestRun instance
            console.LogInfo("Initializing Request Run.");

            RequestRun requestRun = new RequestRun(this, requester.RequestedAddress, requester.PacketSize);
            requestRun.Init();
            requestRun.IPv4 = service.Hostname2Ipv4(requestRun.Hostname);
            requester.RequestRun = requestRun;

            // Write-in initial data into Request Run widgets
            lblPingingActive.Text = requestRun.Hostname;
            lblIpAdressActive.Text = requestRun.IPv4;
            lblPacketSizeRRActive.Text = requestRun.PacketSize.ToString();

            // begin sending requests
            string message = $"Seeking for {requestRun.Hostname}";

            if (!requestRun.Hostname.Equals(requestRun.IPv4))
                message += $" (ipv4={requestRun.IPv4})";

            message += $", started at: {DateTime.Now}";
            console.LogInfo(message);

            // start async. algorithm
            await service.BeginRequestingAsync();

            // requesting done
            console.LogInfo($"Pinging finished at: {DateTime.Now}");
            SetLockOnControls();
            btnStop.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            requester.StopSignal = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferencesForm preferencesWindow = new PreferencesForm(this);
            preferencesWindow.ShowDialog();
        }

        private void txbPingTarget_TextChanged(object sender, EventArgs e)
        {
            if (txbPingTarget.Text == "")
            {
                ;
            }
        }

        private void tbc_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* A workaround of the Console (richtextbox) artefact - bug.
             * This code solves the bug when UI from Request Run tab is being displayed in the Console tab.
             * Code bellow scrolls to the top and down again in order to get rid off the wrong pixels.
             * Artefact was appearing only when large number of ping requests was set.
             */

            if (tbc.SelectedIndex == 2)
            {
                rtbConsole.SelectionStart = 0;
                rtbConsole.ScrollToCaret();
                rtbConsole.SelectionStart = rtbConsole.TextLength;
                rtbConsole.ScrollToCaret();
            }
        }
    }
}
