using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace MDI_Form_Menu_Tabs_List_View
{
    public partial class frmSolve : Form
    {
        public frmSolve()
        {
            InitializeComponent();
        }
        
        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (cboNumber.Text == "") return;
            int n=Convert.ToInt32(cboNumber.Text);
            int dem;
            Solve sv= new Solve();
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    lstPrime.Items.Clear();
                    dem = 0;
                    for(int i=0;i<n;i++)
                    {
                        if (sv.isPrime(i))
                        {
                            lstPrime.Items.Add(i);
                            dem++;
                        }
                    }
                    lbA.Text = "Tìm được "+dem+" số nguyên tố";
                    break;
                case 1:
                    lstPerfect.Items.Clear();
                    dem = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (sv.isPerfect(i))
                        {
                            lstPerfect.Items.Add(i);
                            dem++;
                        }
                    }
                    lbB.Text = "Tìm được " + dem + " số hoàn thiện";
                    break;
                case 2:
                    lstSquare.Items.Clear();
                    dem = 0;
                    for (int i = 0; i <= n; i++)
                    {
                        if (sv.isSquare(i)) lstSquare.Items.Add(i);
                        dem++;
                    }
                    lbC.Text = "Tìm được " + dem + " số chính phương";
                    break;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    lstPrime.Items.RemoveAt(lstPrime.SelectedIndex);
                    break;
                case 1:
                    lstPerfect.Items.RemoveAt(lstPerfect.SelectedIndex);
                    break;
                case 2:
                    lstSquare.Items.RemoveAt(lstSquare.SelectedIndex);
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    lstPrime.Items.Clear();
                    lbA.Text = "";
                    break;
                case 1:
                    lstPerfect.Items.Clear();
                    lbB.Text = "";
                    break;
                case 2:
                    lstSquare.Items.Clear();
                    lbC.Text = "";
                    break;
            }
        }
    }
}
