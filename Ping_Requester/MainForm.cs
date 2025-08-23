using PingRequester.App;
using PingRequester.Data;

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
            // Checkboxes
            chbInfiniteLoop.Checked = true;
            chbMakeSound.Checked = true;
            chbShowNotification.Checked = true;

            // NumericUpDowns
            nudSpaceBetweenPR.Value = 2;
            nudNumberOfTries.Value = 30;
            nudNumberOfPR.Value = 3;
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

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            var requester = new Requester()
            {
                RequestedAdress = txbPingTarget.Text,
                PauseTime = (int)nudSpaceBetweenPR.Value,
                NumberOfPR = (int)nudNumberOfPR.Value,
                NumberOfTries = (int)nudNumberOfTries.Value,
                InfiniteLoop = chbInfiniteLoop.Checked,
                MakeSound = chbMakeSound.Checked,
                ShowNotification = chbShowNotification.Checked
            };


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
