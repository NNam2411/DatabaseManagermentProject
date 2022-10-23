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
    public partial class AddManager : Form
    {
        Staff staff = new Staff();
        DB mydb = new DB();
        public AddManager()
        {
            InitializeComponent();
        }

        private void bt_AddManager_Click(object sender, EventArgs e)
        {
            string id = tbbaristaid.Text;
            string name = tbbaristaname.Text;
            string address = tbbaristaaddress.Text;
            int phone = Convert.ToInt32(tbbaristaphone.Text);
            int salary = Convert.ToInt32(tbbaristasalary.Text);
            string position = tbposi.Text;
            if (AddBarista(id, name, address, phone, salary, position))
            {
                MessageBox.Show("Added", "Add New Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Add New Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public bool AddBarista(string ID, string name, string address, int phone, int salary, string position)
        {
            SqlCommand com = new SqlCommand("EXECUTE Add_Employee @eid, @ename, @eaddr, @ephone, @esalary, @eposition", mydb.getConnection);
            com.Parameters.Add("@eid", SqlDbType.VarChar).Value = ID;
            com.Parameters.Add("@ename", SqlDbType.VarChar).Value = name;
            com.Parameters.Add("@eaddr", SqlDbType.VarChar).Value = address;
            com.Parameters.Add("@ephone", SqlDbType.Int).Value = phone;
            com.Parameters.Add("@esalary", SqlDbType.Int).Value = salary;
            com.Parameters.Add("@eposition", SqlDbType.NVarChar).Value = position;
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

        private void AddManager_Load(object sender, EventArgs e)
        {

        }
    }
}
