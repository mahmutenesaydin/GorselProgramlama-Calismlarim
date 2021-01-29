using Ders7Çalışma.Entity;
using Ders7ÇalışmaLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_IO_ADO.NET_Ders_7__Üst_Düzey_Mimari
{
    public partial class UrunForm : Form
    {
        public UrunForm()
        {
            InitializeComponent();
        }

        UrunlerORM UrunOrm = new UrunlerORM();

        private void Urunler_Load(object sender, EventArgs e)
        {
            // UrunlerORM UrunOrm = new UrunlerORM();
            dataGridView1.DataSource = UrunOrm.Listele();

            TedarikcilerORM TedOrm = new TedarikcilerORM();
            cmbTedarik.DataSource = TedOrm.Listele();
            cmbTedarik.DisplayMember = "SirketAdi";  //Combobox ta görünecek olan hücre
            cmbTedarik.ValueMember = "TedarikciID";  //Arka Planda tutulacak olan hücre

            KategoriORM ktgORM = new KategoriORM();
            cmbKategori.DataSource = ktgORM.Listele();
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "KategoriID";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urunler urun = new Urunler();
            urun.UrunAdi = txtUrunAdi.Text;
            urun.BirimFiyati = numFiyat.Value;
            urun.HedefStokDuzeyi = Convert.ToInt16(numStok.Value);
            urun.KategoriID = (int)cmbKategori.SelectedValue;
            urun.TedarikciID = (int)cmbTedarik.SelectedValue;
            urun.BirimdekiMiktar = "";

            bool sonuc = UrunOrm.Ekle(urun);
            if (sonuc)
            {
                MessageBox.Show("Ürün eklendi");
                dataGridView1.DataSource = UrunOrm.Listele();
            }
            else
            {
                MessageBox.Show("HATA");
            }
        }
    }
}
