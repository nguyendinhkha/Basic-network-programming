using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_Client
{
    public partial class TCPCLient : Form
    {
        public TCPCLient()
        {
            InitializeComponent();
        }

        private void btnTCPServer_Click(object sender, EventArgs e)
        {
            //Open new server
            btnTCPServer server = new btnTCPServer();
            server.Show();
        }

        private void btnTCPClient_Click(object sender, EventArgs e)
        {
            //Open new client
            btnTCPClient client = new btnTCPClient();
            client.Show();
        }
    }
}
