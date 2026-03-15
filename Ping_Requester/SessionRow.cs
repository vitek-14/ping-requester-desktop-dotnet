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
    public partial class SessionRow : UserControl
    {
        private int preferencesId;

        public SessionRow(string target, string srl, string timeStamp, int preferencesId)
        {
            InitializeComponent();

            this.preferencesId = preferencesId;
            lblTarget.Text = target;
            lblSRL.Text = srl;
            lblTimeStamp.Text = timeStamp;
        }

        private void btnPreferences_Click(object sender, EventArgs e)
        {
            ;
        }
    }
}
