using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace TCPServer
{
    public partial class Bai2_TCPServer : Form
    {
        public Bai2_TCPServer()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            //Tao thread
            Thread serverThread = new Thread(new ThreadStart(ServerListen));
            serverThread.IsBackground = true;
            serverThread.Start();
        }

        void ServerListen()
        {
            int Brecv = 0;
            //Khoi tao mang byte nhan du lieu
            Byte[] recv = new byte[1];

            //Tao socket ben gui
            Socket client;

            //Create reciever's socket 
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipend = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            
            //Gan socket lang nghe toi dia chi IP loopback va port 8080
            listener.Bind(ipend);

            //Bat dau lang nghe
            listener.Listen(-1);

            //Dong y ket noi
            client = listener.Accept();
            view.Items.Add(new ListViewItem("New client connected successfully!"));

            //Nhan du lieu trong khi ket noi voi client
            while(client.Connected)
            {
                string data = "";
                do
                {
                    Brecv = client.Receive(recv);
                    data += Encoding.ASCII.GetString(recv);
                } while (data[data.Length - 1] != '\n');
                view.Items.Add(new ListViewItem(data));
            }
            listener.Close();
        }
    }
}
