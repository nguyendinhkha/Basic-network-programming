using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02_20520191_20520562
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1 form_bai1 = new Bai1();
            form_bai1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2 form_bai2 = new Bai2();    
            form_bai2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai3 form_bai3 = new Bai3();
            form_bai3.Show();
        }
    }
}
