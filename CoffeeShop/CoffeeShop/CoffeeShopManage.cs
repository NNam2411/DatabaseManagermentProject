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
    public partial class CoffeeShopManage : Form
    {
        public CoffeeShopManage()
        {
            InitializeComponent();
        }

        private void bt_Signin_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM log_in WHERE username = @User AND password = @Pass", db.getConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = tb_Account.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = tb_Password.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                panel1.Hide();
                //panel quan li
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CoffeeShopManage_Load(object sender, EventArgs e)
        {

        }
    }
}
