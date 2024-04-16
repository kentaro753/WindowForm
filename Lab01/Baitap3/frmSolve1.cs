using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap3
{
    public partial class frmSolve1 : Form
    {
        public frmSolve1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(txtA.Text);
            double B = Convert.ToDouble(txtB.Text);
            if (A == 0 && B == 0) lbS.Text = "Phương trình vô số nghiệm";
            else if (A == 0 && B != 0) lbS.Text = "Phương trình vô nghiệm";
            else if (A != 0 && B == 0) lbS.Text = "Phương trình có 1 nghiệm là X=0";
            else lbS.Text = "Phương trình có 1 nghiệm là X=" + (B / A).ToString();
        }
        private void CleanForm()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            CleanForm();
            txtA.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
