using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Crud --> Creat-Read-Update-Delete

            //Console.WriteLine("****** Menü Sipariş İşlem Paneli ******");
            //Console.WriteLine();

            //Console.WriteLine("----------------------------------------");
            //Console.Write("Eklemek istediğiniz katagori adı: ");
            //string catagoryName = Console.ReadLine();



            //SqlConnection connection = new SqlConnection("Data Source= LAPTOP-5D42MKKG; initial catalog=EgitimKampiDb; integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", catagoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi");

            #region Kategori Ekleme İşlemi

            //Console.Write("EKlemek istediğiniz ürünün adını giriniz: ");
            //string productName = Console.ReadLine();

            //Console.Write("Ekleme istediğiniz ürünün fiyatını giriniz: ");
            //decimal productPrice = int.Parse(Console.ReadLine());

            //Console.Write("Eklemek istediğiniz ürünün stok durumunu giriniz (True/False): ");
            //bool productStatus = bool.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source =LAPTOP-5D42MKKG; initial catalog=EgitimKampiDb; integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (productName, productPrice, productStatus) values (@p1,@p2,@p3) ", connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", productStatus);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün bilgileri başarıyla eklenmiştir");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source =LAPTOP-5D42MKKG; initial catalog=EgitimKampiDb; integrated security = true ");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();
            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek ürün ID: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source= LAPTOP-5D42MKKG; initial catalog=EgitimKampiDb; integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme İşlemi Yapıldı");

            #endregion

            #region Ürün Güncelleme İşlemi

            Console.Write("Güncellencek Ürün ID: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellencek Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellencek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source= LAPTOP-5D42MKKG; initial catalog=EgitimKampiDb; integrated security = true");
            connection.Open();

            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName = @productName, ProductPrice= @productPrice where ProductId = @productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            connection.Close();

            Console.Write("Güncelleme Başarılı");

            #endregion

            Console.Read();

        }
    }
}
