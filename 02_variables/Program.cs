using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DOUBLE DEĞİŞKENLER
            //double number;
            //number=4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***-Fiyat Listesi-***");
            //Console.WriteLine();

            //double appleprice, orangeprice, strawberyprice, potatoprice, tomatoprice;

            //appleprice = 14.85;
            //orangeprice = 20.95;
            //strawberyprice = 45;
            //potatoprice = 9.74;
            //tomatoprice = 6.88;

            //Console.WriteLine("-----Elma birim fiyatı : " + appleprice+"TL");
            //Console.WriteLine("-----Portakal birim fiyatı : " + orangeprice+"TL");
            //Console.WriteLine("-----Çilek birim fiyatı : " + strawberyprice + "TL");
            //Console.WriteLine("-----Patates birim fiyatı : " + potatoprice + "TL");
            //Console.WriteLine("-----Domates birim fiyatı : " + tomatoprice + "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double applegram, orangegram, strawberygram, potatogram, tomatogram;

            //applegram = 1.245;
            //orangegram = 2.650;
            //strawberygram = 0.750;
            //potatogram = 4.859;
            //tomatogram = 3.745;

            //double appletotalprice = appleprice * applegram;
            //Console.WriteLine("Alınan ürün : Elma - Birim fiyatı : "+appleprice+"-Gramaj : "+applegram+" - Elmanın toplam tutarı : " + appletotalprice);

            //double orangetotalprice = orangeprice * orangegram;
            //Console.WriteLine("Alınan ürün : Portakal - Birim fiyatı : " + orangeprice + "-Gramaj : " + orangegram + " - Portakalın toplam tutarı : " + orangetotalprice);

            //double strawberytotalprice = strawberyprice * strawberygram;
            //Console.WriteLine("Alınan ürün : Çilek - Birim fiyatı : " + strawberyprice + "-Gramaj : " + strawberygram + " - Çileğin toplam tutarı : " + strawberytotalprice);

            //double potatototalprice = potatoprice * potatogram;
            //Console.WriteLine("Alınan ürün : PAtates - Birim fiyatı : " + potatoprice + "-Gramaj : " + potatogram + " - Patatesin toplam tutarı : " + potatototalprice);

            //double tomatototalprice = tomatoprice * tomatogram;
            //Console.WriteLine("Alınan ürün : Elma - Birim fiyatı : " + tomatoprice + "-Gramaj : " + tomatogram + " - Domatesin toplam tutarı : " + tomatototalprice);

            //Console.WriteLine();
            //Console.WriteLine();

            //double shpingtotalprice = appletotalprice + orangetotalprice + strawberytotalprice + tomatototalprice + potatototalprice;
            //Console.WriteLine("Toplam alışveriş tutarı : " + shpingtotalprice);

            #endregion

            #region CHAR DEĞİŞKENLER 

            //karakter değişkenlerdir.

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region KLAVYEDEN VERİ GİRİŞLERİ STRİNG DEĞERLER

            //Console.WriteLine("*****-CSharp Hava Yolları Yolcu Bilgisi-*****");
            //Console.WriteLine();

            //string passengername, passengersurname, passengerdistrict, passengercity, passengerage,passengerıdentitynumber;

            //Console.Write("Yolcu adı : ");
            //passengername =Console.ReadLine();

            //Console.Write("Yolcu soyadı : ");
            //passengersurname =Console.ReadLine();

            //Console.Write("İl bilgisi : ");
            //passengercity =Console.ReadLine();

            //Console.Write("İlçe bilgisi : ");
            //passengerdistrict =Console.ReadLine();

            //Console.Write("Yaş bilgisi : ");
            //passengerage =Console.ReadLine();

            //Console.Write("TC kimlik NO bilgisi : ");
            //passengerıdentitynumber =Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("---------------------------------------------------------------");

            //Console.WriteLine();

            //Console.WriteLine("---*****YOLCU KARTI*****---");

            //Console.WriteLine(" Yolcu : " + passengername + " " + passengersurname);
            //Console.WriteLine(" İl / İlçe : "+passengercity+"/"+passengerdistrict);
            //Console.WriteLine(" Yaş - TC : " + passengerage+" - "+passengerıdentitynumber);

            #endregion

            #region KLAVYEDEN TAM SAYI GİRİŞLERİ VE DÖNÜŞÜMLER

            //int shoesprice, computerprice, chairprice, tvprice;

            //shoesprice = 1000;
            //computerprice = 20000;
            //chairprice = 5000;
            //tvprice = 12000;

            //int shoescount, computercount, chaircount, tvcount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını girin : ");
            //shoescount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını girin : ");
            //computercount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını girin : ");
            //chaircount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını girin : ");
            //tvcount = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------------");

            //int totalprice=shoescount*shoesprice+computercount*computerprice+chaircount*chairprice+tvcount*tvprice;
            //Console.WriteLine("TOPLAM TUTAR : " + totalprice);

            #endregion

            #region KLAVYEDEN ONDALIKLI SAYI İŞLEMLERİ

            //double exam1,exam2,exam3,result;

            //Console.Write("Lütfen 1.sınav notunu girin : ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sınav notunu girin : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.sınav notunu girin : ");
            //exam3 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine();
            //result = (exam1 + exam2 + exam3) / 3;

            //Console.Write("3 sınavın ortalaması : "+result);

            #endregion

            #region KLAVYEDEN KARAKTER GİRİŞLERİ

            //char gender;

            //Console.Write("Lütfen cinsiyet seçin (E/K) : ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine();

            //Console.WriteLine(gender);

            #endregion

            Console.Read();
        }
    }
}
