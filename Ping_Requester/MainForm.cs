namespace Ping_Requester
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
    }
}
