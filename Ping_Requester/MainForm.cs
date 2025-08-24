using PingRequester.App;
using PingRequester.BusinessLayer;
using PingRequester.Data;
using PingRequester.Data.DataObjects;

namespace PingRequester.Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initial values
            // Combo Box
            cmbMode.Items.Add("Aggressive");
            cmbMode.Items.Add("Precise");
            cmbMode.Text = "Aggressive";
            // adress input - temporary
            txbPingTarget.Text = "www.seznam.cz";
            // Checkboxes
            chbInfiniteLoop.Checked = true;

            // NumericUpDowns
            nudRefreshRate.Value = 2;
            nudAttempts.Value = 30;
            nudNumberOfPR.Value = 2;

            // check for infinite loop chb state
            SetAttemptsState();
        }

        private void SetAttemptsState()
        {
            bool numberOfTriesState = WidgetController.GetNumberOfTriesState(chbInfiniteLoop.Checked);

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

        private void chbInfiniteLoop_Click(object sender, EventArgs e)
        {
            SetAttemptsState();
        }

        private async void btnSendRequest_Click(object sender, EventArgs e)
        {
            // create requester
            var requester = new Requester()
            {
                RequestedAdress = txbPingTarget.Text,
                Mode = cmbMode.Text,
                RefreshRate = (int)nudRefreshRate.Value,
                NumberOfPR = (int)nudNumberOfPR.Value,
                Attempts = (int)nudAttempts.Value,
                InfiniteLoop = chbInfiniteLoop.Checked
            };

            // create request service instance
            var service = new RequestService(requester);

            // begin sending requests
            await service.BeginRequestingAsync();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferencesForm preferencesWindow = new PreferencesForm();
            preferencesWindow.ShowDialog();
        }
    }
}
