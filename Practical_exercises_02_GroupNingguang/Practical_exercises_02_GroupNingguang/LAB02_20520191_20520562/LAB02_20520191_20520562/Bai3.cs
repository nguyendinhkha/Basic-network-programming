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
    public partial class Bai3 : Form
    {
        public Bai3()
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
                content = content.Replace("\r\n", ","); // Thay đổi mỗi lần xuống dòng bằng dấu phẩy
                string[] calc = content.Split(','); // Tách các phép tính bằng dấu phẩy

                foreach (string st in calc)
                {
                    View.Items.Add(new ListViewItem() { Text = st });
                }
            }
            catch
            {
                MessageBox.Show("Error !!!. File is not in the correct format. ");
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            try
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);

                StreamWriter sw = new StreamWriter(fs);
                foreach (ListViewItem item in View.Items)
                {
                    sw.Write(item.Text + "\n");
                }
                MessageBox.Show("File saved successfully !");
                sw.Close();
            }
            catch
            {
                MessageBox.Show("Error !!!. File Already Exists or File haven't saved yet. ");
            }
        }
 
        private void calculate_Click(object sender, EventArgs e)
        {
            // Xử lý từng phép tính trong file
            foreach (ListViewItem item in View.Items)
            {
                string[] s2 = item.Text.Trim().Split(' '); // Tách các thứ hạng trong phép tính
                float integer1 = float.Parse(s2[0]);
                float integer2 = float.Parse(s2[1].Substring(1, s2[1].Length - 1));
                float result = 0;
                switch (s2[1].Substring(0, 1))
                {
                    case "/":
                        result = integer1 / integer2;
                        break;
                    case "-":
                        result = integer1 - integer2;
                        break;
                    case "+":
                        result = integer1 + integer2;
                        break;
                    case "*":
                        result = integer1 * integer2;
                        break;
                    default:
                        MessageBox.Show("Error in finding math symbol.");
                        break;
                }
                // Update kết quả của từng phép tính
                item.Text = item.Text + " = " + result.ToString();
                //MessageBox.Show("Calculated successfully !");
            }
            MessageBox.Show("Calculated successfully !");
        }
    }
}
