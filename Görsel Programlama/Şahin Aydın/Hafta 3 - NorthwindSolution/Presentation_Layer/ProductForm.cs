using BusinessLayer;
using DataLayer;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            this.Load += ProductForm_Load;

            pieChart1.InnerRadius = 100;
            pieChart1.LegendLocation = LiveCharts.LegendLocation.Right;
            SeriesCollection _series = new SeriesCollection();
            foreach (var p in prodBus.ProductsStockByCategory())
            {
                _series.Add(new PieSeries
                {
                    Title = p.CategoryName,
                    Values = new ChartValues<int> { (int)p.Stock },
                    DataLabels=true
                });
            }
            pieChart1.Series = _series;

        }
        CategoryBusiness catBus = new CategoryBusiness();
        SupplierBusiness supBus = new SupplierBusiness();
        ProductBusiness prodBus = new ProductBusiness();

        private void ListProducts()
        {
            NorthwindEntities db = new NorthwindEntities();
            //LİNQ(Language Integrated Query)
            var products = (from p in db.Products
                            select new
                            {
                                p.ProductID,
                                p.ProductName,
                                p.UnitsInStock,
                                p.UnitPrice
                            }).ToList();
            dgvProducts.DataSource =products;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            cmbCategory.SetDataSource<Category>(catBus.ListForComboBox(), "CategoryName", "CategoryId");
            cmbSupplier.SetDataSource<Supplier>(supBus.ListForComboBox(), "CompanyName", "SupplierId");

            ListProducts();
        }

        private void dgvProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Product p = prodBus.Read(Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["ProductId"].Value));
            txtProductId.Text = p.ProductID.ToString();
            txtProductName.Text = p.ProductName;
            txtQuantityPerUnit.Text = p.QuantityPerUnit;
            txtReorderLevel.Text = p.ReorderLevel.ToString();
            txtUnitPrice.Text = p.UnitPrice.ToString();
            txtUnitsInStock.Text = p.UnitsInStock.ToString();
            txtUnitsOnOrder.Text = p.UnitsOnOrder.ToString();
            cmbCategory.SelectedValue = p.CategoryID;
            cmbSupplier.SelectedValue = p.SupplierID;
            cbDiscontinued.Checked = p.Discontinued;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Product p = new Product
            {
                ProductName = txtProductName.Text,
                QuantityPerUnit = txtQuantityPerUnit.Text,
                ReorderLevel = Convert.ToInt16(txtReorderLevel.Text),
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text),
                UnitsOnOrder = Convert.ToInt16(txtUnitsOnOrder.Text),
                CategoryID = Convert.ToInt32(cmbCategory.SelectedValue),
                SupplierID = Convert.ToInt32(cmbSupplier.SelectedValue),
                Discontinued = cbDiscontinued.Checked
            };
            prodBus.Create(p);
            ListProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product p = prodBus.Read(Convert.ToInt32(txtProductId.Text));

            p.ProductID = Convert.ToInt32(txtProductId.Text);
            p.ProductName = txtProductName.Text;
            p.QuantityPerUnit = txtQuantityPerUnit.Text;
            p.ReorderLevel = Convert.ToInt16(txtReorderLevel.Text);
            p.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            p.UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text);
            p.UnitsOnOrder = Convert.ToInt16(txtUnitsOnOrder.Text);
            p.CategoryID = Convert.ToInt32(cmbCategory.SelectedValue);
            p.SupplierID = Convert.ToInt32(cmbSupplier.SelectedValue);
            p.Discontinued = cbDiscontinued.Checked;
            prodBus.Update(p);
            ListProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            prodBus.Delete(Convert.ToInt32(txtProductId.Text));
            ListProducts();
        }
    }
}
