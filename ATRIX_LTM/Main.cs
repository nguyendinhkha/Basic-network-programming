using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ATRIX_LTM
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            panelMain.Visible = false;
            panelSubOptions.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelMain.Visible == true)
                panelMain.Visible = false;
            if (panelSubOptions.Visible == true)
                panelSubOptions.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }

            else
                subMenu.Visible = false;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMain);
        }

        private void btnAllowRemote_Click(object sender, EventArgs e)
        {
            //openChildForm(new ControlRemote());
            //

            hideSubMenu();
        }

        private void btnControlRemote_Click(object sender, EventArgs e)
        {
            openChildForm(new ControlRemote());
            //

            hideSubMenu();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubOptions);
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            //

            hideSubMenu();
        }

        private void btnSercurity_Click(object sender, EventArgs e)
        {
            //

            hideSubMenu();
        }

        private void btnMiscellaneous_Click(object sender, EventArgs e)
        {
            //

            hideSubMenu();
        }

        private void btnFileTransfer_Click(object sender, EventArgs e)
        {
            //

            hideSubMenu();
        }

        private void btnDiagnostic_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        // declare a private variable of type form of active form name as a value 
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}

