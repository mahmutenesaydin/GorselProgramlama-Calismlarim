using KuzeyYeli.ORM.Entity;
using KuzeyYeli.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_IO_ADO_Ders_5__n_Tier_Katmansal_Mimar
{
    public partial class UrunForm : Form
    {
        public UrunForm()
        {
            InitializeComponent();
        }

        private void UrunListele()
        {

            dgvUrun.DataSource = Urunler.Select();
        }

        private void UrunForm_Load(object sender, EventArgs e)
        {
            cmbKategori.DisplayMember = "KategoriAdi"; //combox'da kategori adının çıkmasını sağlar
            cmbKategori.ValueMember = "KategoriID"; // combox'da kategori ID'sinin çıkmasını sağlar
            cmbKategori.DataSource = Kategoriler.Select();

            cmbTedarik.DisplayMember = "SirketAdi";
            cmbTedarik.ValueMember = "TedarikciID";
            cmbTedarik.DataSource = Tedarikciler.Select();

            UrunListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            u.UrunAdi = txtUrunAdi.Text;
            u.BirimFiyati = numFiyat.Value;
            u.HedefStokDüzeyi = Convert.ToInt16(numStok.Value);
            u.KategoriID = (int)cmbKategori.SelectedValue;
            u.TedarikciID = (int)cmbTedarik.SelectedValue;

            bool sonuc = Urunler.Insert(u);
            if (sonuc)
            {
                MessageBox.Show("Ürün eklendi");
                UrunListele();
            }
            else
            {
                MessageBox.Show("HATA");
            }
        }
    }
}
