using Microsoft.WindowsAPICodePack.Dialogs;
using PingRequester.BusinessLayer;
using PingRequester.Data.DataObjects;

namespace PingRequester.Client
{
    public partial class SettingsForm : Form
    {
        private JsonService<Settings> jsonService;

        public SettingsForm()
        {
            InitializeComponent();
            this.jsonService = new JsonService<Settings>("config/SettingsConfig.json");
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Settings settings = jsonService.LoadFileContent();

            chbAlertOnSuccess.Checked = settings.AlertOnSuccess;
            chbMakeSound.Checked = settings.MakeSound;
            chbAlertOnPingCompletion.Checked = settings.AlertOnPingCompletion;
            chbAskToSaveLogBeforeClosing.Checked = settings.AskToSaveLog;
            txbLogFilesPath.Text = settings.PathToLogFiles;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // verify path
            if (!Directory.Exists(txbLogFilesPath.Text))
            {
                MessageBox.Show("Path to the log files does not exists.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // creates Settigns instance to be written into the json
            Settings settings = new Settings
            {
                AlertOnSuccess = chbAlertOnSuccess.Checked,
                MakeSound = chbMakeSound.Checked,
                AlertOnPingCompletion = chbAlertOnPingCompletion.Checked,
                AskToSaveLog = chbAskToSaveLogBeforeClosing.Checked,
                PathToLogFiles = txbLogFilesPath.Text
            };

            // save to json
            jsonService.WriteFileContent(settings);
            this.Close();
        }

        private void btnFolderBrowserDialog_Click(object sender, EventArgs e)
        {
            // setup file dialog
            var fileDialog = new CommonOpenFileDialog();
            string path = AppDomain.CurrentDomain.BaseDirectory;
            fileDialog.InitialDirectory = path;
            fileDialog.IsFolderPicker = true;

            // open and proceed file dialog
            if (fileDialog.ShowDialog() == CommonFileDialogResult.Ok)
                txbLogFilesPath.Text = fileDialog.FileName;
        }
    }
}
