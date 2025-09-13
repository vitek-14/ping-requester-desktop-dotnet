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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings
            {
                AlertOnSuccess = chbAlertOnSuccess.Checked,
                MakeSound = chbMakeSound.Checked,
                AlertOnPingCompletion = chbAlertOnPingCompletion.Checked
            };

            jsonService.WriteFileContent(settings);
            this.Close();
        }
    }
}
