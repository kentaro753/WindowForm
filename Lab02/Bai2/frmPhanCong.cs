using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai2
{
    public partial class frmPhanCong : Form
    {
        List<GiaoVien> GV = new List<GiaoVien>();
        public frmPhanCong()
        {
            InitializeComponent();
        }

        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            GiaoVien a = new GiaoVien("Nguyễn Văn A", true);
            GiaoVien b = new GiaoVien("Nguyễn Thị B", false);
            GiaoVien c = new GiaoVien("Trần Văn C", true);
            GiaoVien d = new GiaoVien("Lê Thị D", false);
            GV.Add(a); GV.Add(b); GV.Add(c); GV.Add(d);
            listGV.Items.Add(GV.ElementAt(0).Name1);
            listGV.Items.Add(GV.ElementAt(1).Name1);
            listGV.Items.Add(GV.ElementAt(2).Name1);
            listGV.Items.Add(GV.ElementAt(3).Name1);
            listLop.Items.Add("10A1");
            listLop.Items.Add("10A2");
            listLop.Items.Add("10A3");
            listLop.Items.Add("11A1");
            listLop.Items.Add("11A2");
            listLop.Items.Add("11A3");
            listLop.Items.Add("12A1");
            listLop.Items.Add("12A2");
            listLop.Items.Add("12A3");
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            int row = listGV.SelectedIndex;
            int row1 = listLop.SelectedIndex;
            if (row == -1 || row1 == -1) return;
            string s;
            if (GV[row].Dem1 == 2)
            {
                MessageBox.Show("Giáo viên đã chủ nhiệm hai lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (GV.ElementAt(row).GioiTinh1 == true)
            {
                s = "Thầy " + listGV.Items[row].ToString() + " " + listLop.Items[row1].ToString();
                GV[row].Dem1 += 1;
            } 
            else
            {
                s = "Cô " + listGV.Items[row].ToString() + " " + listLop.Items[row1].ToString();
                GV[row].Dem1 += 1;
            }
            listPC.Items.Add(s);
            listLop.Items.RemoveAt(row1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
