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
    public partial class IncomeForm : Form
    {
        DB mydb = new DB();
        public IncomeForm()
        {
            InitializeComponent();
        }

        private void bt_Next_Click(object sender, EventArgs e)
        {
            DateTime nextday = dateTimePicker1.Value.AddDays(1);
            dateTimePicker1.Value = nextday;

            SqlCommand command = new SqlCommand("SELECT * FROM BILL WHERE B_Date = @bdate", mydb.getConnection);
            command.Parameters.Add("@bdate", SqlDbType.Date).Value = (DateTime)dateTimePicker1.Value;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            int total = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                total += Convert.ToInt32(table.Rows[i]["B_Total"]);
            }
            lb_Total.Text = "Total: " + total.ToString() + " VND";


        }

        private void bt_Previous_Click(object sender, EventArgs e)
        {
            DateTime previousday = dateTimePicker1.Value.AddDays(-1);
            dateTimePicker1.Value = previousday;

            SqlCommand command = new SqlCommand("SELECT * FROM BILL WHERE B_Date = @bdate", mydb.getConnection);
            command.Parameters.Add("@bdate", SqlDbType.Date).Value = (DateTime)dateTimePicker1.Value;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            int total = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                total += Convert.ToInt32(table.Rows[i]["B_Total"]);
            }
            lb_Total.Text = "Total: " + total.ToString() + " VND";

        }

        private void bt_Check_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Bill WHERE DAY(B_Date) = DAY(@bdate)", mydb.getConnection);
            command.Parameters.Add("@bdate", SqlDbType.Date).Value = (DateTime)dateTimePicker1.Value;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            int total = 0;
            for(int i = 0; i < table.Rows.Count; i ++)
            {
                total += Convert.ToInt32(table.Rows[i]["B_Total"]);
            }
            lb_Total.Text = "Total: " + total.ToString() + " VND";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void bt_Checkmonth_Click(object sender, EventArgs e)
        {
            DateTime day = dateTimePicker1.Value;
            SqlCommand command = new SqlCommand("SELECT * FROM BILL WHERE Month(B_Date) = Month(@bdate)", mydb.getConnection);
            command.Parameters.Add("@bdate", SqlDbType.Date).Value = (DateTime)dateTimePicker1.Value;


            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            int total = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                total += Convert.ToInt32(table.Rows[i]["B_Total"]);
            }
            dataGridView1.DataSource = table;
            lb_Total.Text = "Total: " + total.ToString() + " VND";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {

        }

        private void btclose_Click(object sender, EventArgs e)
        {
            Close();
            HomePage hp = new HomePage();
            hp.Show();
        }
    }
}
