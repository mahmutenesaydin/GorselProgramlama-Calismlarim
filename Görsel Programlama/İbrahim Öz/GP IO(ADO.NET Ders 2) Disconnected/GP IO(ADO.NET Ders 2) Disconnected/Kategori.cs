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

namespace GP_IO_ADO.NET_Ders_2__Disconnected
{
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ABC-BILGISAYAR\\MHMTENES13;Initial Catalog=Northwind;Integrated Security=True");

        private void KategoriListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Categories", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["CategoryID"].Visible = false;
        }

        private void Kategori_Load(object sender, EventArgs e)
        {
            KategoriListesi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string KategoriAdi = txtKategAdi.Text;
            string Tanimi = txtTanım.Text;

            if (KategoriAdi == "" || Tanimi == "")
            {
                MessageBox.Show("Lütfen doldurun");
                return;
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format("Insert into Categories(CategoryName,Description)values('{0}','{1}')", KategoriAdi, Tanimi);
            komut.Connection = baglanti;

            int Etkilenen = komut.ExecuteNonQuery();
            if (Etkilenen>0)
            {
                MessageBox.Show("Kayıt başarılı");
                KategoriListesi();
            }
            else
            {
                MessageBox.Show("Kayıt başarısız");
            }
            baglanti.Close();
        }
    }
}
