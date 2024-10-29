using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region DoubleDeğişkenler

            //double number;

            //number = 4.15;
            //Console.WriteLine(number);
            //Console.Read();

            /*

            Console.WriteLine("--- Ürün Listesi/Birim Fİyatları ---");
            Console.WriteLine();
            Console.WriteLine();

            double applePrice, strawberryPrice, patatoPrice, tomatoPrice;
            applePrice = 14.12;
            strawberryPrice = 50.20;
            patatoPrice = 17.40;
            tomatoPrice = 23.82;

            Console.WriteLine("ELma Birim Fiyatı: " + applePrice + " TL");
            Console.WriteLine("Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            Console.WriteLine("Patates Birim Fiyatı: " + patatoPrice + " TL");
            Console.WriteLine("Domates Birim Fiyatı: " + tomatoPrice + " TL");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--- Alışveriş Fişi ---");
            Console.WriteLine();
            Console.WriteLine();

            double appleGram, strawGram, patatoGram, tomatoGram, total;

            appleGram = 2.500;
            strawGram = 0.750;
            patatoGram = 3.750;
            tomatoGram = 1.000;

            double appleTotal, strawTotal, patatoTotal, tomatoTotal;
            appleTotal = applePrice * appleGram;
            strawTotal = strawberryPrice * strawGram;
            patatoTotal = patatoPrice * patatoGram;
            tomatoTotal = tomatoPrice * tomatoGram;


            Console.WriteLine("Alınan Ürün: Elma - Birim Fiyat " + applePrice + " TL - Gramaj " + appleGram + "- Toplam Tutar = " + appleTotal + " TL");
            Console.WriteLine("Alınan Ürün: Çilek - Birim Fiyat " + strawberryPrice + " TL - Gramaj " + strawGram + "- Toplam Tutar = " + strawTotal + " TL");
            Console.WriteLine("Alınan Ürün: PAtates - Birim Fiyat " + patatoPrice + " TL - Gramaj " + patatoGram + "- Toplam Tutar = " + patatoTotal + " TL");
            Console.WriteLine("Alınan Ürün: Domates - Birim Fiyat " + tomatoPrice + " TL - Gramaj " + tomatoGram + "- Toplam Tutar = " + tomatoTotal + " TL");
            Console.WriteLine();
            Console.WriteLine();

            total = appleTotal + strawTotal + patatoTotal + tomatoTotal;

            Console.WriteLine("Toplam Ödencek Tutar: " + total + " TL");
            Console.Read();
            */
            #endregion

            #region CharDeğişkeni
            /*
            char sembol;
            sembol = 'A';
            Console.WriteLine(sembol);
            Console.Read();
            */
            #endregion

            #region KlavyedenVeriGirişleri String Değişkenleri
            /*

            Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerID;

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("Yolcu İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Yolcu Şehir Bilgisi: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaş Bilgisi: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu TC Kimlik No: ");
            passengerID = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Yolcu TC Kimlik No: " + passengerID + "\t" + " - Yolcu Adı Soyadı: " + passengerName + " " + passengerSurname 
                + "\t" +"YAŞ: " + passengerAge +"\t" +"İL / İLÇE: " + passengerDistrict + "/" + passengerCity );

            Console.Read();
            */
            #endregion

            #region KlavyedenVeriGirişleri Int Değişkenleri
            /*
            int shoePrice, computerPrice, chairPrice, tvPrice;

            shoePrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoeCount, computerCount, chairCount, tvCount;
            Console.Write("Lütfen Aldığınız ayakkabı adetini giriniz: ");
            shoeCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız Bilgisayar adetini giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız Sandalye adetini giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız TV adetini giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int total = shoePrice * shoeCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Toplam Ödenmesi Gereken Tutar: " + total);
            Console.Read();
            */
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            /*
            double exam1, exam2, exam3, result;

            Console.Write("1. Sınav Notunuzu Giriniz: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("2. Sınav Notunuzu Giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("3. Sınav Notunuzu Giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine();
            Console.WriteLine("Not Ortalamanız: " + result);
            Console.Read();
            */
            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;

            Console.Write("Cinsiyetinizi Giriniz(K / E): ");
            gender = char.Parse(Console.ReadLine());

            if (gender == 'K')
            {
                Console.WriteLine("Cinsiyetiniz: Kadın");
            }
            else if(gender == 'E')
            {
                Console.WriteLine("Cinsiyetiniz: Erkek");
            }
            else
            {
                Console.WriteLine("Yanlış Değer Girişi!!");
            }

            Console.Read();

            #endregion
        }
    }
}
