using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ders7ÇalışmaLibrary
{
    public class ORMBase<TT> : IORM<TT>
    {
        Type TipGetir
        {
            get
            {
                return typeof(TT);
            }
        }

        public bool Ekle(TT entity)
        {
            return ToolsAraçlar.InsertUpdate<TT>("Insert", entity);

           // SqlCommand komut = new SqlCommand();
           // komut.CommandText = string.Format("SP_{0}_Insert", TipGetir.Name);
           // komut.Connection = ToolsAraçlar.Baglanti;
           // komut.CommandType = CommandType.StoredProcedure;

           // PropertyInfo[] propertys = TipGetir.GetProperties(); // Geriye dizi dönderir, tüm propertyilerin özelliklerini gösterir;
           // foreach (PropertyInfo pi in propertys)
           // {
           //     string prmAdi = "@" + pi.Name;
           //     object deger = pi.GetValue(entity); // Object = Hangi değer olduğunu bilmediğimzden object yazıyor ki o otomatik olarak int mi string mi kendisi belirlesin.
           //     komut.Parameters.AddWithValue(prmAdi, deger);

           //  //   return ToolsAraçlar.ExeNonQue(komut);
           //  }
           // return ToolsAraçlar.ExeNonQue(komut);
           //// return false;
        }

        public bool Guncelle(TT entity)
        {
            return ToolsAraçlar.InsertUpdate<TT>("Update", entity);

            //SqlCommand komut = new SqlCommand();
            //komut.CommandText = string.Format("SP_{0}_Update", TipGetir.Name);
            //komut.Connection = ToolsAraçlar.Baglanti;
            //komut.CommandType = CommandType.StoredProcedure;

            //PropertyInfo[] propertys = TipGetir.GetProperties();

            //foreach (PropertyInfo pi in propertys)
            //{
            //    string prmAdi = "@" + pi.Name;
            //    object deger = pi.GetValue(entity);
            //    komut.Parameters.AddWithValue(prmAdi, deger);
            //}
            //return ToolsAraçlar.ExeNonQue(komut);
        }

        public DataTable Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand komut = new SqlCommand();
            komut.Connection = ToolsAraçlar.Baglanti;
            komut.CommandText = string.Format("SP_{0}_Select", TipGetir.Name);
            komut.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = komut;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Sil(int ID)
        {
            TT ent = Activator.CreateInstance<TT>();

            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format("SP_{0}_Delete", TipGetir.Name);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Connection = ToolsAraçlar.Baglanti;

            PropertyInfo primaryColumn = TipGetir.GetProperty("PrimaryColumn");

            string prmAdi = "@" + primaryColumn.GetValue(ent);

            komut.Parameters.AddWithValue(prmAdi, ID);
            return ToolsAraçlar.ExeNonQue(komut);
        }
    }
}
