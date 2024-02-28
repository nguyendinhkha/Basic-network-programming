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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }


        IPEndPoint IP;
        Socket server;
        List<Socket> ClientList;

        /// <summary>
        /// connect to the server
        /// </summary>
        void Connect()
        {
            ClientList = new List<Socket>();

            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);

            Thread listen = new Thread(() => {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        ClientList.Add(client);

                        Thread receive = new Thread(ReceiveMess);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }

        /// <summary>
        /// close the connection
        /// </summary>
        void CloseConnection()
        {
            server.Close();
        }

        /// <summary>
        /// send message
        /// </summary>
        void SendMess(Socket client)
        {
            if (client != null && message.Text != string.Empty)
            {
                client.Send(Serialize("Server: " + message.Text));
            }
        }

        /// <summary>
        /// receive message
        /// </summary>
        void ReceiveMess(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string mess = (string)Deserialize(data);

                    foreach(Socket item in ClientList)
                    {
                        if(item != null && item != client)
                        {
                            item.Send(Serialize(mess));
                        }
                    }

                    AddMessage(mess);
                }
            }
            catch
            {
                ClientList.Remove(client);
                client.Close();
            }
        }


        /// <summary>
        /// add message into chat view box
        /// </summary>
        void AddMessage(string s)
        {
            vmessage.Items.Add(new ListViewItem() { Text = s });
        }

        /// <summary>
        /// serialize (phân mảnh)
        /// </summary>
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }


        /// <summary>
        /// deserialize (tổng hợp mảnh)
        /// </summary>
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }


        /// <summary>
        /// Send message to all the client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Send_Click(object sender, EventArgs e)
        {
            foreach (Socket item in ClientList)
            {
                SendMess(item);
            }
            AddMessage(message.Text);
            message.Clear();
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseConnection();
        }
    }
}
