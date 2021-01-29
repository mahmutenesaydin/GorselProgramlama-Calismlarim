using _ProductsApp.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ProductsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CategoryBusiness cb = new CategoryBusiness();
        ProductBusiness pb = new ProductBusiness();

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCategories.DataSource = cb.List();
            cmbCategories.DisplayMember = "Name";
            cmbCategories.ValueMember = "Id";

            dataGridView1.DataSource = pb.List();


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            pb.Insert(new Models.Product
            {
                Name = txtName.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                CategoryId = Convert.ToInt32(cmbCategories.SelectedValue)
            });
            dataGridView1.DataSource = pb.List();
        }
    }
}
