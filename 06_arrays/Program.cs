using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TEMEL DİZİ ÖRNEKLERİ

            //2,4,6,8,10,12,14,16,18,20
            //sarı kırızı yeşil mavi mor
            //adana istanbul ankara izmir

            //değişkentürü[] diziadı = new değikentürü[elemansayısı];
            //string[] colors = new string[4];
            //colors[0] = "sarı";
            //colors[1] = "kırmızı";
            //colors[2] = "yeşil";
            //colors[3] = "mavi";
            //Console.WriteLine(colors[0]); //sarı

            //string[] cities = new string[4];
            //cities[0] = "Adana";
            //cities[1] = "İstanbul";
            //cities[2] = "Ankara";
            //cities[3] = "İzmir";
            //Console.WriteLine(cities[3]); //Adana

            //int[] numbers = new int[10];
            //numbers[0] = 2;
            //numbers[1] = 4;
            //numbers[2] = 6;
            //numbers[3] = 8;
            //numbers[7] = 10;
            //Console.WriteLine(numbers[7]); //10
            //Console.WriteLine(numbers[10]); //hata verir dizide index var ama içi boş

            //string[] cities =  { "Prag", "İstanbul", "Atina", "İzmir","Roma" };
            //Console.WriteLine(cities[0]); //Prag
            #endregion

            #region DİZİDEKİ TÜM ELEMANLARI LİSTELEME

            //string[] colors = { "sarı", "kırmızı", "yeşil", "mavi","beyaz","turuncu","pembe" };

            //for(int i=0;i<colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] NUMBERS = {4,85,96,75,125,635,488,522,7456,2365,1120 };
            //for(int i = 0; i < NUMBERS.Length; i++)
            //{
            //    if (NUMBERS[i] % 3 == 0)
            //    {
            //        Console.WriteLine(NUMBERS[i]);
            //    }
            //}

            //char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };  
            //for (int i = 0; i < letters.Length; i++)
            //{
            //    if (letters[i] == 'a' || letters[i] == 'e' || letters[i] == 'i' || letters[i] == 'o' || letters[i] == 'u')
            //    {
            //        Console.WriteLine(letters[i]);
            //    }
            //}

            //int[] myarray = { 47, 85, 94, 41, 225, 635, 789, 86, 100 };
            //int maxnumber= myarray[0]; // İlk elemanı başlangıç değeri olarak alıyoruz
            //for (int i = 0; i < myarray.Length; i++)
            //{
            //    if (myarray[i] > maxnumber)
            //    {
            //        maxnumber = myarray[i]; // Eğer mevcut eleman, maxnumber'dan büyükse, maxnumber'ı güncelliyoruz
            //    }
            //}
            //Console.WriteLine("Dizideki en büyük sayı: " + maxnumber); // En büyük sayıyı ekrana yazdırıyoruz







            #endregion

            #region DİZİ METOTLARI

            //string[] person = { "Ali", "Ayşe", "Mehmet", "Fatma", "Cem","Deniz" };
            //Console.WriteLine(person.Length); // Dizinin uzunluğunu ekrana yazdırıyoruz

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i]+","); // Dizinin tüm elemanlarını ekrana yazdırıyoruz
            //}
            //Console.WriteLine(); 
            //Array.Sort(numbers); // Diziyi küçükten büyüğe sıralıyoruz
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i]+","); // Sıralanmış diziyi ekrana yazdırıyoruz
            //}

            // int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers); // Diziyi ters çeviriyoruz
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //        Console.Write(numbers[i]+","); // Ters çevrilmiş diziyi ekrana yazdırıyoruz
            //}

            //string[] customers = { "Ali", "Ayşe", "Mehmet", "Fatma", "Cem", "Deniz" };
            //int index = Array.IndexOf(customers, "Mehmet"); // "Mehmet" isminin dizideki indeksini buluyoruz
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Console.Write("Dizinin en büyük elemanı : "+numbers.Max());
            //Console.Write("Dizinin en küçük elemanı : " + numbers.Min());


            #endregion

            #region KULLANICIDAN DEĞER ALARAK DİZİ OLUŞTURMA 

            //string[]cities = new string[5];

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. şehri giriniz: ", i + 1);
            //    cities[i] = Console.ReadLine(); // Kullanıcıdan şehir ismini alıyoruz
            //}
            //Console.WriteLine(); 
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Girdiğiniz şehirler:");
            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]); // Kullanıcının girdiği şehirleri ekrana yazdırıyoruz
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i=0;i<numbers.Length; i++)
            //{
            //    sum += numbers[i]; // Dizideki tüm elemanları topluyoruz
            //}
            //Console.WriteLine("Dizideki sayıların toplamı: " + sum); // Toplamı ekrana yazdırıyoruz

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
            //Console.WriteLine("*-* Çift sayılar *-*");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0) // Eğer sayı çift ise
            //    {
            //        Console.WriteLine(numbers[i]); // Çift sayıyı ekrana yazdırıyoruz
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("*-* Tek sayılar *-*");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1) // Eğer sayı tek ise
            //    {
            //        Console.WriteLine(numbers[i]); // tek sayıyı ekrana yazdırıyoruz
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
