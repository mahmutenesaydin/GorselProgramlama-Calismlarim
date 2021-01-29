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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ABC-BILGISAYAR\\MHMTENES13;Initial Catalog=Northwind;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunListesi();
        }

        private void UrunListesi()
        {
            //Disconnected ile veri işleme yöntemi;
            SqlDataAdapter da = new SqlDataAdapter("Select * from Products", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["CategoryID"].Visible = false; //Görünümü gizlemek
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string UrunAdi = txtAdi.Text;
            decimal Fiyat = numFiyat.Value;
            decimal Stok = numStok.Value;
            if (UrunAdi == "" || Fiyat == null || Stok == null)
            {
                MessageBox.Show("Lütfen alanları doldurunuz");
                return;
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format("Insert into Products(ProductName,UnitPrice,UnitsInStock)values('{0}',{1},{2})", UrunAdi, Fiyat, Stok);
            komut.Connection = baglanti;
            int Etkilenen = komut.ExecuteNonQuery();
            if (Etkilenen > 0)
            {
                MessageBox.Show("Kayıt başarılı");
                UrunListesi();
            }
            else            
                MessageBox.Show("Hata meydana geldi");            
            baglanti.Close();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            Kategori kf = new Kategori();
            kf.ShowDialog();
        }

        //3.DERSİN BAŞLANGICI(2.DERSTEKİ PROJENİN DEVAMI)

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdi.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
            txtAdi.Tag = dataGridView1.CurrentRow.Cells["ProductID"].Value;
            numFiyat.Value = (decimal)dataGridView1.CurrentRow.Cells["UnitPrice"].Value;
            numStok.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["UnitsInStock"].Value);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format("Update Products set ProductName='{0}', UnitPrice={1}, UnitsInStock={2} where ProductID={3}", txtAdi.Text, numFiyat.Value, numStok.Value, txtAdi.Tag);
            komut.Connection = baglanti;
            baglanti.Open();
            try
            {
                int Etkilenen = komut.ExecuteNonQuery();
                baglanti.Close();
                if (Etkilenen > 0)
                {
                    MessageBox.Show("Ürün güncellendi");
                    UrunListesi();
                }
                else
                {
                    MessageBox.Show("Güncellenmedi");
                }
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Güncellenmedi"+ex.Message);
            }

            //int Etkilenen = komut.ExecuteNonQuery();
            //baglanti.Close();
            //if (Etkilenen>0)
            //{
            //    MessageBox.Show("Ürün güncellendi");
            //    UrunListesi();
            //}
            //else
            //{
            //    MessageBox.Show("Güncellenmedi");
            //}
            //baglanti.Close();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                baglanti.Open();
                int ProductID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);
                SqlCommand komut = new SqlCommand(string.Format("Delete Products where ProductID={0}", ProductID), baglanti);
                int Etkilenen = komut.ExecuteNonQuery();
                if (Etkilenen > 0)
                {
                    MessageBox.Show("Ürün Silindi");
                    UrunListesi();
                }
                else
                {
                    MessageBox.Show("Silinemedi");
                }
                baglanti.Close();
            }
        }
    }
}
