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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(txtN.Text);
            int i=1;
            double S = 0;
            while (i <= N)
            {
                S += (1.0 / i);
                i++;
            }
            lbS.Text = "S=" + S.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            lbS.Text = "";
            txtN.Focus();
        }
    }
}
