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
    /// Informative window that displays after saving settings with changed console color theme.
    /// </summary>
    public partial class MessageBoxChangesAfterRestart : Form
    {
        public MessageBoxChangesAfterRestart()
        {
            InitializeComponent();
            pcbInfoIcon.Image = SystemIcons.Information.ToBitmap();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
