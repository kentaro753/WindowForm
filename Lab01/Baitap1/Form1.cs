using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Baitap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Bạn muốn thoát chương trình?";
            string title ="Exit";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            DialogResult rs = MessageBox.Show(message,title,btn);
            if (rs == DialogResult.Yes) Application.Exit();
        }
    }
}
