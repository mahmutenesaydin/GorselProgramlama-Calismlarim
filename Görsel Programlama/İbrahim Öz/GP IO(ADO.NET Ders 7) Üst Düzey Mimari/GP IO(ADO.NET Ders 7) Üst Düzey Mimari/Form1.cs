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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UrunForm urunForm = new UrunForm();
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (urunForm.IsDisposed)
                urunForm = new UrunForm();
            urunForm.MdiParent = this;
            urunForm.Show();
        }
        KategoriForm ktgForm = new KategoriForm();
        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ktgForm.IsDisposed)
                ktgForm = new KategoriForm();
            ktgForm.MdiParent = this;
            ktgForm.Show();
        }
    }
}
