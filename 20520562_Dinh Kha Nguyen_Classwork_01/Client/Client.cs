using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;      // not allowing to check
            Connect();
        }

        /// <summary>
        /// gửi tin đi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSend_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage(textBoxMessage.Text);
        }

        // Need:
        // * Socket
        // * IP
        IPEndPoint IP;
        Socket client;

        /// <summary>
        /// Connect to server
        /// </summary>
        void Connect()
        {
            // IP: địa chỉ của server
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);      // Connect to server
            }
            catch
            {
                MessageBox.Show("Cannot connect to the server !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;                  // If can't connect, try to connect again
            }
  
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();

        }

        /// <summary>
        /// đóng kết nối
        /// </summary>
        void close()
        {
            client.Close();
        }

        /// <summary>
        /// gửi tin
        /// </summary>
        void Send()
        {
            if (textBoxMessage.Text != string.Empty)
                client.Send(Seriaiize(textBoxMessage.Text));
        }

        /// <summary>
        /// nhận tin
        /// </summary>
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);     // receive message from server, will display them in the chat frame ListBoxView
                    AddMessage(message);
                }
            }
            catch
            {
                Close();
            }
        }

        /// <summary>
        /// add message into the chat frame
        /// </summary>
        /// <param name="s"></param>
        void AddMessage(string s)
        {
            ListViewMessage.Items.Add(new ListViewItem() { Text = s } );
            textBoxMessage.Clear();     // after sending, clear it 
        }

        /// Fragmentation
        byte[] Seriaiize(object obj)        // fragmenting data requires a string with a format
        { 
            MemoryStream stream = new MemoryStream();  // a stream is a direct connection, used to write connections onto it.
            BinaryFormatter formatter = new BinaryFormatter();
            
            formatter.Serialize(stream, obj);     // the thing you want to serialize is a stream, followed by the data value you want to serialize.
                                                 // Meaning: Fragmentation
            return stream.ToArray();           // this stream will output a series of bytes.
        }

        /// reassemble fragments
        object Deserialize(byte[] data)             // is of string type because its sending and receiving of messages, specifically chat lines, then the data type is string.
        {
            MemoryStream stream = new MemoryStream(data);  // pass the data itself in
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);     // pass the stream itself in, and return the object back.
        }

        /// <summary>
        /// close the connection when closing the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }
    }
}
