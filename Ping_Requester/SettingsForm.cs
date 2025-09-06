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

            chbShowNotification.Checked = settings.ShowNotification;
            chbMakeSound.Checked = settings.MakeSound;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings
            {
                ShowNotification = chbShowNotification.Checked,
                MakeSound = chbMakeSound.Checked
            };

            jsonService.WriteFileContent(settings);
            this.Close();
        }
    }
}
