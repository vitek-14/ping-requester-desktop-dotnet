using PingRequester.BusinessLayer;
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
    public partial class PreferencesForm : Form
    {
        private MainForm _mainForm;
        private JsonService<Preferences> jsonService;

        public PreferencesForm(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;
            this.jsonService = new JsonService<Preferences>("config/PreferencesConfig.json");
        }

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
            nudNumberOfPR.Value = _mainForm.NumberOfPR;
            nudAttempts.Value = _mainForm.Attempts;
            nudPacketSize.Value = _mainForm.PacketSize;

            // Set components not present in the MainForm - load them from config file
            var preferences = this.jsonService.LoadFileContent();
            chbMakeSound.Checked = preferences.MakeSound;
            chbShowNotification.Checked = preferences.ShowNotification;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var preferences = this.jsonService.LoadFileContent();

            preferences.PingTarget = txbPingTarget.Text;
            preferences.Mode = cmbMode.Text;
            preferences.RefreshRate = (int)nudRefreshRate.Value;
            preferences.NumberOfPR = (int)nudNumberOfPR.Value;
            preferences.Attempts = (int)nudAttempts.Value;
            preferences.PacketSize = (int)nudPacketSize.Value;
            preferences.ShowNotification = chbShowNotification.Checked;
            preferences.MakeSound = chbMakeSound.Checked;
            preferences.InfiniteLoop = chbInfiniteLoop.Checked;

            this.jsonService.WriteFileContent(preferences);
            this.Close();
        }
    }
}
