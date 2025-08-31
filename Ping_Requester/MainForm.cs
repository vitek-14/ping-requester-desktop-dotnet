using PingRequester.BusinessLayer;
using PingRequester.Data;
using PingRequester.Data.DataObjects;

namespace PingRequester.Client
{
    public partial class MainForm : Form
    {
        private ConsoleWriter console;
        private bool controlsLocked;
        private Stack<Control> mainControls;

        public MainForm()
        {
            InitializeComponent();
            this.controlsLocked = false;
            this.console = new ConsoleWriter(rtbConsole);
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

            console.LogInfo("This is info");
            console.LogMessage("This is message");
            console.LogWarning("This is warning");
            console.LogError("This is error");
        }

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
            // Lock controls
            SetLockOnControls();

            // create requester
            var requester = new Requester()
            {
                RequestedAddress = txbPingTarget.Text,
                Mode = cmbMode.Text,
                RefreshRate = (int)nudRefreshRate.Value,
                NumberOfPR = (int)nudNumberOfPR.Value,
                Attempts = (int)nudAttempts.Value,
                InfiniteLoop = chbInfiniteLoop.Checked,
                PacketSize = (int)nudPacketSize.Value
            };

            // create RequestRun instance
            RequestRun requestRun = new RequestRun(requester.RequestedAddress, requester.PacketSize);
            requestRun.Init();
            requester.RequestRun = requestRun;

            // create request service instance
            var service = new RequestService(requester, this.console);

            // begin sending requests
            await service.BeginRequestingAsync();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // unset lock on controls
            SetLockOnControls();

            // further logic
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
    }
}
