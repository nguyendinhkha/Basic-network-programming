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
using System.Net;
using System.Threading;
using System.Data.SqlClient;

namespace UDP_Server
{
    public partial class Form1 : Form
    {
        delegate void InfoMessDelete(String info);
        public Form1()
        {
            InitializeComponent();
        }

        public void InfoMessage(string info)
        {
            if (listView1.InvokeRequired)
            {
                InfoMessDelete process = new InfoMessDelete(InfoMessage);
                listView1.Invoke(process, new object[] { info });
                return;
            }
            listView1.Items.Add(info);
        }

        public void serverThread()
        {
            int serverport = int.Parse(txtPort.Text.ToString());
            
            UdpClient udpClient = new UdpClient(serverport);

            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBts = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBts);
                string mess = RemoteIpEndPoint.Address.ToString() + ":" + returnData.ToString();

                InfoMessage(mess);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread thrdUdpServer = new Thread(new ThreadStart(serverThread));
            thrdUdpServer.Start();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            var portstring = txtPort.Text.Trim();
            int serverport = int.Parse(portstring);
            UdpClient udp = new UdpClient(serverport);

            udp.JoinMulticastGroup(IPAddress.Parse(portstring), 0);
            IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Any, 0);
            byte[] data = udp.Receive(ref ipendpoint);
            string stringData = Encoding.ASCII.GetString(data, 0, data.Length);
            Form1_Load(sender, e);
            udp.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
