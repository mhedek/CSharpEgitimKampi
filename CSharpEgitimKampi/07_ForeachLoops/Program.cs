using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            // Foreach (1;2;3;4)

            // 1; Değişken türü
            //2: Değişken türü
            //3: In
            //4: Liste, Koleksiyon, Dizi

            //string[] cities = { "milano", "roma", "budapeşt", "ankara", "istanbul", "varşova" };

            //foreach( string x in cities )
            //{
            //    Console.WriteLine( x );
            //}


            //int[] numbers = { 23, 46, 28, 436, 435, 576 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 23, 46, 28, 436, 435, 576 };

            //foreach (int i in numbers)
            //{
            //    if(i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int[] numbers = { 23, 46, 28, 436, 435, 576 };

            //int total = 0;

            //foreach(int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";

            //foreach( char i in word)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Örnek Sınav sistemi Uygulaması
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("***** C# NOT UYGULAMASI *****");
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();


            //Sınıftaki öğrenci sayısı kullanıcıdan alma
            Console.Write("Sınıfta kaç öğrenci var: ");
            int studentcount = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");
            Console.WriteLine();

            // öğrenci isimlerini ve not ortalamasını saklayacak diziler
            string[] studentNames = new string[studentcount];
            double[] studentExamAvg = new double[studentcount];


            for(int i = 0; i < studentcount; i++)
            {
                Console.WriteLine();
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();
                Console.WriteLine();

                double totalexamResult = 0;

                // Her öğrenci için 3 sınav girişi

                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. Sınav notu: ");
                    double value = double.Parse(Console.ReadLine()); 
                    
                    totalexamResult += value; // Notları Topluyoruz
                }
                studentExamAvg[i] = totalexamResult / 3;
            }
            // Sınav ortalamaları
            //for(int i = 0; i<studentcount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]} ");
            //}

            // Dersten geçme ve kalma durumları
            Console.WriteLine();
            for (int i = 0; i < studentcount; i++)
            {
                if (studentExamAvg[i]  >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci {studentExamAvg[i]} ortalama ile GEÇMİŞTİR");
                }
                else
                {

                    Console.WriteLine($"{studentNames[i]} adlı öğrenci {studentExamAvg[i]} ortalama ile KALMIŞTIR");
                }
            }
            

            #endregion

            Console.Read();

        }
    }
}
