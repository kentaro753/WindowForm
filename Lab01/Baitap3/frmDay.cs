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
    public partial class frmDay : Form
    {
        public frmDay()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int M = Convert.ToInt32(txtMonth.Text);
            int Y = Convert.ToInt32(txtYear.Text);
            if (M >= 13) lbDay.Text = "Lỗi";
            if (M == 1 || M == 3 || M == 5 || M == 7 || M == 8 || M == 10 || M == 12) lbDay.Text = "Số ngày của tháng " + M.ToString() + " năm " + Y.ToString() + " là: 31 ngày";
            if (M == 2)
            {
                if (Y % 4 == 0 && Y % 100 != 0) lbDay.Text = "Số ngày của tháng " + M.ToString() + " năm " + Y.ToString() + " là: 29 ngày";
                else if (Y % 400 == 0) lbDay.Text = "Số ngày của tháng " + M.ToString() + " năm " + Y.ToString() + " là: 29 ngày";
                else lbDay.Text = "Số ngày của tháng " + M.ToString() + " năm " + Y.ToString() + " là: 28 ngày";
            }
            if (M == 4 || M == 6 || M == 9 || M == 11) lbDay.Text = "Số ngày của tháng " + M.ToString() + " năm " + Y.ToString() + " là: 30 ngày";
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
            txtMonth.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
