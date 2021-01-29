using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ders7ÇalışmaLibrary
{
    class ToolsAraçlar
    {
        //Singleton Dizayn Pattern= sürekli new'lememek için kullanılır. Tek anlamındadır

        private static SqlConnection bag;

        public static SqlConnection Baglanti
        {
            get
            {
                if (bag==null)
                {
                    bag = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalBaglanti"].ConnectionString);   //bag=bag ?? new SqlConnection();  if'ile aynı 
                }

                return bag;
            }
            set { bag = value; }
        }
        public static bool ExeNonQue(SqlCommand komut)
        {
            try
            {
                if (komut.Connection.State == ConnectionState.Closed)
                    komut.Connection.Open();

                int Etklinen = komut.ExecuteNonQuery();
                return Etklinen > 0 ? true : false;
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
        public static bool InsertUpdate<T>(string procType,T entity) 
        {
            Type TipGetir = typeof(T);
            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format("SP_{0}_{1}", TipGetir.Name, procType);

            PropertyInfo[] propertys = TipGetir.GetProperties(); /// Geriye dizi dönderir, tüm propertyilerin özelliklerini gösterir;
            foreach (PropertyInfo pi in propertys)
            {
                string prmAdi = "@" + pi.Name;
                object deger = pi.GetValue(entity);//// Object = Hangi değer olduğunu bilmediğimzden object yazıyor ki o otomatik olarak int mi string mi kendisi belirlesin.
                komut.Parameters.AddWithValue(prmAdi, deger);
            }
            return ToolsAraçlar.ExeNonQue(komut);

        }
    }
}
