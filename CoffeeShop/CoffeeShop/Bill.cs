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
    public partial class Bill : Form
    {
        public int id;
        public string c_phone;
        int total = 0;
        DB mydb = new DB();
        public string E_ID;
        public string Description;
        public Bill()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Bill_Load(object sender, EventArgs e)
        {
            
            DateTime bdate = new DateTime();
            bdate = DateTime.Now;
            Function fn = new Function();

            listBox_Bill.Show();

            SqlCommand command = new SqlCommand("SELECT * FROM Order_Item WHERE O_Num = " + id);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = mydb.getConnection;
            DataTable table1 = new DataTable();
            adapter.Fill(table1);
            if (table1.Rows.Count > 0)
                for (int i = 0; i < table1.Rows.Count; i++)
                {
                    listBox_Bill.Items.Add(table1.Rows[i]["It_Name"].ToString() + " x " + table1.Rows[i]["It_Quantity"]
                    + "      = " + (fn.checkPrice(table1.Rows[i]["It_Name"].ToString()) * Convert.ToInt32(table1.Rows[i]["It_Quantity"])));
                    total += fn.checkPrice(table1.Rows[i]["It_Name"].ToString()) * Convert.ToInt32(table1.Rows[i]["It_Quantity"]);
                }

            fn.addBill(id, this.E_ID, c_phone, bdate, total,this.Description);
            int total_2 = fn.discountedTotal(id, bdate);
            listBox_Bill.Items.Add("Total: " + total_2);
            if (total_2 < total)
            {
                listBox_Bill.Items.Add("Discount: 10%");
                total = total_2;
            }
            HomePage hp = new HomePage();
            listBox_Bill.Items.Add("Cashier: " + this.E_ID);
            listBox_Bill.Items.Add("Description: " + this.Description);
        }

        private void bt_Done_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(tb_cashin.Text)<total)
            {
                MessageBox.Show("Invalid Money!","Bill",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                int cashin = Convert.ToInt32(tb_cashin.Text);
                tb_Cashback.Text = (cashin - total).ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox_Bill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
