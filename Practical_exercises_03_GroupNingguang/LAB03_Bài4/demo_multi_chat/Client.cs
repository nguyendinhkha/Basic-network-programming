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

namespace demo_multi_chat
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;  
            Connect();
        }

        IPEndPoint IP;
        Socket client;

        /// <summary>
        /// connect to the server
        /// </summary>
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Error !!", "Cannot connect to the server :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(ReceiveMess);
            listen.IsBackground = true;
            listen.Start();
        }

        /// <summary>
        /// close the connection
        /// </summary>
        void CloseConnection()
        {
            client.Close();
        }

        /// <summary>
        /// send message
        /// </summary>
        void SendMess()
        {
            if(message.Text != string.Empty)
            {
                client.Send(Serialize(nickname.Text + ": " + message.Text));
            }
        }

        /// <summary>
        /// receive message
        /// </summary>
        void ReceiveMess()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string mess = (string)Deserialize(data);

                    AddMessage(mess);
                }
            }
            catch
            {
                CloseConnection();
            }
        }


        /// <summary>
        /// add message into chat view box
        /// </summary>
        void AddMessage(string s)
        {
            vmessage.Items.Add(new ListViewItem() { Text =  s });
            message.Clear();
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
        /// Close connection when closing the form
        /// </summary>
        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseConnection();
        }



        /// <summary>
        /// Click send button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Send_Click(object sender, EventArgs e)
        {
            if (nickname.Text != string.Empty)
            {
                nickname.ReadOnly = true;
                SendMess();
                AddMessage(message.Text);
            }
            else
            {
                MessageBox.Show("What is your name ?");
            }
        }
    }
}
