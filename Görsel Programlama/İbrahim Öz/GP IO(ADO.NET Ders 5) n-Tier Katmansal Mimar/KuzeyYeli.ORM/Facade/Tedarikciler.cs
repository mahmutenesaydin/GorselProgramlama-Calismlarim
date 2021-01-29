using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.ORM.Facade
{
    public class Tedarikciler
    {
        public static DataTable Select()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_TedarikciListele", ToolsAraclar.Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
