using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap4
{
    public partial class Form1 : Form
    {
        Loginer[] lg  = new Loginer[2];
        public Form1()
        {
            InitializeComponent();
        }
        int dem;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lg.Length; i++)
            {
                if (txtName.Text == lg[i].Name && txtPass.Text == lg[i].Password)
                {
                    MessageBox.Show("Đăng nhập thành công.\nChào mừng trở lại " + txtName.Text + "!");
                    lbA.Text = "";
                    txtName.Focus();
                    dem = 0;
                    return;
                }
            }
            dem++;
            MessageBox.Show("Bạn đã nhập sai Tên hoặc Mật khẩu!");
            lbA.Text = "Bạn đã nhập sai "+dem+" lần, còn "+(3-dem)+" thử";
            txtName.Focus();
            if(dem==3)
            {
                MessageBox.Show("Nhập sai quá 3 lần\nChương trình sẽ tự động thoát!");
                Application.Exit();
            }
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

        private void btnRetry_Click(object sender, EventArgs e)
        {
            CleanForm();
            lbA.Text = "";
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lg[0] = new Loginer("Hữu Toàn","123456");
            lg[1] = new Loginer("Phiên", "654321");
        }
    }
}
