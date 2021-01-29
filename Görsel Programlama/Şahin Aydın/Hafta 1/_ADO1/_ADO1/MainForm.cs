using _DataLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ADO1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        DatabaseBusiness db = new DatabaseBusiness();

        private void MainForm_Load(object sender, EventArgs e)
        {
            ProductsList();
        }

        private void ProductsList()
        {
            dgvProducts.DataSource = db.ExecuteAdapter("SP_Select");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Lütfen bilgileri doldurun!", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult r = MessageBox.Show("Bilgiler kaydedilecek. Emin misiniz?", "KAYIT ONAY", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                switch (r)
                {
                    case DialogResult.Yes:
                       db.ExecuteCommand("SP_Insert", new SqlParameter[] {
                            new SqlParameter("@Name", txtName.Text),
                            new SqlParameter("@Price", txtPrice.Text)
                        });
                        ProductsList();
                        break;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        private void dgvProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvProducts.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            txtName.Text = dgvProducts.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txtPrice.Text = dgvProducts.Rows[e.RowIndex].Cells["Price"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Lütfen formu doldurun!", "GÜNCELLEME", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult r = MessageBox.Show("Güncelleme işlemini yapmak istediğinizden emini misiniz?", "GÜNCELLEME ONAY", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                switch (r)
                {

                    case DialogResult.Yes:
                        db.ExecuteCommand("SP_Update", new SqlParameter[] {
                            new SqlParameter("@Id", txtId.Text),
                            new SqlParameter("@Name", txtName.Text),
                            new SqlParameter("@Price", txtPrice.Text)
                        });
                        ProductsList();
                        break;

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Lütfen formu doldurun!", "GÜNCELLEME", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult r = MessageBox.Show("Silme işlemini yapmak istediğinizden emini misiniz?", "SİLME ONAY", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                switch (r)
                {

                    case DialogResult.Yes:
                       db.ExecuteCommand("SP_Delete", new SqlParameter[] {
                            new SqlParameter("@Id", txtId.Text)
                        });
                        ProductsList();
                        break;

                }
            }
        }

        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource= db.ExecuteAdapter("SP_GetProductById", new SqlParameter[] {
                new SqlParameter("@Id",txtFind.Text)
            });
        }
    }
}
