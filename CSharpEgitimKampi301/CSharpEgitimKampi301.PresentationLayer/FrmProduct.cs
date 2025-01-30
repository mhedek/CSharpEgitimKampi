using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        public readonly IProductService _productService;
        private readonly CategoryManager _categoryService;

        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProduct());
            _categoryService = new CategoryManager(new EfCategory());
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var productValues = _productService.TGetAll();
            dataGridView1.DataSource = productValues;
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = _productService.TGetById(id);
            _productService.TDelete(values);
            MessageBox.Show("Silme İşlemi Başarılı");

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CategoryId = int.Parse(cmbKategori.SelectedValue.ToString());
            product.ProductPrice = decimal.Parse(txtFiyat.Text);
            product.ProductName = txtAd.Text;
            product.ProductDescription = txtAcıklama.Text;
            product.ProductStock = int.Parse(txtStok.Text);
            _productService.TInsert(product);
            MessageBox.Show("Ekleme İşlemi Başarılı");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = _productService.TGetById(id);
            values.CategoryId = int.Parse(cmbKategori.SelectedValue.ToString());
            values.ProductPrice = decimal.Parse(txtFiyat.Text);
            values.ProductName = txtAd.Text;
            values.ProductDescription = txtAcıklama.Text;
            values.ProductStock = int.Parse(txtStok.Text);
            _productService.TUpdate(values);
            MessageBox.Show("Güncelleme İşlemi Başarılı");

        }

        private void btnGetbyId_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = _productService.TGetById(id);
            dataGridView1.DataSource = values;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtStok.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAcıklama.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtAcıklama.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbKategori.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _categoryService.TGetAll();
            cmbKategori.DataSource = values;
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "CategoryId";
        }
    }
}
