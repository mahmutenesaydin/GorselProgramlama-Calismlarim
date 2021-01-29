using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        CategoryBusiness ctgbus = new CategoryBusiness();

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctgbus.List();
        }
    }
}
