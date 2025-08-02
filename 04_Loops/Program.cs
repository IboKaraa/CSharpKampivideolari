using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FOR DÖNGÜSÜ

            //for(x;y;z)
            //x : başlangıç değer
            //y:bitiş değeri
            //z: artış - azalış miktarı

            //int i;
            //for (i=1;i<=5;i++)
            //{
            //    Console.WriteLine("C# Eğitim kampı");
            //}

            //for (int i =1;i<=20;i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i=3;i<=50;i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğinz adedi giriniz : ");
            //int finshvalue=int.Parse(Console.ReadLine());   

            //for (int i = 1; i <= finshvalue; i++)
            //{
            //    Console.WriteLine("YAŞASIN CUMHURİYET");
            //}

            #endregion

            #region FOR DÖNGÜSÜ VE KARAR YAPILARI

            //for(int i=5;i<=100;i+=5)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int totalvalue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //        totalvalue += i;
            //}
            //Console.Write(totalvalue);

            //int totalvalue = 0;

            //for(int i = 1;i<=20;i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine("1 ile 20 arasındaki çift sayıların toplamı : " + totalvalue);

            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if(i%7==0)
            //    {
            //        count++;

            //    }
            //}
            //Console.WriteLine("1 ile 50 arasındaki 7'nin katı olan sayıların adedi : " + count);

            //1-2-4-8-16...
            //int bacterium = 1;

            //for (int i=1;i<=24;i++)
            //{
            //    bacterium *= 2; 
            //    Console.WriteLine(i+". saat sonra bakteri sayısı : " + bacterium);
            //}

            #endregion

            #region WHILE DÖNGÜSÜ

            //while(koşul)
            //{
            //koşul sağlandığı sürece çalışacak kodlar
            //}

            //int i = 1;  

            //while(i<=10)
            //{
            //     Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;  

            //while (i <= 10)
            //{
            //   if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;    

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("1 ile 10 arasındaki sayıların toplamı : " + sum);



            #endregion

            #region ÖRNEK SINAV SORUSU ***

            //Klavyeden girilen 3 basamaklı bir sayının basamaklarını toplayan programı yazınız.
            //456
            //Console.Write("Lütfen 3 basamaklı bir sayı giriniz : ");
            //int number = int.Parse(Console.ReadLine());
            //int ones,tens,hundreds;
            //int sum = 0;

            //ones = number % 10; // 456 % 10 = 6
            //tens = (number % 100) / 10; // 456 % 100 = 56 / 10 = 5
            //hundreds = number / 100;// 456 / 100 = 4

            //sum = ones + tens + hundreds;

            //Console.WriteLine("Girilen sayının birler basamağı : " + ones);
            //Console.WriteLine("Girilen sayının onlar basamağı : " + tens);
            //Console.WriteLine("Girilen sayının yüzler basamağı : " + hundreds);
            //Console.Write("SAYININ BASAMAK DEĞERLERİ TOPLAMI :"+sum);
            #endregion

            Console.Read();
        }
    }
}
