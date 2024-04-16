using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MDI_Form_Menu_Tabs_List_View
{
    public partial class frmDatabase : Form
    {
        SqlConnection strCon = new SqlConnection(@"Data Source=LAPTOP-JMAC2A32\SQLEXPRESS2;Initial Catalog=QL_PhongTro;Integrated Security=True");
        DataTable myTable = new DataTable();
        DataSet set = new DataSet();
        public frmDatabase()
        {
            InitializeComponent();
        }

        private void frmDatabase_Load(object sender, EventArgs e)
        {
            strCon.Open();
            string strSQL = "select * from USER";
            SqlDataAdapter data = new SqlDataAdapter(strSQL, strCon);
            data.Fill(set, "USER");
            myTable = set.Tables["USER"];
            foreach (DataRow row in myTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["Id"].ToString());
                item.SubItems.Add(row["Name"].ToString());
                item.SubItems.Add(row["Phone"].ToString());
                item.SubItems.Add(row["Email"].ToString());
                item.SubItems.Add(row["Password"].ToString());
                listView1.Items.Add(item);
            }
            strCon.Close();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            int row = e.ItemIndex;
            txtId.Text= listView1.Items[row].SubItems[0].Text;
            txtName.Text= listView1.Items[row].SubItems[1].Text;
            txtPhone.Text= listView1.Items[row].SubItems[2].Text;
            txtEmail.Text= listView1.Items[row].SubItems[3].Text;
            txtPass.Text= listView1.Items[row].SubItems[4].Text;
        } 
    }
}
