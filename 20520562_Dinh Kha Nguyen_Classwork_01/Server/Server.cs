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
using System.Collections.Generic;
using System;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            Connect();
        }

        /// <summary>
        /// Closing the connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// sending mesages to all clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSend_Click(object sender, EventArgs e)
        {
            // each client in the client list will send a message
            foreach (Socket item in clientlist)
            {
                Send(item);
            }
            AddMessage(textBoxMessage.Text);
            textBoxMessage.Clear(); 
        }

        // Need:
        // * Socket
        // * IP
        IPEndPoint IP;
        Socket server;
        List<Socket> clientlist;

        /// <summary>
        /// Connect to the server
        /// </summary>
        void Connect()
        {
            clientlist = new List<Socket>();
            // IP: The address of the server
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);          // Receiving the IP... 

            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);    // allow 100 people in the queue to wait for processing
                        Socket client = server.Accept();

                        clientlist.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);      // based on the Client
                    }
                }
                catch
                { 
                    // reinitialize IP and server.
                    IP = new IPEndPoint(IPAddress.Any, 9999);                                                
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
                  
            });
            Listen.IsBackground = true;
            Listen.Start();
        }

        /// <summary>
        /// Closing the connection
        /// </summary>
        void close()
        {
            server.Close();
        }

        /// <summary>
        /// Sending message
        /// </summary>
        void Send(Socket client)
        {
            if (client != null && textBoxMessage.Text != string.Empty)
                client.Send(Seriaiize(textBoxMessage.Text));
        }

        /// <summary>
        ///  Receiving message
        /// </summary>
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);     // nhận message từ server, sẽ đưa lên khung chat ListBoxView

                    foreach (Socket item in clientlist)
                    {
                        if (item != null)
                            item.Send(Seriaiize(message));
                    }    
                    AddMessage(message);
                }
            }
            catch
            {
                clientlist.Remove(client);
                client.Close();
            }
        }

        /// <summary>
        /// add message into the chat frame
        /// </summary>
        /// <param name="s"></param>
        void AddMessage(string s)
        {
            ListViewMessage.Items.Add(new ListViewItem() { Text = s } );
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

    }
}
