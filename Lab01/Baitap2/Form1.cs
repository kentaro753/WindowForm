using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap2
{
    public partial class Form4Operators : Form
    {
        public Form4Operators()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(txtA.Text);
            double B = Convert.ToDouble(txtB.Text);
            txtSum.Text = (A + B).ToString();
            txtDiff.Text = (A - B).ToString();
            txtProduct.Text = (A * B).ToString();
            if (B == 0) txtQuotient.Text = "Không thể tính";
            else txtQuotient.Text = (A / B).ToString();
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

        private void btnAgain_Click_1(object sender, EventArgs e)
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
