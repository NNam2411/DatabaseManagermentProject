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
    public partial class HomePage : Form
    {
        DB mydb = new DB();
        int id;
        int count = 0;

        public HomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void refresh()
        {
            panel_Login.Hide();
            panel_Menu.Hide();

            panel_Menu.Show();
            dataGridView1.Show();
            pn_Menu_dataGridView1.Show();
            bt_SCart.Show();
            tb_Amount.Show();
            bt_Remove.Show();
        }
        private void bt_Customer_Click(object sender, EventArgs e)
        {
            panel_Login.Hide();
            panel_Menu.Hide();
            refresh();
            panel_Menu.Show();



            Menu_class menu = new Menu_class();
            SqlCommand command = new SqlCommand("SELECT * FROM Item");
            pn_Menu_dataGridView1.DataSource = menu.GetMenu(command);
            pn_Menu_dataGridView1.AllowUserToAddRows = false;
            pn_Menu_dataGridView1.ReadOnly = true;
        }

        private void bt_Staff_Click(object sender, EventArgs e)
        {
            Manager mana = new Manager();
            mana.Show();
        }
        private DataTable GetItem()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM ItemInfo", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private DataTable GetOrder()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Order_ItemInfo", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            reset();
            panel_Menu.Hide();
            pn_Menu_dataGridView1.AllowUserToAddRows = false;
            pn_Menu_dataGridView1.ReadOnly = true;
            dataGridView1.ReadOnly = true;
            SqlCommand command = new SqlCommand("SELECT E_ID,E_Name FROM EmployeeInfo WHERE E_Position='Cashier'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "E_Name";
            comboBox1.ValueMember = "E_ID";
        }
        public int checkItem(DataTable table, string name, int quan)
        {
            quan = 1;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i]["It_Name"].ToString() == name)
                {
                    quan = Convert.ToInt32(table.Rows[i]["It_Quantity"]);
                    quan++;
                    return quan;
                }
            }
            return quan;
        }
        private void pn_Menu_dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Function fn = new Function();
            string name = pn_Menu_dataGridView1.CurrentRow.Cells[1].Value.ToString();
            int num;
            SqlCommand com = new SqlCommand("SELECT * FROM _Order ");
            DataTable table = fn.GetOrder(com);
            num = Convert.ToInt32(table.Rows[table.Rows.Count - 1]["O_Num"]);

            SqlCommand com1 = new SqlCommand("SELECT * FROM Order_ItemInfo WHERE O_Num = " + num);
            DataTable table_Item = fn.GetOrder(com1);

            count++;
            tb_Amount.Text = (count).ToString();

            if (count == 1)
            {
                if (table.Rows.Count < 1)
                    num = 1;
                else
                {
                    num++;
                }
                fn.AddOrder(num);
            }
            fn.AddOrder_Item(num, name, 1);
            id = num;

            SqlCommand command = new SqlCommand("SELECT * FROM Order_ItemInfo WHERE O_Num = " + id);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = mydb.getConnection;
            DataTable table1 = new DataTable();
            adapter.Fill(table1);
            if (table1.Rows.Count > 0)
            {
                dataGridView1.DataSource = table1;
            }
        }

        private void panel_Menu_Paint(object sender, PaintEventArgs e)
        {
            
        }
        bool verif()
        {
            if (tb_Phone.Text.Trim() == "")
                return false;
            return true;
        }
        private void bt_SCart_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                Bill bill = new Bill();
                bill.id = id;
                bill.c_phone = tb_Phone.Text;
                bill.E_ID = comboBox1.SelectedValue.ToString();
                bill.Description = tbDes.Text;
                bill.Show();
            }
            else
                MessageBox.Show("Enter Customer Phone", "Ordering", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }
        private void bt_Reset_Click(object sender, EventArgs e)
        {
            reset();
            tb_CusName.Clear();
            tb_Phone.Clear();
            tbDes.Clear();
            Function fn = new Function();
            SqlCommand com = new SqlCommand("SELECT * FROM _Order ");
            DataTable table = fn.GetOrder(com);
            int num = Convert.ToInt32(table.Rows[table.Rows.Count - 1]["O_Num"]);
            fn.delete_Bill(num);
        }
        void reset()
        {
            count = 0;
            tb_Amount.Text = 0.ToString();
            DataGridView dtg = new DataGridView();
            dataGridView1.DataSource = dtg.DataSource;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Function fn = new Function();
            if (dataGridView1.Rows.Count > 1)
            {
                string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();            
                int quan = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
                quan--;
                if (tb_Amount.Text == 1.ToString())
                    dataGridView1.Rows.RemoveAt(0);
                if (quan < 1)
                {
                    if (fn.deleteOrder(id, name))
                    {
                        count--;
                        tb_Amount.Text = (count).ToString();
                    }
                }
                else
                {
                    fn.updateOrder(id, name, quan);
                    count--;
                    tb_Amount.Text = (count).ToString();
                }
            }


            SqlCommand command = new SqlCommand("SELECT * FROM Order_ItemInfo WHERE O_Num = " + id);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = mydb.getConnection;
            DataTable table1 = new DataTable();
            adapter.Fill(table1);
            if (table1.Rows.Count > 0)
            {
                dataGridView1.DataSource = table1;
            }
        }

        private void listBox_Bill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void bt_Find_Click(object sender, EventArgs e)
        {
            Function fn = new Function();
            if (fn.checkCustomer(tb_Phone.Text) == null)
            {
                Customer ct = new Customer();
                ct.Show();
            }
            else
                tb_CusName.Text = fn.checkCustomer(tb_Phone.Text);
        }

        private void bt_Signin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM LO_GIN_Manager WHERE username=@user AND pass_word=@pass", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.NVarChar).Value = tb_Account.Text;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = tb_Password.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            SqlCommand command1 = new SqlCommand("SELECT * FROM LO_GIN_Employee WHERE username=@user1 AND pass_word=@pass1", mydb.getConnection);
            command1.Parameters.Add("@user1", SqlDbType.NVarChar).Value = tb_Account.Text;
            command1.Parameters.Add("@pass1", SqlDbType.NVarChar).Value = tb_Password.Text;
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            DataTable table1 = new DataTable();
            adapter1.Fill(table1);
            if (table.Rows.Count > 0)
            {
                if (rbmanager.Checked == true)
                {
                    tb_Account.Clear();
                    tb_Password.Clear();
                    bt_Manager.Enabled = true;
                    bt_Income.Enabled = true;
                    bt_Customer.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please choose who you are", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(table1.Rows.Count>0)
            {
                if (rbemployee.Checked == true)
                {
                    tb_Account.Clear();
                    tb_Password.Clear();
                    bt_Staff.Enabled = true;
                    bt_Checking.Enabled = true;
                    bt_Manager.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please choose who you are", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid username of password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void bt_Checking_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
        }

        private void bt_Customer_Click_1(object sender, EventArgs e)
        {
            Customer ct = new Customer();
            ct.Show();
        }

        private void bt_Income_Click(object sender, EventArgs e)
        {
            IncomeForm icf = new IncomeForm();
            icf.Show();
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            reset();
            tb_Phone.Text = null;
            tb_CusName.Clear();
            tbDes.Clear();
        }

        private void pn_Menu_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            bt_Customer.Enabled = false;
            bt_Manager.Enabled = false;
            bt_Staff.Enabled = false;
            bt_Checking.Enabled = false;
            bt_Income.Enabled = false;
        }
    }
}
