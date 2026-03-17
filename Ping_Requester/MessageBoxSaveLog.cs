namespace PingRequester.Client
{
    /// <summary>
    /// MessageBox warning about unsaved log in the console.
    /// </summary>
    public partial class MessageBoxSaveLog : Form
    {
        FormClosingEventArgs closingEvent;

        public MessageBoxSaveLog(FormClosingEventArgs e)
        {
            InitializeComponent();
            this.closingEvent = e;
            pcbWarningIcon.Image = SystemIcons.Warning.ToBitmap();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            closingEvent.Cancel = true;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
