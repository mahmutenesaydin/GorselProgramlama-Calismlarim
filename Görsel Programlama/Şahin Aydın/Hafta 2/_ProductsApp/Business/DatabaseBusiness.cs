using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ProductsApp.Business
{
    public class DatabaseBusiness
    {

        private Database Database = new Database();

        public void ExecuteCommand(string cmdText,SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(cmdText, Database.OpenConnection());
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddRange(parameters);
            command.ExecuteNonQuery();
            //Database.CloseConnection();
        }

        public DataTable ExecuteAdapter(string cmdText)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmdText, Database.ConnectionString);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Database.CloseConnection();
            return dt;
        }

        public DataTable ExecuteAdapter(string cmdText,SqlParameter[] parameters)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmdText, Database.ConnectionString);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddRange(parameters);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Database.CloseConnection();
            return dt;
        }
    }
}
