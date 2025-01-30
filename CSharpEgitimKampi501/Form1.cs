using CSharpEgitimKampi501.Dtos;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=LAPTOP-5D42MKKG; initial Catalog=EgitimKampi501Db;integrated security=true");

        private async void btnList_Click(object sender, EventArgs e)
        {
            string query = "Select * From TblProduct";
            var values = await connection.QueryAsync<ResultProductDto>(query);
            dataGridView1.DataSource = values;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "insert into TblProduct (ProductName,ProductStock,ProductPrice,ProductCategory ) values (@productName,@productStock,@productPrice,@productCategory)";
            var parameters = new DynamicParameters();
            parameters.Add("@productName", txtName.Text);
            parameters.Add("@productStock", txtStock.Text);
            parameters.Add("@productPrice", txtPrice.Text);
            parameters.Add("@productCategory", txtCategory.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Ekleme işlemi başarılı");
        }

        private async void btnDeleted_Click(object sender, EventArgs e)
        {
            string query = "Delete From TblProduct Where ProductId = @productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", txtId.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Silme işlemi başarılı");
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update TblProduct Set ProductName=@productName,ProductStock=@productStock,ProductPrice=@productPrice,ProductCategory=@productCategory Where ProductId = @productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productName", txtName.Text);
            parameters.Add("@productStock", txtStock.Text);
            parameters.Add("@productPrice", txtPrice.Text);
            parameters.Add("@productCategory", txtCategory.Text);
            parameters.Add("@productId", txtId.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Güncelleme işlemi başarılı");

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string query = "Select Count(*) From TblProduct";
            var productTotalCount = await connection.QueryFirstOrDefaultAsync<int>(query);
            lblTopKitap.Text = productTotalCount.ToString();

            string query2 = "Select ProductName From TblProduct Where ProductPrice=(Select Max(ProductPrice) From TblProduct)";
            var maxProductName = await connection.QueryFirstOrDefaultAsync<string>(query2);
            lblMaxProductName.Text = maxProductName.ToString();

            string query3 = "Select Count(Distinct(ProductCategory)) From TblProduct";
            var distinctProductCount = await connection.QueryFirstOrDefaultAsync<int>(query3);
            lblProductCount.Text = distinctProductCount.ToString();

        }
    }
}
