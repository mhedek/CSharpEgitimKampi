using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
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
    public partial class FrmCategort : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategort ()
        {
            _categoryService = new CategoryManager(new EfCategory());    
            InitializeComponent ();
        }

        public void listeleme()
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCatagoryName.Text;
            

            if (rdbActive.Checked)
            {
                category.CategoryStatus = true;
                _categoryService.TInsert(category);
                MessageBox.Show("Ekleme Başarılı");
                listeleme();

            }
            else if (rdbPassive.Checked)
            {
                category.CategoryStatus = false;
                _categoryService.TInsert(category);
                MessageBox.Show("Ekleme Başarılı");
                listeleme();
            }
            else
            {
                category.CategoryStatus = false;
                _categoryService.TInsert(category);
                MessageBox.Show("Kategori Durumu seçilmediği için false olarak eklenmiştir");
                listeleme();
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCatagoryId.Text);
            var deletedValues = _categoryService.TGetById(id);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("Silme İşlemi Başarılı");
            listeleme();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //Category category = new Category();
            int updateId = int.Parse(txtCatagoryId.Text);
            var updatedvalue = _categoryService.TGetById(updateId);
            updatedvalue.CategoryName = txtCatagoryName.Text;
            updatedvalue.CategoryStatus = true;
            _categoryService.TUpdate(updatedvalue);
            MessageBox.Show("Güncelleme İşlemi Başarılı");
            listeleme();

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCatagoryId.Text);
            var values = _categoryService.TGetById(id);
            dataGridView1.DataSource = values;
        }

        private void FrmCategort_Load(object sender, EventArgs e)
        {
           
        }
    }
}
