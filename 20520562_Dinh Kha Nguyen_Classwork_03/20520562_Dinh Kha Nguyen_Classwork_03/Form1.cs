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
using System.IO;
using System.Web;

namespace _20520562_Bai_Tap_Tai_Lop_03
{
    public partial class Form1 : Form
    {
        WebClient wc = new WebClient();
        public Form1()
        {
            InitializeComponent();
        }

        private string OpenToRead(string s)
        {
            string clarification = "";

            // the OpenRead function is used to open a readable stream for data downloaded from a resource with the specified URL as a string.
            Stream str = wc.OpenRead(s);
            // Use StreamReader to read the file
            StreamReader sr = new StreamReader(str);
            // the .Peek() function returns the next available character but does not consume it.
            while (sr.Peek() > - 1)
            {
                clarification += sr.ReadLine();
            }
            
            // after using then we need to close streamreader
            sr.Close();
            return clarification;
        }

        // button has the function of downloading data from the web
        private void btnDownload_Click(object sender, EventArgs e)
        {

            // the .Trim() function returns a new string from which all leading and trailing occurrences of a set of specified characters in the current string are removed.
            if (textURL.Text.Trim() == "")
            {
                MessageBox.Show("ERROR !!! Please enter the correct URL. ");
                // the .Focus() function returns true if the request to set input focus is successful; otherwise, false.
                textURL.Focus();
                return;
            }

            if (fileSaveDes.Text.Trim() == "")
            {
                MessageBox.Show("ERROR !!! Please enter the correct file destination. ");
                fileSaveDes.Focus();
                return;
            }

            // use try catch to check data when downloading a file.
            try
            {
                wc.DownloadFile(textURL.Text, fileSaveDes.Text);

                // 
                txtView.Text = OpenToRead(fileSaveDes.Text);
                MessageBox.Show("File downloaded successfully !!! ");
            }
            // use WebException: an exception that is thrown when an error occurs while accessing the network through a pluggable protocol.
            catch (WebException wex)
            {
                //Receive a message describing the current exception
                txtView.Text = wex.Message;
                // Message for error notification, a message that helps explain the cause of the exception or to leave as an empty string
            }
        }

        // the button show will display the contents of the fiel.html file on the txtView textbox
        private void btnShow_Click_1(object sender, EventArgs e)
        {
            if (fileSaveDes.Text.Trim() == "")
            {
                MessageBox.Show("ERRROR !!! Please enter the correct file destination. ");
                fileSaveDes.Focus();
                return;
            }

            // declare FileStream to read and write data to a file
            FileStream fs = new FileStream(fileSaveDes.Text, FileMode.Open);

            //  Note: Byte arrays can represent any values but each invidual byte can only hold a certain range
            byte[] bit = new Byte[fs.Length];
            fs.Read(bit, 0, (int)fs.Length);
            fs.Close();

            string s = Encoding.UTF8.GetString(bit);
            txtView.Text = s;
        }

        private void btnGetFileDes_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
                fileSaveDes.Text = ofd.FileName;
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string s = sr.ReadToEnd();
                txtView.Text = s;
                fs.Close();


        }
    }
}
