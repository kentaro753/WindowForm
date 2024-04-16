using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDI_Form_Menu_Tabs_List_View
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            mnuSolve.Enabled = true;
            mnuDatabase.Enabled = true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.MdiParent = this;
            //frm.Owner = this; // Form Login nhận frmMain làm form chủ (chủ nhân)
            frm.Show();
        }

        private void mnuSolve_Click(object sender, EventArgs e)
        {
            frmSolve frm = new frmSolve();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuDatabase_Click(object sender, EventArgs e)
        {
            frmDatabase frm = new frmDatabase();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
