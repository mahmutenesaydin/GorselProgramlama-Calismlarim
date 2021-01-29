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

namespace GP_IO_ADO.NET_Ders_4__Stored_Proc_Uygulama
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
            KategoriListele();
        }

        private void KategoriListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("prc_KategoriListelee", baglanti);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            KategoriListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SP_KategoriEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Adi", txtAdi.Text);
            komut.Parameters.AddWithValue("@Tanim", txtTanım.Text);
            int Etkilenen = komut.ExecuteNonQuery();
            if (Etkilenen > 0)
            {
                MessageBox.Show("Etklendi");
                KategoriListele();
            }
            else
            {
                MessageBox.Show("Eklenmedi");
            }
            baglanti.Close();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SP_KategoriSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["KategoriID"].Value);
                komut.Parameters.AddWithValue("@ID", id);
                int Etkilenen = komut.ExecuteNonQuery();
                if (Etkilenen > 0)
                {
                    MessageBox.Show("Silindi");
                    KategoriListele();
                }
                else
                {
                    MessageBox.Show("Silinmedi");
                }
                baglanti.Close();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SP_KategoriGuncelle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells["KategoriID"].Value);
            komut.Parameters.AddWithValue("@Adi", dataGridView1.CurrentRow.Cells["KategoriAdi"].Value);
            komut.Parameters.AddWithValue("@Tanim", dataGridView1.CurrentRow.Cells["Tanimi"].Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}