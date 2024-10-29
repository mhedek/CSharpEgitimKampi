using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            /*           
            Console.Write("Merhaba Dünya");
            Console.WriteLine("Selam");
            //

            Console.WriteLine("**** Yemek Katagorileri ****");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine();
            Console.WriteLine("**** Yemek Katagorileri ****")


            Console.Read();
            */
            #endregion

            #region StringDeğişkenler
            // DEĞİŞKENLER

            // 1- String

            //string name;
            //name = "Murat";
            //Console.Write(name);

            /*
            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Ali";
            customerSurname = "Çınar";
            customerPhone = "+90 500 400 30 20";
            customerEmail = "deneme@gmail.com";
            district = "Kadıköy";
            city = "İstanbul";

            Console.WriteLine("**** Rezervasyon Kartı ****");
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);

            Console.Read();
            */
            #endregion

            #region intDeğişkenler

            Console.WriteLine("*** Restorant Ürün ve Fiyat Listesi ***");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int hamburgerPrice,
                friesPrice,
                pizzaPrice,
                lemonadePrice,
                cakePrice,
                waterPrice;

            hamburgerPrice = 300;
            friesPrice = 150;
            pizzaPrice = 350;
            lemonadePrice = 35;
            cakePrice = 55;
            waterPrice = 10;

            Console.WriteLine("Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("Kızartma: " + friesPrice + "TL");
            Console.WriteLine("Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("Kola: " + cakePrice + "TL");
            Console.WriteLine("SU: " + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("*** Hesap Fişi ***");
            Console.WriteLine("----------------------------------------");

            int countHam, countFries, countPizza, countLemonade, countCake, countWater;
            int totalHamPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;
            int totalCakePrice;
            int totalWaterPrice;
            int totalPrice = 0;

            countHam = 3;
            countFries = 1;
            countPizza = 1;
            countLemonade = 0;
            countCake = 3;
            countWater = 3;

            totalHamPrice = hamburgerPrice * countHam;
            totalFriesPrice = friesPrice * countFries;
            totalPizzaPrice = pizzaPrice * countPizza;
            totalLemonadePrice = lemonadePrice * countLemonade;
            totalCakePrice = cakePrice * countCake;
            totalWaterPrice = waterPrice * countWater;

            Console.WriteLine("Hamburger Tutarı: " + totalHamPrice + "TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine("Kola Tutarı: " + totalCakePrice + "TL");
            Console.WriteLine("SU Tutarı: " + totalWaterPrice + "TL");

            totalPrice = totalHamPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice + totalCakePrice + totalWaterPrice;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Ödenecek Tutar: " + totalPrice + " TL");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");



            Console.Read();



            #endregion
        }
    }
}


// Yazdırma Komutları
