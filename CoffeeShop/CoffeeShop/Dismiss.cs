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
    public partial class Dismiss : Form
    {
        public Dismiss()
        {
            InitializeComponent();
        }

        private void Dismiss_Load(object sender, EventArgs e)
        {

        }
        DB mydb = new DB();
        public bool DismissStaff(string ID, string name, string address, string phone, int salary, string position)
        {
            SqlCommand com = new SqlCommand("EXECUTE Dismiss @E_id, @E_name, @E_addr, @E_phone, @E_salary, @E_position ", mydb.getConnection);
            com.Parameters.AddWithValue("@E_id", ID);
            com.Parameters.AddWithValue("@E_name", name);
            com.Parameters.AddWithValue("@E_addr", address);
            com.Parameters.AddWithValue("@E_phone", phone);
            com.Parameters.AddWithValue("@E_salary", salary);
            com.Parameters.AddWithValue("@E_position", position);
            mydb.openConnection();
            if (com.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        private void btcancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        Staff st = new Staff();
        private void btdel_Click_1(object sender, EventArgs e)
        {
            string id = tbid.Text;
            string name = tbname.Text;
            string address = tbaddress.Text;
            string phone = tbphone.Text;
            int salary = Convert.ToInt32(tbsalary.Text);
            string position = tbchucvu.Text;
            if (DismissStaff(id, name, address, phone, salary, position))
            {
                MessageBox.Show("Dismissed", "Dismiss Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dismissed", "Dismiss Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
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
                tbchucvu.Text = table.Rows[0]["E_Position"].ToString();
            }
            else
            {
                MessageBox.Show("Cannot Find Staff", "Find Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btcancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
