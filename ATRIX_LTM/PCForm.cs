using MSTSCLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATRIX_LTM
{
    public partial class PCForm : Form
    {
        public static bool status = false;
        public PCForm()
        {
            InitializeComponent();
        }

        private void PCForm_Load(object sender, EventArgs e)
        {
            string ipAddress = ControlRemote.ipAddress;
            string username = ControlRemote.username;
            string passwd = ControlRemote.passwd;

            MsRdpClient9NotSafeForScripting secured = (MsRdpClient9NotSafeForScripting)rdp.GetOcx();
            rdp.Server = ipAddress;
            rdp.UserName = username;
            secured.AdvancedSettings9.ClearTextPassword = passwd;
            secured.AdvancedSettings9.EnableCredSspSupport = true;

            rdp.Connect();
            rdp.FullScreen = true;

            if (rdp.Connected.ToString() == "1")
            {
                status = true;
            }
        }

        private void PCForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rdp.Connected.ToString() == "1")
            {
                string message = "Disconnect ?";
                string title = "Message box";
                DialogResult DR = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
                if (DR == DialogResult.Yes)
                {
                    rdp.Disconnect();
                    status = false;
                }
            }
        }

        private void rdp_OnConnecting(object sender, EventArgs e)
        {
            ((AxMSTSCLib.AxMsRdpClient9)sender).FullScreen = true;
        }
    }
}
