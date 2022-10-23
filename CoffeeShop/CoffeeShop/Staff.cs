using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CoffeeShop
{
    class Staff
    {
        DB mydb = new DB();
        public DataTable GetStaff(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool CHECKING(string E_ID, int DAY_ID, int DAY_CHECK, int MONTH_ID)
        {
            SqlCommand command = new SqlCommand("EXECUTE CHAM @E_id,@DAY_id,@DAY_check,@MONTH_id", mydb.getConnection);
            command.Parameters.Add("@E_id", SqlDbType.NVarChar).Value = E_ID;
            command.Parameters.Add("@DAY_id", SqlDbType.Int).Value = DAY_ID;
            command.Parameters.Add("@DAY_check", SqlDbType.Int).Value = DAY_CHECK;
            command.Parameters.Add("@MONTH_id", SqlDbType.Int).Value = MONTH_ID;

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

    }
}
