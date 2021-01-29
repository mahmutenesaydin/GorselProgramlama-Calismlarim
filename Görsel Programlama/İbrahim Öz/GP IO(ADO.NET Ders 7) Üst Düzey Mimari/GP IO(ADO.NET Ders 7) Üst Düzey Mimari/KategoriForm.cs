using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ders7ÇalışmaLibrary;
using Ders7Çalışma.Entity;

namespace GP_IO_ADO.NET_Ders_7__Üst_Düzey_Mimari
{
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }
        KategoriORM ktgORM = new KategoriORM();

        private void Kategoriler_Load(object sender, EventArgs e)
        {
            //KategoriORM ktgORM = new KategoriORM();
            ktgORM.Sil(12);
            dgvKat.DataSource = ktgORM.Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kategoriler ktg = new Kategoriler();
            ktg.KategoriAdi = txtKtgAdi.Text;
            ktg.Tanimi = txtKtgTanimi.Text;
            ktg.Resim = new byte[0];
            bool sonuc = ktgORM.Ekle(ktg);
            if (sonuc)
            {
                MessageBox.Show("Olmuştur paşa");
                dgvKat.DataSource = ktgORM.Listele();
            }
            else
            {
                MessageBox.Show("Olmadı be gülüm");
            }
        }
    }
}
