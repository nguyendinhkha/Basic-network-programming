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

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();

            // Retrieve the IP address from the textbox and convert it into IPAddress type.
            IPAddress ipadd = IPAddress.Parse(textHost.Text);
            int port = Convert.ToInt32(textPort.Text);
            IPEndPoint ipend = new IPEndPoint(ipadd, port);

            // Convert the input data string into a byte type.
            Byte[] sendBytes = Encoding.UTF8.GetBytes(Message.Text);

            // Send data to the IPEndPoint that has defined the IP address and Port.
            udpClient.Send(sendBytes, sendBytes.Length, ipend);

            // Clear the data just sent in the input box.
            Message.Text = "";

        }
    }
}
