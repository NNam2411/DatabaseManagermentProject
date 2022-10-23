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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }
        DB mydb = new DB();
        private void Manager_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM EmployeeInfo",mydb.getConnection);
            gridcashier.ReadOnly = true;
            gridcashier.AllowUserToAddRows = false;
            gridcashier.DataSource = st.GetStaff(command);
        }
        Staff st = new Staff();
        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void securityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridcashier.Hide();
            pnbarista.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        public bool AddWaiter(string ID, string name, string address, int phone, int salary, string position)
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
        public bool AddCashier(string ID, string name, string address, int phone, int salary, string position)
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
        public bool AddBarista(string ID, string name, string address, int phone, int salary, string position)
        {
            SqlCommand com = new SqlCommand("EXECUTE Add_Employee @eid, @ename, @ephone, @eaddr,  @esalary, @eposition", mydb.getConnection);
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

        private void btaddwaiter_Click_1(object sender, EventArgs e)
        {
            string id = tbwaiterid.Text;
            string name = tbwaitername.Text;
            string address = tbwaiteraddress.Text;
            int phone = Convert.ToInt32(tbwaiterphone.Text);
            int salary = Convert.ToInt32(tbwaitersalary.Text);
            string position = tbchucvu.Text;
            if (AddWaiter(id, name, address, phone, salary, position))
            {
                MessageBox.Show("Added", "Add New Waiter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Add New Waiter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btaddcashier_Click_1(object sender, EventArgs e)
        {
            string id = tbcashid.Text;
            string name = tbcashname.Text;
            string address = tbcashaddress.Text;
            int phone = Convert.ToInt32(tbcashphone.Text);
            int salary = Convert.ToInt32(tbcashsalary.Text);
            string position = tbposition.Text;
            if (AddCashier(id, name, address, phone, salary, position))
            {
                MessageBox.Show("Added", "Add New Cashier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Add New Cashier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btaddbarista_Click_1(object sender, EventArgs e)
        {
            string id = tbbaristaid.Text;
            string name = tbbaristaname.Text;
            string address = tbbaristaaddress.Text;
            int phone = Convert.ToInt32(tbbaristaphone.Text);
            int salary = Convert.ToInt32(tbbaristasalary.Text);
            string position = tbposi.Text;
            if (AddBarista(id, name, address, phone, salary, position))
            {
                MessageBox.Show("Added", "Add New Barista", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Add New Barista", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void editStaffsInformationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }
        private void findStaffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        }

        private void deleteStaffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        }
        private void managerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            gridcashier.Hide();
            pnwaiter.Show();
        }

        private void securityToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            gridcashier.Hide();
            pnbarista.Show();
        }

        private void cashierToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            gridcashier.Hide();
            pncashier.Show();
        }

        private void btrefresh_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(@"SELECT * FROM Employees");
            gridcashier.ReadOnly = true;
            gridcashier.AllowUserToAddRows = false;
            gridcashier.DataSource = st.GetStaff(command);
        }
        private void btdonecashier_Click_1(object sender, EventArgs e)
        {
            pncashier.Hide();
            //refresh
            SqlCommand command = new SqlCommand(@"SELECT * FROM Employees");
            gridcashier.ReadOnly = true;
            gridcashier.AllowUserToAddRows = false;
            gridcashier.DataSource = st.GetStaff(command);
            gridcashier.Show();
        }
        private void btdonewaiter_Click(object sender, EventArgs e)
        {
            pnwaiter.Hide();
            //refresh data
            SqlCommand command = new SqlCommand(@"SELECT * FROM Employees");
            gridcashier.ReadOnly = true;
            gridcashier.AllowUserToAddRows = false;
            gridcashier.DataSource = st.GetStaff(command);
            gridcashier.Show();
        }
        private void btdonebarista_Click_1(object sender, EventArgs e)
        {
            pnbarista.Hide();
            //refresh
            SqlCommand command = new SqlCommand(@"SELECT * FROM Employees");
            gridcashier.ReadOnly = true;
            gridcashier.AllowUserToAddRows = false;
            gridcashier.DataSource = st.GetStaff(command);
            gridcashier.Show();

        }

        private void editStaffsInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit ed = new Edit();
            ed.Show();
        }

        private void findStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find f = new Find();
            f.Show();

        }

        private void deleteStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dismiss dis = new Dismiss();
            dis.Show();

        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNewStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditItemForm eitem = new EditItemForm();
            eitem.Show();
        }

        private void managerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddManager aman = new AddManager();
            aman.Show();
        }
    }
}
