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
        private string filename;
        public SettingsForm()
        {
            InitializeComponent();
            this.filename = "config/SettingsConfig.json";
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            JsonService<Settings> service = new JsonService<Settings>(this.filename);
            Settings settings = service.LoadFileContent();

            chbMakeSound.Enabled = settings.MakeSound;
            chbShowNotification.Enabled = settings.ShowNotification;
        }
    }
}
