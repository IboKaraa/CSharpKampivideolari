using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Makingdecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If else

            //Console.Write("Lütfen Şifre Giriniz: ");
            //string password = Console.ReadLine();
            //if (password == "1234")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz : ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz : ");
            //country = Console.ReadLine();

            //if (capital == "Ankara" && country == "Türkiye")
            //{
            //    Console.WriteLine("Veriler Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Veriler Yanlış");
            //}

            //int number;
            //Console.Write("Lütfen bir sayı giriniz: ");
            //number=int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //Console.WriteLine("Doğru sayı");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış sayı");
            //}

            //int exam1,exam2,exam3, average;
            //string result="Hata ! ";

            //Console.Write("1. Sınav Notunu Giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sınav Notunu Giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3. Sınav Notunu Giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınav Ortalaması: " + average);

            //if(average>0&& average <= 50)
            //{
            //       result = "Sonuç Kötü";
            //}
            //if (average > 50 && average <=70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 && average <= 85)
            //{
            //   result = "Sonuç İyi";
            //}
            //if(average>85)
            //{
            //    result="Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen bir şehir giriniz: ");
            //city = Console.ReadLine();

            //if(city=="adana"||city=="bursa"||city=="ankara"||city=="trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            //Console.Write("Kullanıcıadını giriniz: "); 
            //string username = Console.ReadLine();

            //if(username!= "admin")
            //{
            //    Console.WriteLine("Kullanıcı Adı Hatalı");
            //}
            //else
            //{
            //    Console.WriteLine("HOŞGELDİNİZ");
            //}

            #endregion

            #region MOD İŞLEMLERİ

            //int number = 26;
            //int result = number % 5;
            //Console.Write(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            // Console.Write("Lütfen 2. sayıyı giriniz: ");
            // int number2 = int.Parse(Console.ReadLine());

            // int result = number1 % number2;

            // Console.Write("Birinci sayının ikinci sayıya bölümünden kalan: "+result);

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}
            #endregion

            #region CHAR DEĞİKENLER VE KARAR YAPILARI
            //Console.Write("Takım sembolünü girin : ");
            //char teamSymbol = char.Parse(Console.ReadLine());  

            //if(teamSymbol =='g'|| teamSymbol == 'G')
            //{
            //    Console.WriteLine("Takım Galatasaray");
            //}
            //else if(teamSymbol == 'f' || teamSymbol == 'F')
            //{
            //    Console.WriteLine("Takım Fenerbahçe");
            //}
            //else if(teamSymbol == 'b' || teamSymbol == 'B')
            //{
            //    Console.WriteLine("Takım Beşiktaş");
            //}
            //else if (teamSymbol == 't' || teamSymbol == 'T')
            //{
            //    Console.WriteLine("Takım Trabzonspor");
            //}
            //else
            //{
            //    Console.WriteLine("Takım Bulunamadı");
            //}
            #endregion

            #region ÖRNEK UYGULAMA //EKLEYECEĞİM ŞEYLER VAR

            //Console.WriteLine("****** C# EĞİTİM KAMPI RESTORANT ******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("1-Ana yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine();

            //string menuıtem;

            //Console.Write("Detayını görmek istediğiniz menü numarasını seçin : ");
            //menuıtem = Console.ReadLine();

            //if (menuıtem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri soslu tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye pilav");
            //    Console.WriteLine("4-Fırında somon");
            //    Console.WriteLine("5-Patlıcan musakka");
            //    Console.WriteLine("------------Ana yemekler------------");

            //}

            //if (menuıtem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek çorbası");
            //    Console.WriteLine("2-Ezogelin çorbası");
            //    Console.WriteLine("------------Çorbalar------------");

            //}

            //if (menuıtem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu pizza");
            //    Console.WriteLine("------------Pizzalar------------");

            //}

            //if (menuıtem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("------------İçecekler------------");

            //}

            //if (menuıtem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("------------Tatlılar------------");
            //}



            #endregion

            #region Switch Case

            //Console.Write("Lütfen bir ay numarası giriniz : ");
            //int monthnumber = int.Parse(Console.ReadLine());

            //switch(monthnumber)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz ay numarası.");
            //        break;
            //}


            #endregion

            #region SWİTCH CASE HESAP MAKİNESİ

           //Console.WriteLine("****** C# EĞİTİM KAMPI HESAP MAKİNESİ ******");
           // int number1, number2,result;
           // char symbol;

           // Console.Write("Lütfen 1. sayıyı giriniz: ");
           // number1 = int.Parse(Console.ReadLine());

           // Console.Write("Lütfen 2. sayıyı giriniz: ");
           // number2 = int.Parse(Console.ReadLine());

           // Console.Write("Lütfen işlem sembolünü giriniz (+, -, *, /): ");
           // symbol = char.Parse(Console.ReadLine());

           // switch(symbol)
           // {
           //     case '+':
           //         result = number1 + number2;
           //         Console.WriteLine("Sonuç: " + result);
           //         break;
           //     case '-':
           //         result = number1 - number2;
           //         Console.WriteLine("Sonuç: " + result);
           //         break;
           //     case '*':
           //         result = number1 * number2;
           //         Console.WriteLine("Sonuç: " + result);
           //         break;
           //     case '/':
           //         if (number2 != 0)
           //         {
           //             result = number1 / number2;
           //             Console.WriteLine("Sonuç: " + result);
           //         }
           //         else
           //         {
           //             Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz.");
           //         }
           //         break;
           //     default:
           //         Console.WriteLine("Geçersiz işlem sembolü.");
           //         break;
           // }

            #endregion

            Console.Read();
        }
    }
}
