using PingRequester.BusinessLayer;
using PingRequester.BusinessLayer.Services;
using PingRequester.Data.DataObjects;
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
    /// PreferencesForm class.
    /// This class is meant to be instantiated as ShowDialog.
    /// </summary>
    public partial class PreferencesForm : Form
    {
        private MainForm _mainForm;
        private JsonService<Preferences> jsonService;

        /// <summary>
        /// Default constructor of the PreferencesForm
        /// </summary>
        /// <param name="mainForm"></param>
        public PreferencesForm(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;
            this.jsonService = new JsonService<Preferences>(PathProvider.GetWritablePath("config/PreferencesConfig.json"));
        }

        /// <summary>
        /// Called when PreferencesForm is created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            // Combo box - set items
            cmbMode.Items.Add("Aggressive");
            cmbMode.Items.Add("Precise");

            // Set components
            txbPingTarget.Text = _mainForm.PingTarget;
            cmbMode.Text = _mainForm.Mode;
            nudRefreshRate.Value = _mainForm.RefreshRate;
            chbInfiniteLoop.Checked = _mainForm.InfiniteLoop;
            chbStopWhenSuccess.Checked = _mainForm.StopWhenSuccess;
            nudNumberOfPR.Value = _mainForm.NumberOfPR;
            nudAttempts.Value = _mainForm.Attempts;
            nudPacketSize.Value = _mainForm.PacketSize;
            chbAutoSave.Checked = _mainForm.AutoSave;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // get Preferences instance from json data
            var preferences = this.jsonService.LoadFileContent();

            // set new values
            preferences.PingTarget = txbPingTarget.Text;
            preferences.Mode = cmbMode.Text;
            preferences.RefreshRate = (int)nudRefreshRate.Value;
            preferences.NumberOfPR = (int)nudNumberOfPR.Value;
            preferences.Attempts = (int)nudAttempts.Value;
            preferences.PacketSize = (int)nudPacketSize.Value;
            preferences.InfiniteLoop = chbInfiniteLoop.Checked;
            preferences.StopWhenSuccess = chbStopWhenSuccess.Checked;
            preferences.AutoSave = chbAutoSave.Checked;

            // serialize data from instance to a json file
            this.jsonService.WriteFileContent(preferences);
            this.Close();
        }
    }
}
