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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KategoriListele()
        {
            dgvKat.DataSource = Kategoriler.Select();
            //dgvKat.Columns["KategoriID"].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
             KategoriListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kategori k = new Kategori();
            k.KategoriAdi = txtKatAdi.Text;
            k.Tanimi = txtKatTanimi.Text;
            bool ekle = Kategoriler.Insert(k);
            if (ekle == true) // ("ekle" = "ekle == true") bu ikisi aynı şey; 
            {
                MessageBox.Show("Eklendi");
                KategoriListele();
            }
            else
            {
                MessageBox.Show("HATA !");
            }
        }
    }
}
