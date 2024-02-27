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

// MSSV: 20520562
// Họ và tên: Nguyễn Đình Kha
// Lớp: NT106.M21.ATCL
// Bài tập tại lớp 02

namespace _20520562_Bai_Tap_Tái_Lop_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(textPort.Text);         // lưu ý: 2 ports phải giống nhau
            UdpClient udpClient = new UdpClient(port);

            while (true)                          // bản chất là server, nhưng tên là udp client :D,   dùng chung 1 lớp udp client
            {
                // chạy vòng lặp lắng nghe liên tục tín hiệu từ phía client cho đến khi tắt
                IPEndPoint IpEnd = new IPEndPoint(IPAddress.Any, 0);        // tạo IPEndPoint 

                // Đón nhận và đẩy dữ liệu nhận được vào mảng Byte
                Byte[] ReceiveBytes = udpClient.Receive(ref IpEnd);
                string Data = Encoding.UTF8.GetString(ReceiveBytes);
                string mess = IpEnd.Address.ToString() + ":" + IpEnd.Port.ToString() + ": " + Data.ToString();

                // Gọi hàm hiển thị thông điệp nhận được lên màn hình
                MessageBox.Show(mess);
            }
            
        }
    }
}
