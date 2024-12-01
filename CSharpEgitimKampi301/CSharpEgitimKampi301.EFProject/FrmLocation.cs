using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        CSharpEgitimKampiEfTravelDbEntities db = new CSharpEgitimKampiEfTravelDbEntities();
        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new
            {
                fullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            cmbGuide.DisplayMember = "fullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Capacity = byte.Parse(numCapacity.Value.ToString());
            location.Price =decimal.Parse(txtPrice.Text);
            location.DayNight = txtDay.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı");


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removeValue = db.Location.Find(id);
            db.Location.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.Location.Find(id);
            updateValue.City = txtCity.Text;
            updateValue.Country = txtCountry.Text;
            updateValue.Capacity = byte.Parse(numCapacity.Value.ToString());
            updateValue.Price = decimal.Parse(txtPrice.Text);
            updateValue.DayNight = txtDay.Text;
            updateValue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı");

        }
    }
}
