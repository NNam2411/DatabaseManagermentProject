using System.Data;
using System.Data.SqlClient;

namespace CoffeeShop
{
    class DB
    {
        public SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0CLMOJLH;Initial Catalog=CafeManager;Integrated Security=True");
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }

}
