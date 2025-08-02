using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_foreachloops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region FOREACH DÖNGÜSÜ

            //foreach(1;2;3;4)

            //1:değişken türü
            //2:değişken adı
            //3:in 
            //4:dizi,liste,koleksiyon adı

            //string[] cities = { "Ankara", "İstanbul", "Budapeşte", "Varşova","Milano","Roma" };
            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int x in numbers)
            //{
            //    if (x % 2 == 0)
            //    {
            //        Console.WriteLine(x + " sayısı çifttir.");
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int totalsum = 0;
            //foreach (int i in numbers)
            //{
            //    totalsum += i;
            //}
            //Console.WriteLine("Toplam: " + totalsum);

            //List<int> liste = new List<int>()
            //{
            //    1,2,3,5,8
            //};
            //foreach (int i in liste)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region ÖRNEK SINAV SİSTEMİ UYGULAMASI

            Console.WriteLine("****-C# EĞİTİM KAMPI SINAV UYGULAMSI");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //sınıftski öğrenci sayısını alalım
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: "); 
            int studentcount=int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //öğrencilerin isimlerini ve sınav notlarını saklayacakdiziler
            string[] studentsname = new string[studentcount];
            double[] studentexamaverage = new double[studentcount];

            for(int i=0;i<studentcount; i++)
            {
                Console.Write($"{i+1}. öğrencinin adını girin :");
                studentsname[i] = Console.ReadLine();

                double totalexamaresult = 0;

                //her öğrenci içn 3 sınav girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentsname[i]} adlı öğrencinin {j + 1}. sınav notunu girin :");
                    double value= double.Parse(Console.ReadLine());
                    totalexamaresult += value;//notları topluyoruz
                }
                studentexamaverage[i] = totalexamaresult / 3;//notların ortalamasını alıyoruz
                Console.WriteLine("------------------------------");

            }

            //öğrencilerin ortalamaları

            for (int i=0;i<studentcount; i++)
            {
                Console.WriteLine($"{studentsname[i]} adlı öğrencinin ortalaması: {studentexamaverage[i]}");

                
                Console.WriteLine();
                //öğrencilerin ortalamaları ve geçip kalma durumaları

                if (studentexamaverage[i] >= 50)
                {
                    Console.WriteLine($"{studentsname[i]} adlı öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentsname[i]} adlı öğrenci dersten kaldı.");
                }

                Console.WriteLine("------------------------------");
            }

            #endregion 

            Console.Read();
        }
    }
}
