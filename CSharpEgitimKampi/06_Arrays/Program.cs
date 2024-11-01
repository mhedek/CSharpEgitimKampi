﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel dizi örnekleri

            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[Eleman Sayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[1]);

            //string[] cities = new string[5];
            //cities[0] = "Milaano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[5]); //atanmayan elemanın default  değeri sıfırdır(0)

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tğm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for(int i = 0; i<colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 74, 33, 52, 63, 90 };

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] sembols = { 'a', 'b', 'c' };

            //for(int i = 0; i < sembols.Length; i++)
            //{
            //    Console.WriteLine(sembols[i]);
            //}

            //int[] myArray = { 47, 64, 78, 94, 45, 100, 43 };
            //int maxNumber = myArray[0];

            //for(int i = 0;  i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "Ali", "ahmet", "ayşe", "buse", "cem" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 75, 23, 68, 245, 265 };
            //Array.Sort(numbers); // Küçükten büyüğe doğru sıralıyor
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 75, 23, 68, 245, 265 };
            //Array.Reverse(numbers); // Listeyi tersteen sıralar

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotları

            //string[] customers = { "Ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 75, 23, 68, 245, 265 };
            //Console.WriteLine("Dizinın en büyük elemanı: " + numbers.Max() + " Dizinin en küçük elemanı: " + numbers.Min());

            #endregion

            #region kullanıcıdan değer alma

            //string[] cities = new string[5];

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------------------");

            //for(int i = 0; i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            int[] numbers = { 10, 20, 30, 40, 50,22,33,55,77 };

            Console.WriteLine("Çift Sayılar");

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Tek Sayılar");

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }


            #endregion

            Console.Read();
        }
    }
}
