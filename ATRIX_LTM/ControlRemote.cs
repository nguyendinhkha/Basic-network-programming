using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATRIX_LTM
{
    public partial class ControlRemote : Form
    {
        public static string ipAddress;
        public static string username;
        public static string passwd;

        bool pingable = false;
        PCForm pcForm;

        public ControlRemote()
        {
            InitializeComponent();
        }

        private void btnClosing_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ping_Click(object sender, EventArgs e)
        {
            try
            {
                Ping pinger = new Ping();
                string IpAddress = txtb_ip.Text.Trim();
                PingReply pingReply = pinger.Send(IpAddress);

                pingable = pingReply.Status == IPStatus.Success;

                if (pingable == true)
                {
                    MessageBox.Show("Connection Success", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_connect.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Connection Timed Out", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Wrong Input IP!!!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            btn_connect.Enabled = false;
            System.Threading.Thread.Sleep(5000);
            if (!PCForm.status == true)
            {
                btn_connect.Enabled = true;
            }
            ipAddress = txtb_ip.Text.Trim();
            username = txtb_username.Text.Trim();
            passwd = txtb_pass.Text.Trim();

            pcForm = new PCForm();
            pcForm.Show();
        }
    }
}
