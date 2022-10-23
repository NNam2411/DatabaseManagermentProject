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
    public partial class Customer : Form
    {
        DB mydb = new DB();
        public Customer()
        {
            InitializeComponent();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            string search = tb_Search.Text;
            SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE CONCAT (C_ID, C_Name, C_Phone) LIKE '%" + search.ToString() + "%'", mydb.getConnection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adap.Fill(table);
            if(table.Rows.Count > 0)
            {
                dataGridView1.DataSource = table;
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbC_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_Cname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_Address.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_Phone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_TotalPay.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Create_Click(object sender, EventArgs e)
        {
            Function fn = new Function();
            string cname = tb_Cname.Text;
            string phone = tb_Phone.Text;
            string address = tb_Address.Text;
            if(fn.checkCustomer(phone) == null)
            {
                if (fn.addCustomer(cname, phone, address))
                    MessageBox.Show("Success", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Fail", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Phone number has been used", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            SqlCommand command = new SqlCommand("SELECT * FROM CustomerInfo ", mydb.getConnection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adap.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CustomerInfo ", mydb.getConnection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adap.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public bool DeleteCustomer(int ID, string name, string address, string phone, int totalpay)
        {
            SqlCommand com = new SqlCommand("EXECUTE DeleteCustomer @C_ID,@C_Name,@C_Address,@C_Phone,@C_TotalPay ", mydb.getConnection);
            com.Parameters.AddWithValue("@C_ID", ID);
            com.Parameters.AddWithValue("@C_Name", name);
            com.Parameters.AddWithValue("@C_Address", address);
            com.Parameters.AddWithValue("@C_Phone", phone);
            com.Parameters.AddWithValue("@C_TotalPay", totalpay);
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
        private void btdel_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbC_ID.Text);
            string name = tb_Cname.Text;
            string address = tb_Address.Text;
            string phone = tb_Phone.Text;
            int totalpay = Convert.ToInt32(tb_TotalPay.Text);
            if (DeleteCustomer(id, name, address, phone, totalpay))
            {
                MessageBox.Show("Deleted", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Deleted", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlCommand command = new SqlCommand("SELECT * FROM CustomerInfo ", mydb.getConnection);
                SqlDataAdapter adap = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adap.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
    }
}
