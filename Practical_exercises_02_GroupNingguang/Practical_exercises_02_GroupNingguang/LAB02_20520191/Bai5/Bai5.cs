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

namespace Bai5
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                //Chọn folder cần duyệt
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.ShowDialog();
                DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);

                //Lấy thông tin từng file và hiển thị lên listview
                FileInfo[] fi = di.GetFiles();
                foreach(FileInfo file in fi)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = file.Name;
                    item.SubItems.Add(file.Length.ToString());
                    item.SubItems.Add(file.Extension);
                    item.SubItems.Add(file.CreationTime.ToString());
                    view.Items.Add(item);
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.ToString(), "Error");
            }  
        }
    }
}
