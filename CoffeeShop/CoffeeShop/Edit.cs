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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }
        DB mydb = new DB();
        public bool EditEer(string ID, string name, string address, string phone, int salary, string position)
        {
            SqlCommand com = new SqlCommand("EXECUTE Edit @E_id, @E_name,  @E_addr, @E_phone, @E_salary, @E_position", mydb.getConnection);
            com.Parameters.Add("@E_id", SqlDbType.NVarChar).Value = ID;
            com.Parameters.Add("@E_name", SqlDbType.NVarChar).Value = name;
            com.Parameters.Add("@E_addr", SqlDbType.NVarChar).Value = address;
            com.Parameters.Add("@E_phone", SqlDbType.NVarChar).Value = phone;
            com.Parameters.Add("@E_salary", SqlDbType.Int).Value = salary;
            com.Parameters.Add("@E_position", SqlDbType.NVarChar).Value = position;
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

        private void btedit_Click_1(object sender, EventArgs e)
        {
            string name = tbname.Text;
            string address = tbaddress.Text;
            string phone = tbphone.Text;
            int salary = Convert.ToInt32(tbsalary.Text);
            string position = tbchucvu.Text;

            try
            {
                string id = tbid.Text;
                if (EditEer(id, name, address, phone, salary, position))
                {
                    MessageBox.Show("Edited", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Empty Field", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edited");
            }
        }

        private void btcancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        Staff st = new Staff();
        private void btfind_Click(object sender, EventArgs e)
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

        private void pnwaiter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
