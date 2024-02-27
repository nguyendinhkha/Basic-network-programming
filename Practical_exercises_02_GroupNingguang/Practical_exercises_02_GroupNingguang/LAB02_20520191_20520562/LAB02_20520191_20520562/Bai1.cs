using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LAB02_20520191_20520562
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            // ĐỌC FILE
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            try
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                // khai báo đối tượng StreamReader
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                richTextBox1.Text = content;
                fs.Close();
            }
            catch
            {
                MessageBox.Show("Error !!!. File is not in the correct format. ");
            }
        }

        private void buttonWriteFile_Click(object sender, EventArgs e)
        {
            // GHI FILE            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            try
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);
                // Khai báo đối tượng StreamWriter
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(richTextBox1.Text.ToUpper());
                MessageBox.Show("File saved successfully !");
                sw.Close();
                
            }
            catch
            {
                MessageBox.Show("Error !!!. File is not in the correct format. ");
            }
        }
    }
}
