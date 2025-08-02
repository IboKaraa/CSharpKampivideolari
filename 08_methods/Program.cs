using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region VOİD METOTLAR

            //()
            //geriye değer döndürmeyen metotlar
            //customer--->listele,ekle,sil,güncelle
            //void

            //void customerlist()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Hatice Çınar");
            //}
            //customerlist();

            //void sum()
            //{
            //    int a = 10;
            //    int b = 20;
            //    int result = a + b;
            //    Console.WriteLine("Toplam: " + result);
            //}
            //sum();

            #endregion

            #region GERİYE DEĞER DÖNDÜRMEYEN STRİNG PARAMETRELİ METOTLAR

            //void writemethod(string customername)
            //{
            //    Console.WriteLine("Müşteri Adı: " + customername);
            //}
            //writemethod("İbrahim Kara");  

            //void customercard(string customername, string customersurname)
            //{ 
            //Console.WriteLine($"Müşteri adı-soyadı : {customername} - {customersurname}");
            //}
            //customercard("İbrahim", "Kaya");
            //customercard("Ayşe", "Yıldız");
            //customercard("Hakan", "Öztürk");

            #endregion

            #region GERİYE DEĞER DÖNDÜRMEYEN İNT PARAMETRELİ METOTLAR

            //void sum (int number1, int number2,int number3)
            //{
            //    int result = number1 + number2+number3;
            //    Console.WriteLine("Toplam: " + result);
            //}
            //sum(10, 20, 1);

            #endregion

            #region GERİYE DEĞER DÖNDÜREN METOTLAR

            //string studentcard()
            //{
            //    string studentname = "Ali";
            //    string studentsurname = "Yıldız";
            //    return studentname + " " + studentsurname;  
            //}
            //Console.WriteLine(studentcard());

            #endregion

            #region GERİYE DEĞER DÖNDÜREN STRİNG PARAMETRELİ METOTLAR

            //string countrycard(string countryname, string capital,string flagcolor)
            //{ 
            //    string cardinfo="Ülke: "+countryname+" "+" Başkent: "+capital+" "+" Bayrak Rengi: "+flagcolor;
            //    return cardinfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz: "); 
            //x= Console.ReadLine();
            //Console.Write("Başkent adını giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine(countrycard(x, y, z));
            //Console.WriteLine(countrycard("Türkiye", "Ankara", "Kırmızı-Beyaz"));
            #endregion

            #region GERİYE DEĞER DÖNDÜREN İNT PARAMETRELİ METOTLAR

            //int sum(int number1, int number2)
            //{
            //    int result = number1 + number2 ;
            //    return result;
            //}   
            //Console.WriteLine( sum(10, 21));
            //Console.WriteLine( sum(10, 22));
            //Console.WriteLine( sum(10, 23));
            //Console.WriteLine( sum(10, 24));

            #endregion
             
            #region METOTLU ÖĞRENCİ SINAV ORTALAMASI ÖRNEĞİ

            //string examresult(string studentname, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //   if(result>=50)
            //    {
            //        return studentname+" isimli " +"Öğrenci başarılı oldu"+" ortalama : "+result;
            //    }
            //    else
            //    {
            //        return studentname + " isimli " + "Öğrenci başarısız oldu" + " ortalama : " + result;
            //    }
            //}
            //Console.WriteLine(examresult("ali yıldız",21,45,35));
            //Console.WriteLine(examresult("ibrahim kara",90,70,45));
            //Console.WriteLine(examresult("ali durak",21,80,85));



            #endregion


            Console.Read();
        }
    }
}
