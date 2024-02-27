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
using System.Runtime.Serialization.Formatters.Binary;

namespace Bai4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Tạo file input
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.ShowDialog();
                FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);

                //Tạo binary formatter 
                BinaryFormatter bf = new BinaryFormatter();
                string content = input.Text;
                string[] hocvien = content.Trim().Split(';'); //Tách từng học viên thành từng string

                //Tách từng thông tin của 1 học viên và ghi nội dung được format vào stream
                int i = 0;
                string data = string.Empty;
                foreach(string thongtin in hocvien)
                {
                    hocvien[i] = thongtin.Trim().Replace(",", "\n").Replace(" ", string.Empty);
                    data += (hocvien[i] + "\n\n\n");
                    i++;
                }
                bf.Serialize(fs, data.Trim(' ', '\n'));

                //Đóng stream và xoá input người dùng đã nhập
                fs.Close();
                input.Text = null;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //Mở file input.txt
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);

            //Đọc thông tin file vừa mở
            BinaryFormatter bf = new BinaryFormatter();
            view.Text = bf.Deserialize(fs).ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string content = view.Text.Replace("\n\n\n", ",");
            string[] hocvien = content.Trim().Split(',');
            int i = 0;
            content = "";
            foreach(string hv in hocvien)
            {
                string diemso = hv.Substring(hv.Length - 7); //Lấy 7 kí tự cuối của chuỗi
                string[] diem = diemso.Split('\n'); //Tách thành 2 số

                //Tính điểm trung bình 
                hocvien[i] = hocvien[i] + "\n" + ((float.Parse(diem[0]) + float.Parse(diem[1])) / 2).ToString();
                
                content = content + hocvien[i] + "\n\n";
                i++;
            }
            view.Text = content; //Hiển thị lên richtextbox
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            //Tạo file input
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);

            //Tạo binary formatter 
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, view.Text.Trim(' ', '\n'));

            //Đóng stream
            fs.Close();
        }
    }
}
