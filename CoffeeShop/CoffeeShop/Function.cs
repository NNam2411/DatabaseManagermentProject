using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CoffeeShop
{
    class Function
    {
        DB mydb = new DB();
        public DataTable GetBill(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable GetOrder(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool AddOrder(int num)
        {
            SqlCommand command1 = new SqlCommand("EXECUTE Add_Order @onum", mydb.getConnection);

            command1.Parameters.Add("@onum", SqlDbType.Int).Value = num;
            mydb.openConnection();
            if (command1.ExecuteNonQuery() == 1)
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
        public bool AddOrder_Item(int num, string itname, int quan)
        {
            SqlCommand command = new SqlCommand("EXECUTE Add_OrderItem @num, @itname, @quan", mydb.getConnection);

            command.Parameters.Add("@num", SqlDbType.Int).Value = num;
            command.Parameters.Add("@itname", SqlDbType.VarChar).Value = itname;
            command.Parameters.Add("@quan", SqlDbType.Int).Value = quan;

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
        public bool updateOrder(int num, string itname, int quan)
        {
            SqlCommand command = new SqlCommand("EXECUTE Update_OrderItem @onum, @itname, @quan", mydb.getConnection);
            command.Parameters.Add("@onum", SqlDbType.Int).Value = num;
            command.Parameters.Add("@itname", SqlDbType.VarChar).Value = itname;
            command.Parameters.Add("@quan", SqlDbType.Int).Value = quan;

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
        public bool deleteOrder(int num, string itname)
        {
            SqlCommand command = new SqlCommand("EXECUTE Delete_OrderItem @onum, @itname", mydb.getConnection);
            command.Parameters.Add("@onum", SqlDbType.Int).Value = num;
            command.Parameters.Add("@itname", SqlDbType.VarChar).Value = itname;

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
        public bool delete_Order(int num)
        {
            SqlCommand command = new SqlCommand("EXECUTE DeleteOrder @onum", mydb.getConnection);
            command.Parameters.Add("@onum", SqlDbType.Int).Value = num;

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
        public bool delete_Bill(int num)
        {
            SqlCommand command = new SqlCommand("EXECUTE DeleteBill @onum", mydb.getConnection);
            command.Parameters.Add("@onum", SqlDbType.Int).Value = num;

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
        public int checkPrice(string name)
        {
            Function fn = new Function();
            SqlCommand command = new SqlCommand("SELECT dbo.CheckPrice(@itemname)", mydb.getConnection);
            command.Parameters.Add("@itemname", SqlDbType.VarChar).Value = name;
            mydb.openConnection();

            DataTable table = fn.GetOrder(command);
            if (table.Rows.Count > 0)
                return Convert.ToInt32(table.Rows[0][0]);
            return 0;
        }
        public string checkCustomer(string phone)
        {
            Function fn = new Function();
            SqlCommand command = new SqlCommand("EXECUTE checkCustomer @phone", mydb.getConnection);
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            mydb.openConnection();

            DataTable table = fn.GetOrder(command);
            if (table.Rows.Count > 0)
                return table.Rows[0]["C_Name"].ToString();
            else return null;
        }
        public bool addCustomer(string cname, string phone, string address)
        {
            SqlCommand command = new SqlCommand("EXECUTE addCustomer @cname, @phone, @address, @totalpay", mydb.getConnection);
            command.Parameters.Add("@cname", SqlDbType.NVarChar).Value = cname;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@totalpay", SqlDbType.Int).Value = 0;
            mydb.openConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            mydb.closeConnection();
            return false;
        }
        public bool addBill(int ordernum, string eid, string phone, DateTime date, int price, string des)
        {
            SqlCommand command1 = new SqlCommand("SELECT C_ID FROM Customer WHERE C_Phone = @phone", mydb.getConnection);
            command1.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            SqlDataAdapter adap = new SqlDataAdapter(command1);
            DataTable table = new DataTable();
            adap.Fill(table);

            SqlCommand command = new SqlCommand("EXECUTE addBill @ordernum, @eid, @cid, @date, @price, @des", mydb.getConnection);
            command.Parameters.Add("@ordernum", SqlDbType.Int).Value = ordernum;
            command.Parameters.Add("@eid", SqlDbType.VarChar).Value = eid;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = Convert.ToInt32(table.Rows[0]["C_ID"]);
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            command.Parameters.Add("@des", SqlDbType.VarChar).Value = des;

            mydb.openConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            mydb.closeConnection();
            return false;
        }
        public int discountedTotal(int ordernum, DateTime date)
        {
            SqlCommand command = new SqlCommand("SELECT B_Total FROM Bill WHERE O_Num = @ordernum AND B_Date = @bdate", mydb.getConnection);
            command.Parameters.Add("@ordernum", SqlDbType.Int).Value = ordernum;
            command.Parameters.Add("@bdate", SqlDbType.DateTime).Value = date;

            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adap.Fill(table);
            return Convert.ToInt32(table.Rows[0]["B_Total"]);
        }
    }
}
