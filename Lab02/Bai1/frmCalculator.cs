using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmCalculator : Form
    {
        double A, B, KQ;
        char Op;
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            A = Convert.ToDouble(txtResult.Text);//Ghi nhận số thứ nhất
            txtResult.Text = ""; //Chuẩn bị nhập số thứ hai
            Op = bt.Text[0]; //Ghi nhận phép toán.
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtResult.Text += bt.Text;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            B = Convert.ToDouble(txtResult.Text);//Ghi nhận số thứ hai
            switch (Op)
            {
                case '+': KQ = A + B; break;
                case '-': KQ = A - B; break;
                case '*': KQ = A * B; break;
                case '/':
                    try
                    {
                        int c =(int) A / (int)B;
                    }
                    catch (DivideByZeroException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
            txtResult.Text = KQ.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtResult.Focus();
        }
    }
}
