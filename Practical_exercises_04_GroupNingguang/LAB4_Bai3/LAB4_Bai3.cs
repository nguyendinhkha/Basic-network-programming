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

namespace LAB4_Bai3
{
    public partial class LAB4_Bai3 : Form
    {
        WebClient wc = new WebClient();
        public LAB4_Bai3()
        {
            InitializeComponent();
        }

        private string OpenToRead(string s)
        {
            string clarification = "";

            // hàm OpenRead dùng để mở luồng có thể đọc được cho dữ liệu được tải xuống từ tài nguyên với URL được chỉ định là chuỗi.
            Stream str = wc.OpenRead(s);
            // Dùng StreamReader để đọc file
            StreamReader sr = new StreamReader(str);
            // hàm .Peek() để trả về ký tự có sẵn tiếp theo nhưng không tiêu thụ nó.
            while (sr.Peek() > -1)
            {
                clarification += sr.ReadLine();
            }

            // dùng xong thì close streamreader đi
            sr.Close();
            return clarification;
        }

        // button có chức năng download dữ liệu trên web về
        private void btnDownload_Click(object sender, EventArgs e)
        {
            // hàm .Trim() Trả về một chuỗi mới trong đó tất cả các lần xuất hiện hàng đầu
            // và theo dõi của một tập hợp các ký tự được chỉ định từ chuỗi hiện tại được loại bỏ.
            if (textURL.Text.Trim() == "")
            {
                MessageBox.Show("ERROR !!! Please enter the correct URL. ");
                // hàm .Focus() có tác dụng trả về true nếu yêu cầu lấy nét đầu vào thành công; nếu không, false.
                textURL.Focus();
                return;
            }

            if (fileSaveDes.Text.Trim() == "")
            {
                MessageBox.Show("ERROR !!! Please enter the correct file destination. ");
                fileSaveDes.Focus();
                return;
            }

            // dùng try catch để kiểm tra dữ liệu khi download file về
            try
            {
                wc.DownloadFile(textURL.Text, fileSaveDes.Text);

                // 
                txtView.Text = OpenToRead(fileSaveDes.Text);
                MessageBox.Show("File downloaded successfully !!! ");
            }
            // dùng WebException: ngoại lệ được thrown đi khi một lỗi xảy ra trong khi acccessing mạng thông qua một giao thức có thể cắm.
            catch (WebException wex)
            {
                // Nhận được một thông báo mô tả ngoại lệ hiện tại.
                txtView.Text = wex.Message;
                // .Message để thông báo lỗi, thông báo giúp giải thích nguyên nhân của ngoại lệ hoặc để một chuỗi trống
            }
        }

        // button show sẽ hiển thị nội dung của file .html trên textbox txtView
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (fileSaveDes.Text.Trim() == "")
            {
                MessageBox.Show("ERRROR !!! Please enter the correct file destination. ");
                fileSaveDes.Focus();
                return;
            }

            // khai báo FileStream để đọc và viết dữ liệu vào file 
            FileStream fs = new FileStream(fileSaveDes.Text, FileMode.Open);

            //  Note: Byte arrays can represent any values
            //  but each invidual byte can only hold a certain range
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            textURL.Text = fileSaveDes.Text = txtView.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
