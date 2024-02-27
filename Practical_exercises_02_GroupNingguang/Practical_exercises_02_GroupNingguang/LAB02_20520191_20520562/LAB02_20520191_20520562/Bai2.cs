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
    public partial class Bai2 : Form
    {
        public Bai2()
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

                // dùng hàm ReadToEnd() để đọc tất cả các đầu vào từ vị trí hiện tại đến cuối luồng.
                // Sau đó đẩy dữ liệu vào richTextBox.
                string content = sr.ReadToEnd();
                richTextBox1.Text = content;
                fs.Close();

                // Đọc tên file
                textTenFile.Text = ofd.SafeFileName;

                // Lấy đường dẫn file
                textURL.Text = ofd.FileName;

                // Count number of character in a file
                // Đếm số kí tự trong file
                long CharCount = content.Length;
                textCharCount.Text = CharCount.ToString();

                // Count number of line in a file
                // Đếm số dòng trong file
                content = content.Replace("\r\n", "\r");
                long LineCount = richTextBox1.Lines.Count();
                textLineCount.Text = LineCount.ToString();
                content = content.Replace('\r', ' ');

                // Count number of word in a file
                // Đếm số từ trong file
                string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                long WordCount = source.Count();
                textWordCount.Text = WordCount.ToString();
            }
            catch
            {
                MessageBox.Show("Error !!!. File is not in the correct format. ");
            }
        }
    }
}
