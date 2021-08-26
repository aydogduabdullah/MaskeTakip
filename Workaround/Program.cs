using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();


           

            SelamVer(isim:"ABdullah");
            SelamVer(isim:"Emre");
            SelamVer();
            
            int sonuc = Topla(6,58);


            //diziler arrays


            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            string[] ogrenciler = new string[ogrenciler.Length];
            ogrenciler[0] = "engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
 
            Console.ReadLine();
        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("merhaba " + isim );
        }


        static int Topla(int sayi1 =5 , int sayi2 =10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam :" + sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            string doNotRepeatUrself = "Merhaba";


            string mesaj = "merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi = false;


            string ad = "abdullah";
            string soyad = "aydogdu";
            int dogumYili = 1985;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.18);

            Console.WriteLine(tutar * 1.18);
        }

        public class Vatandas
        {
            public string Ad { get; set; }
        
            public string Soyad { get; set; }

            public int DogumYili { get; set; }

            public long TcNo { get; set; }
        }

    }
}
