using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ProductsApp.Business
{
    public class Database
    {
        private SqlConnection _connection;

        public string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            }
        }

        public SqlConnection OpenConnection()
        {
            if (_connection==null)
            {
                _connection = new SqlConnection(ConnectionString);
                if (_connection.State == System.Data.ConnectionState.Closed)
                    _connection.Open();
            }
            return _connection;
        }

        public void CloseConnection()
        {
            if (_connection != null)
            {
                _connection.Close();
                _connection.Dispose();
            }
        }


    }
}
