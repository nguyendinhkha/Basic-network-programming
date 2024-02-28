using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace UDP_test
{
    public partial class Form1 : Form
    {
        delegate void InfoMessDelete(String info);

        public Form1()
        {
            InitializeComponent();
        }
  
        private void btnSend_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();

            //var ipString = Console.ReadLine();
            var ipString = txt_IP_Remote_Host.Text.Trim();
            var serverIp = IPAddress.Parse(ipString);

            //var portString = Console.ReadLine();
            var portstring = txtPort.Text.Trim();
            int serverport = int.Parse(portstring);
            udpClient.Connect(serverIp, serverport);

            //var socket = new Socket(SocketType.Dgram, ProtocolType.Udp);
            string message = txt_Message.Text.ToString();
            Byte[] transmit = Encoding.ASCII.GetBytes(message);
            udpClient.Send(transmit, transmit.Length);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txt_Message.Text = txt_IP_Remote_Host.Text = txtPort.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
