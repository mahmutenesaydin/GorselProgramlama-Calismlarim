using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuzeyYeli.ORM.Entity;

//Select, Insert, Update, Delete metodunu burada kullanacağız

namespace KuzeyYeli.ORM.Facade
{
    public class Kategoriler
    {
        //Select işlemi;
        public static DataTable Select()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_KategoriListele", ToolsAraclar.Baglanti);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //Insert işlemi;
        public static bool Insert(Kategori k)
        {
            SqlCommand komut = new SqlCommand("SP_KategoriEkle", ToolsAraclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Adi", k.KategoriAdi);
            komut.Parameters.AddWithValue("@Tanim", k.Tanimi);

            return ToolsAraclar.ExeNonQue(komut);

            //if (komut.Connection.State == ConnectionState.Closed)
            //    komut.Connection.Open();
            //int Etkilenen = komut.ExecuteNonQuery();
            //if (komut.Connection.State != ConnectionState.Closed)//Açık ise
            //    return Etkilenen > 0 ? true : false;//(etk 0'dan büyükse true, değilse false dönder)
        }
    }
}
