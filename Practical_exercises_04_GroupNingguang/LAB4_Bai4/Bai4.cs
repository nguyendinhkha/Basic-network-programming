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
using HtmlAgilityPack;

namespace LAB4_Bai4
{
    public partial class Bai4 : Form
    {
        public string resource = string.Empty;
        public Bai4()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webbrowser.GoBack();
        }

        // Disables the Back button at the beginning of the navigation history.
        private void webbrowser_CanGoBackChanged(object sender, EventArgs e)
        {
            btnBack.Enabled = webbrowser.CanGoBack;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            webbrowser.GoForward();
        }
        // Disables the Forward button at the end of navigation history.
        private void webbrowser_CanGoForwardChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = webbrowser.CanGoForward;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webbrowser.Refresh();
        }

        private void btnGo_Click(object sender, EventArgs e)
        { 
            if (txt_webUrl.Text != string.Empty)
            {
                webbrowser.Navigate(txt_webUrl.Text.Trim());
                WebClient wc = new WebClient();
                resource = wc.DownloadString(txt_webUrl.Text.Trim());

            }    
            else
                MessageBox.Show("Error !, Please input URL !!!");  
        }

        private void btnViewSource_Click(object sender, EventArgs e)
        {
                ViewSource source = new ViewSource(this);
                source.Show();
        }
    }
}
