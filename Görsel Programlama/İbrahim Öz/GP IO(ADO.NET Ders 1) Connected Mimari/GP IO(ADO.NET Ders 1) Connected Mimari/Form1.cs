using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_IO_ADO.NET_Ders_1__Connected_Mimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=ABC-BILGISAYAR\\MHMTENES13;Initial Catalog=Northwind;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select * from Products";
            komut.Connection = baglanti;

            baglanti.Open();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                string Adi = oku["ProductName"].ToString();
                string Fiyat = oku["UnitPrice"].ToString();
                string Stok = oku["UnitsInStock"].ToString();

                listUrun.Items.Add(string.Format("{0}-{1}-{2}", Adi, Fiyat, Stok));
            }
            baglanti.Close();
        }
    }
}
