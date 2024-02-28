using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace LAB4_Bai4
{
    public partial class ViewSource : Form
    {
        Bai4 bai4;
        public ViewSource(Bai4 sourceForm)
        {
            InitializeComponent();
                this.bai4 = sourceForm;
                rc_ViewSource.Text = bai4.resource;
        }
    }
}
