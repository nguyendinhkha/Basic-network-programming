using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Bai3_Client
{
    public partial class btnTCPClient : Form
    {
        public btnTCPClient()
        {
            InitializeComponent();
        }

        TcpClient client = default(TcpClient);
        NetworkStream stream = default(NetworkStream);

        private void btnSend_Click(object sender, EventArgs e)
        {         
            //stream write de gui du lieu
            Byte[] data = System.Text.Encoding.ASCII.GetBytes("Hello server\n");
            stream.Write(data, 0, data.Length);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            stream.Close();
            client.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPEndPoint ipend = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client = new TcpClient();
            client.Connect(ipend);

            //Tao luong
            stream = client.GetStream();
        }
    }
}
