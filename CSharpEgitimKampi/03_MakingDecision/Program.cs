﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region IF ELSE
            /*
            Console.Write("Lütfen Şifreyi Giriniz: ");
            string password;
            password = Console.ReadLine();

            if(password == "abcd")
            {
                Console.WriteLine("Şifre Doğru");
            }
            else
            {
                Console.WriteLine("Şifre Yanlış");
            }

            Console.Read();

            */


            ///////////////////////////////



            /*
            string capital, country;

            Console.Write("Başkenti Giriniz: ");
            capital = Console.ReadLine();

            Console.Write("Ülke Giriniz: ");
            country = Console.ReadLine();

            if (capital == "ankara" & country == "türkiye")
            {
                Console.Write("Veriler Doğrulandı");
            }
            else
            {
                Console.Write("Hatalı Bilgi");
            }

            Console.Read()
            */

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if(number == 5 )
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}

            //Console.Read();


            //int exam1, exam2, exam3, average;
            //string result ="Hata!";

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalama = " + average);

            //if(average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if(average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if(average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if(average > 84)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);
            //Console.Read();

            //string city;
            //Console.Write("Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();

            //if(city == "adana" | city == "ankara" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}
            //Console.Read();

            //string username;
            //Console.Write("Kullancı Adınızı Giriniz: ");
            //username = Console.ReadLine();

            //if(username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı Kabul edilmedi...");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}
            //Console.Read();

            #endregion


            #region MOD Islemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("1.Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1.Sayının 2.Sayıya bölümünden kalan: " + result);

            //Console.Write("Sayı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if(number%2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}
            //Console.Read();

            #endregion

            #region Char Degiskenleri ile Karar Yapıları

            //char team;
            //Console.Write("Takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'F' | team == 'f')
            //{
            //    Console.WriteLine("FENERBAHÇE");
            //}
            //if(team == 'B' | team == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //if(team == 'G' | team == 'g')
            //{
            //    Console.WriteLine("galatasaray");
            //}
            //Console.Read();



            #endregion

            #region Ornek Uygulama

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını görmek istediğiz menü seçiniz: ");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Kebabı");
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ÇORBALAR------------");
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Domates Çorbası");
            //    Console.WriteLine("------------ÇORBALAR------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Karışık Pizza");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine("1-Limonata");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //}
            //Console.Read();

            #endregion

            #region Switch Case

            //Console.Write("Ay  Girişi Giriniz: ");
            //int monthNumbere = int.Parse(Console.ReadLine());

            //switch(monthNumbere)
            //{
            //    case 1: Console.Write("Ocak");
            //        break;
            //    case 2: Console.Write("Şubat");
            //        break;
            //    case 3: Console.Write("Mart");
            //        break;
            //    case 4: Console.Write("Nisan");
            //        break;
            //    case 5:
            //        Console.Write("Mayıs");
            //        break;
            //    case 6:
            //        Console.Write("Haziran");
            //        break;
            //    case 7:
            //        Console.Write("Temmuz");
            //        break;
            //    case 8:
            //        Console.Write("Ağustos");
            //        break;
            //    case 9:
            //        Console.Write("Eylül");
            //        break;
            //    case 10:
            //        Console.Write("Ekim");
            //        break;
            //    case 11:
            //        Console.Write("Kasım");
            //        break;
            //    case 12:
            //        Console.Write("Aralık");
            //        break;
            //    default: Console.Write("Hatalo veri girişi");
            //        break;
            //}

            //Console.Read();

            #endregion

            #region Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("Birinci sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch(symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam = " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark = " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım = " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm = " + result);
            //        break;
            //    default: Console.WriteLine("Geçersiz İşlem");
            //        break;
            //}
            //Console.Read();

            #endregion
        }
    }
}
