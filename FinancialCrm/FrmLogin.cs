using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void button1_Click(object sender, EventArgs e)
        {

            var userControl = db.Users.Any(x => x.Username == txtUser.Text && x.Password == txtPass.Text);

            if(userControl == true)
            {
                MessageBox.Show("Giriş Başarılı! Dasgboard Formuna Yönlendiriliyorsunuz");
                FrmDashboard fr = new FrmDashboard();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız! Kullanıcı adı veya şifre hatalı");

            }

        }
    }
}
