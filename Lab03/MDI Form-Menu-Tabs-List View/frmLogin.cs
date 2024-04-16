using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MDI_Form_Menu_Tabs_List_View
{
    public partial class frmLogin : Form
    {
        SqlConnection strCon = new SqlConnection(@"Data Source=LAPTOP-JMAC2A32\SQLEXPRESS2;Initial Catalog=QL_PhongTro;Integrated Security=True");
        DataTable myTable = new DataTable();
        DataSet set = new DataSet();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtPass.Text = "";
            txtId.Focus();
        }
        int dem = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập ID hoặc Mật khẩu!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string strSQL = "select Password from USER where ID = " + txtId.Text;
            SqlDataAdapter data = new SqlDataAdapter(strSQL, strCon);
            data.Fill(set, "USER");
            myTable = set.Tables["USER"];
            if (myTable.Rows.Count == 0)
            {
                dem++;
                MessageBox.Show("Không có ID này!\nBạn còn " + (3 - dem) + " lần thử.", "Thông báo");
                txtId.Focus();
            }
            else
            {
                foreach (DataRow row in myTable.Rows)
                {
                    if (row["Password"].ToString() == txtPass.Text)
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                        dem=4;
                        frmMDI frm = (frmMDI)this.MdiParent;
                        frm.mnuDatabase.Enabled = true;
                        frm.mnuSolve.Enabled = true;
                        strCon.Close();
                        this.Close();
                    }
                }
                if(dem < 4)
                {
                    dem++;
                    MessageBox.Show("Sai mật khẩu!\nBạn còn " + (3 - dem) + " lần thử.", "Thông báo");
                    txtPass.Focus();
                }

            }
            if (dem == 3)
            {
                MessageBox.Show("Bạn đã nhập sai 3 lần!\nHệ thống sẽ tự động thoát!", "Thông báo");
                this.Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            strCon.Open();
        }
    }
}
