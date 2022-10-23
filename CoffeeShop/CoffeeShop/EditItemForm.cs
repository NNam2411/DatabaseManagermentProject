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
    public partial class EditItemForm : Form
    {
        DB mydb = new DB();
        int item_count = 0;
        public EditItemForm()
        {
            InitializeComponent();
        }
        void refresh()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Item", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tableitem = new DataTable();
            adapter.Fill(tableitem);
            item_count = tableitem.Rows.Count;
            dataGridView1.DataSource = tableitem;
        }
        private void EditItemForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            SqlCommand command = new SqlCommand("SELECT * FROM Item", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tableitem = new DataTable();
            adapter.Fill(tableitem);
            item_count = tableitem.Rows.Count;
            dataGridView1.DataSource = tableitem;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_ItemID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_ItemName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_Price.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        public bool updateItem(string id, string name, int price)
        {
            SqlCommand command = new SqlCommand("UPDATE Item SET It_Name = @name, It_Cost = @price WHERE It_ID = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            mydb.closeConnection();
            return false;
        }
        private void bt_edit_Click(object sender, EventArgs e)
        {
            string id = tb_ItemID.Text;
            string name = tb_ItemName.Text;
            int price = Convert.ToInt32(tb_Price.Text);
            if(updateItem(id, name, price))
                MessageBox.Show("Updated", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            refresh();

        }
        public bool addItem(string id, string itname, int price)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Item (It_ID, It_Name, It_Cost) VALUES (@id, @name, @price)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = itname;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            mydb.openConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            mydb.closeConnection();
            return false;

        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            string id = "i" + (item_count + 1).ToString();
            MessageBox.Show(id.ToString());
            string name = tb_ItemName.Text;
            int price = Convert.ToInt32(tb_Price.Text);

            if (addItem(id, name, price))
                MessageBox.Show("Added", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            refresh();
        }
        public bool deleteItem(string id)
        {
            SqlCommand command = new SqlCommand("DELETE Item WHERE It_ID = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            mydb.openConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            mydb.closeConnection();
            return false;
        }
        private void bt_remove_Click(object sender, EventArgs e)
        {
            string id = tb_ItemID.Text;
            if(deleteItem(id))
                MessageBox.Show("Deleted", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            refresh();
        }
    }
}
