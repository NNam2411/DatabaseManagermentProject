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

namespace CoffeeShop
{
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }

        private void Find_Load(object sender, EventArgs e)
        {

        }

        Staff st = new Staff();
        private void btfind_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btfind_Click_1(object sender, EventArgs e)
        {
            string id = tbid.Text;
            SqlCommand com = new SqlCommand("SELECT * FROM Employees WHERE E_ID = '" + id + "'");
            DataTable table = st.GetStaff(com);
            if (table.Rows.Count > 0)
            {
                tbname.Text = table.Rows[0]["E_Name"].ToString();
                tbaddress.Text = table.Rows[0]["E_Address"].ToString();
                tbphone.Text = table.Rows[0]["E_Phone"].ToString();
                tbsalary.Text = table.Rows[0]["E_Salary"].ToString();
                tbposition.Text = table.Rows[0]["E_Position"].ToString();
            }
            else
            {
                MessageBox.Show("Cannot Find Staff", "Find Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
