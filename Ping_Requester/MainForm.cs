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
            // adress input - temporary
            txbPingTarget.Text = "www.seznam.cz";
            // Checkboxes
            chbInfiniteLoop.Checked = true;
            chbMakeSound.Checked = true;
            chbShowNotification.Checked = true;

            // NumericUpDowns
            nudRefreshRate.Value = 2;
            nudNumberOfTries.Value = 30;
            nudNumberOfPR.Value = 2;
        }

        private void chbInfiniteLoop_Click(object sender, EventArgs e)
        {
            bool numberOfTriesState = WidgetController.GetNumberOfTriesState(chbInfiniteLoop.Checked);

            if (numberOfTriesState)
            {
                lblNumberOfTries.ForeColor = System.Drawing.Color.LightGray;
                nudNumberOfTries.Enabled = false;
            }
            else
            {
                lblNumberOfTries.ForeColor = System.Drawing.Color.Black;
                nudNumberOfTries.Enabled = true;
            }
        }

        private async void btnSendRequest_Click(object sender, EventArgs e)
        {
            // create requester
            var requester = new Requester()
            {
                RequestedAdress = txbPingTarget.Text,
                RefreshRate = (int)nudRefreshRate.Value,
                NumberOfPR = (int)nudNumberOfPR.Value,
                NumberOfTries = (int)nudNumberOfTries.Value,
                InfiniteLoop = chbInfiniteLoop.Checked,
                MakeSound = chbMakeSound.Checked,
                ShowNotification = chbShowNotification.Checked
            };

            var service = new RequestService(requester);

            await service.BeginRequestingAsync();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
