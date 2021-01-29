using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.ORM
{
    class ToolsAraclar
    {
        private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);

        public static SqlConnection Baglanti
        {
            get { return baglanti; }
        }

        public static bool ExeNonQue(SqlCommand komut)
        {
            try
            {
                if (komut.Connection.State == ConnectionState.Closed)
                    komut.Connection.Open();
                int Etkilenen = komut.ExecuteNonQuery();
                return Etkilenen > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (komut.Connection.State == ConnectionState.Open)
                    komut.Connection.Close();
            }
        }
    }
}
