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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        CSharpEgitimKampiEfTravelDbEntities db = new CSharpEgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString(); // Toplam location Sayısı

            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString(); // Toplam Kapasite

            lblGuideCount.Text = db.Guide.Count().ToString(); // Rehber Sayısı

            lblAvgCapacity.Text = db.Location.Average(x => x.Capacity).ToString(); // Ortalama Kapasite

            lblAvgLocationPrice.Text = db.Location.Average(x=> x.Price)?.ToString("0.00") + " ₺"; // ortalama tur fiyatı

            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault(); // son eklenen ülke

            lblKapadokyaCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

            lblTurkiyeCapacityAvg.Text =db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            var romeGuideId = db.Location.Where(x=> x.City == "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuide.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();

            var maxPrice = db.Location.Max(x => x.Price);
            lblMaxPriceLocation.Text = db.Location.Where(x => x.Price == maxPrice).Select(y=> y.City).FirstOrDefault().ToString();

            var aysegulıd = db.Guide.Where(x => x.GuideName == "Ayşegül" &&  x.GuideSurname == "Çınar").Select(y=>y.GuideId).FirstOrDefault();
            lblAysegulCınarLocationCount.Text = db.Location.Where(x => x.GuideId == aysegulıd).Count().ToString();//Count(x=> x.GuideId == aysegulıd).ToString(); bu şekilde de sonuca ulaştım
        }
    }
}
