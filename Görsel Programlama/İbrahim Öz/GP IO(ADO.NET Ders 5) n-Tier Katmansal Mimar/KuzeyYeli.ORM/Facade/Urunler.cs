using KuzeyYeli.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.ORM.Facade
{
   public class Urunler
    {
        //Select işlemi;
        public static DataTable Select()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_UrunListele", ToolsAraclar.Baglanti);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //Insert işlemi;
        public static bool Insert(Urun u)
        {
            SqlCommand komut = new SqlCommand("SP_UrunEkle", ToolsAraclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@UrunAdi", u.UrunAdi);
            komut.Parameters.AddWithValue("@Fiyat", u.BirimFiyati);
            komut.Parameters.AddWithValue("@Stok", u.HedefStokDüzeyi);
            komut.Parameters.AddWithValue("@KategoriID", u.KategoriID);
            komut.Parameters.AddWithValue("@TedarikciID", u.TedarikciID);

            return ToolsAraclar.ExeNonQue(komut);
        }
    }
}
