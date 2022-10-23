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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
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
                tbsala.Text = table.Rows[0]["E_Salary"].ToString();
                tbposi.Text = table.Rows[0]["E_Position"].ToString();
            }
            btcheck.Enabled = true;
            try
            {
                string eid = tbid.Text;
                int total = 0;
                SqlCommand com1 = new SqlCommand("SELECT COUNT(DAY_CHECK) AS TOTAL_DAY FROM CHECKING WHERE E_ID= '" + eid + "' AND MONTH_ID=" + dateTimePicker1.Value.Month, mydb.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(com1);
                DataTable table1 = new DataTable();
                adapter.Fill(table1);
                total = Convert.ToInt32(table1.Rows[0]["TOTAL_DAY"]);
                if (total > 0)
                {
                    lbtotal.Text = total.ToString();
                }
            }
            catch
            {
                MessageBox.Show("This employee has never checked this month!", "Find Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bttotalsalary.Text = "Check Salary";
        }
        DB mydb = new DB();

        private void btcheck_Click(object sender, EventArgs e)
        {
            if(dataGridView2.Rows.Count>0)
            {
                if (tbid.Text == dataGridView2.CurrentRow.Cells[0].Value.ToString() && Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value)==dateTimePicker1.Value.Day && Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value)==dateTimePicker1.Value.Month)
                {
                    MessageBox.Show("This employee has checked before!", "Checking", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DateTime myDate = DateTime.Now;
                    string current = myDate.ToString("dd/MM/yyyy");
                    DateTime d = Convert.ToDateTime(dateTimePicker1.Value);
                    string picker = d.ToString("dd/MM/yyyy");
                    if (picker == current)
                    {
                        DateTime dayy = dateTimePicker1.Value;
                        checkedListBox1.SetItemChecked(dayy.Day - 1, true);
                        int count = checkedListBox1.CheckedItems.Count;
                        int dayid = Convert.ToInt32(dayy.Day);
                        string eid = tbid.Text;
                        int checkday = count;
                        int monthid = Convert.ToInt32(dayy.Month);
                        if (st.CHECKING(eid, dayid, checkday, monthid))
                        {
                            MessageBox.Show("Checked!", "Checking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Empty Field", "Checking", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        btcheck.Enabled = false;
                    }
                    SqlCommand command = new SqlCommand(@"SELECT E_ID[STAFF ID],DAY_ID[DAY],DAY_CHECK[CHECK],MONTH_ID[MONTH] FROM CHECKING");
                    dataGridView2.ReadOnly = true;
                    dataGridView2.AllowUserToAddRows = false;
                    dataGridView2.DataSource = st.GetStaff(command);
                }
            }
            else
            {
                DateTime myDate = DateTime.Now;
                string current = myDate.ToString("dd/MM/yyyy");
                DateTime d = Convert.ToDateTime(dateTimePicker1.Value);
                string picker = d.ToString("dd/MM/yyyy");
                if (picker == current)
                {
                    DateTime dayy = dateTimePicker1.Value;
                    checkedListBox1.SetItemChecked(dayy.Day - 1, true);
                    int count = checkedListBox1.CheckedItems.Count;
                    int dayid = Convert.ToInt32(dayy.Day);
                    string eid = tbid.Text;
                    int checkday = count;
                    int monthid = Convert.ToInt32(dayy.Month);
                    if (st.CHECKING(eid, dayid, checkday, monthid))
                    {
                        MessageBox.Show("Checked!", "Checking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Empty Field", "Checking", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    btcheck.Enabled = false;
                }
                SqlCommand command = new SqlCommand(@"SELECT E_ID[STAFF ID],DAY_ID[DAY],DAY_CHECK[CHECK],MONTH_ID[MONTH] FROM CHECKING");
                dataGridView2.ReadOnly = true;
                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.DataSource = st.GetStaff(command);
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(@"SELECT E_ID[STAFF ID],DAY_ID[DAY],DAY_CHECK[CHECK],MONTH_ID[MONTH] FROM CHECKING");
            dataGridView2.ReadOnly = true;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.DataSource = st.GetStaff(command);

        }
        public bool Delete(string E_ID, int DAY_ID, int MONTH_ID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM CHECKING WHERE E_ID=@eid AND DAY_ID=@dayid AND MONTH_ID=@monthid", mydb.getConnection);
            command.Parameters.Add("@eid", SqlDbType.NChar).Value = E_ID;
            command.Parameters.Add("@dayid", SqlDbType.Int).Value = DAY_ID;
            command.Parameters.Add("@monthid", SqlDbType.Int).Value = MONTH_ID;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
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
        private void btdelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want to delete this cheking?", "Delete Checking", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Delete(dataGridView2.CurrentRow.Cells[0].Value.ToString(), Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value)))
                    {
                        MessageBox.Show("Checking Deleted", "Delete Checking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error!", "Delete Checking", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Checking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand command = new SqlCommand(@"SELECT * FROM CHECKING");
            dataGridView2.ReadOnly = true;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.DataSource = st.GetStaff(command);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttotalsalary_Click_1(object sender, EventArgs e)
        {
            int total =  (Convert.ToInt32(tbsala.Text)* Convert.ToInt32(lbtotal.Text)) /30;
            bttotalsalary.Text = total.ToString()+"VND";
            bttotalsalary.ForeColor = Color.Green;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(@"SELECT E_ID[STAFF ID],DAY_ID[DAY],DAY_CHECK[CHECK],MONTH_ID[MONTH] FROM CHECKING");
            dataGridView2.ReadOnly = true;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.DataSource = st.GetStaff(command);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
            HomePage hp = new HomePage();
            hp.Show();
        }
    }
}
