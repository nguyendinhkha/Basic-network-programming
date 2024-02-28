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
using System.Threading;

namespace Bai3_Client
{
    public partial class btnTCPServer : Form
    {
        public btnTCPServer()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(ServerListen));
            serverThread.IsBackground = true;
            serverThread.Start();
        }

        TcpListener Server = default(TcpListener);
        TcpClient client = default(TcpClient);
        NetworkStream stream = default(NetworkStream);

        void ServerListen()
        {
            try
            {
                Server = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
                // Start listening for client requests.
                Server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;

                //Stop to wait for request
                client = Server.AcceptTcpClient();
                AddMessage("Connected!");

                stream = client.GetStream();

                int i;

                // Loop to receive all the data sent by the client.
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);

                    AddMessage(data);
                }

                // Shutdown and end connection
                stream.Close();
                client.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        void AddMessage(string s)
        {
            view.Items.Add(new ListViewItem() { Text = s });
        }

        private void btnTCPServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Server.Stop();
        }
    }
}

