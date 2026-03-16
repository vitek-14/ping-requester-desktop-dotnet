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
        private Color backColor;

        public SessionRow(string target, string srl, string timeStamp, int preferencesId, Color bgColor)
        {
            InitializeComponent();

            this.preferencesId = preferencesId;
            lblTarget.Text = target;
            lblSRL.Text = srl;
            lblTimeStamp.Text = timeStamp;
            backColor = bgColor;

            tlpSession.BackColor = backColor;
        }

        private void OnMouseEnter()
        {
            tlpSession.BackColor = Color.LightBlue;
        }

        private void OnMouseLeave()
        {
            tlpSession.BackColor = backColor;
        }

        private void btnPreferences_Click(object sender, EventArgs e)
        {
            ;
        }

        private void lblTarget_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter();
        }

        private void lblTarget_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave();
        }

        private void lblSRL_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter();
        }

        private void lblSRL_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave();
        }

        private void lblTimeStamp_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter();
        }

        private void lblTimeStamp_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave();
        }

        private void btnDetails_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter();
        }

        private void btnDetails_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave();
        }

        private void tlpSession_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter();
        }

        private void tlpSession_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave();
        }
    }
}
