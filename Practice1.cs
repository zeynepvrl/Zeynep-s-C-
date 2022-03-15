using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLesson
{
    class Practice

    {
        static void Main(string[] args)
        {
            
            int x = 6;
            Console.Write("Sayı değeri :");
            Console.WriteLine(x);
            Console.ReadLine();
            
           
            int sayı = 5;
            Console.WriteLine("Sayı :" + sayı);
            Console.WriteLine("Sayının Karesi :" + sayı * sayı);
            Console.WriteLine("Sayının Yarısı :" + sayı / 2);                     // int yerine float olsaydı 2.5 yazardı, şimdi 2 yazıyor //
            Console.WriteLine("Sayının 2 ile bölümünden kalan :" + sayı % 2);
            Console.ReadLine();
            
            
            Console.WriteLine("Merhaba !");
            Console.Write("Bu gün nasılsınn ?");
            var hal = Console.ReadLine();              // var tanımlama; var deneme = 98f , var = para = 80m
            Console.WriteLine();                                               
            Console.WriteLine("Ben de " + hal);
            Console.ReadLine();
            Console.Beep();
            
            
            string can = "78";                     //string tanımlama; string x = "Can";
            int cevrim = Convert.ToInt32(can);
            Console.WriteLine(cevrim);
            Console.ReadLine();
            
            
            var can = Console.ReadLine();
            int boz = Convert.ToInt32(can);
            Console.WriteLine(boz);
            Console.ReadLine();
            
            
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Title = "CEYNEP";
            Console.CursorSize = 90;
            Console.CursorLeft = 80;
            Console.CursorTop = 60;
            Console.WriteLine("DENEME");
            Console.ReadLine();
            
            
            Console.WriteLine("Kaç yaşındasınız ?");
            string yaş = Console.ReadLine();
            int yaşı = Convert.ToInt32(yaş);
            yaşı = yaşı - 5;
            Console.WriteLine();
            Console.WriteLine(yaşı + " yaşında gösteriyorsunuz");
            Console.ReadLine();
            
            
            Console.WriteLine("Kaç lira alışveriş yaptınız ?");
            var can = Console.ReadLine();
            int yeni = Convert.ToInt32(can);
            yeni = yeni / 10;
            Console.WriteLine(yeni + "TL indirim kazandınız!");
            Console.ReadLine();
            

            // Environment sınıfının TickCount elemenını nir değişkene atayın
            // ms cinsinden olan bu değeri dakika olarak ekrana yazdırın
            // not : küsüratlı olabilsin (var kullanın)
            
            var tms = Environment.TickCount;
            var ts = tms / 1000;                                       // bütün değişkenler object den çıkmadır, object ile her şeyi tanımlayabilirsin           
            var dk = ts / 60;                                          // var ise bilinçsiz değişken tanımlamaları durumunda kullanılır, derleyici tanımını kendi belirler, çoklu tanımlama olmaz çünkü bilinçsiz
            var s = dk / 60;             
            Console.WriteLine(s + "saat eder");
            Console.ReadLine();
          
            
            int gün = DateTime.Today.Day+1;
            int ay = DateTime.Today.Month;
            int yıl = DateTime.Today.Year;
            Console.WriteLine("Yarının Tarihi :" + gün + "." + ay + "." + yıl);
            Console.ReadLine();
            
            
            Console.WriteLine("Lütfen 1 ile 5 arasında bir değer giriniz :");
            int girilen = Convert.ToInt32(Console.ReadLine());
            double zeyn = Math.PI;
            int küsürsüz = Convert.ToInt32(zeyn);
            Console.WriteLine(küsürsüz * girilen);
            Console.ReadLine();
            

            // bool boolean : True vaya False değerini alır.
            // bool onerme1 = 5 > 3;
            // bool indirimGeçerliMi = false;
            // bool eşitMi = 8 == 8; // döndürdüğü, verdiği değer true değeri olacak
            // bool farklıMı = 7 != 6; // true değerini döndürücek verecek
            
            Console.WriteLine("Kaç yaşındasınız ?");
            int zeyn = Convert.ToInt32(Console.ReadLine());
            bool reşit = zeyn >= 18;
            Console.WriteLine(reşit);
            Console.ReadLine();
            
            
            bool atamaNasılOlurVarMi = Directory.Exists("test");       //Directory sınıfının Exist metoduna "test parametresini gönderdik "
            Console.ReadLine();
            



            // var da değişkenin türünü derleyici belirler değişkenin değerini sonradan değiştiremezsin, çoklu değişken tanımlayamazsın aynı anda, object de atama yapıldığı zaman unboxing yapmamız lazım örn:  
            //object b = 10; //Boxing
            //Üstte b adında object tipli bir değişken oluşturduk.Bu oluşturduğumuz değişkeni Unboxing yapmak için aşağıdaki işlemi yapmamız gerekiyor.
            //int a = (int)b; //Unboxing
            // float ve decimalle ondalık sayı tanımlarken sayıdan sonra harfl


            //var a=5;
            //var b = "metin";
            //Bu tür değişken tanımlamalarına bilinçsiz değişken tanımlaması denir. Bilinçsiz değişken tanımlamalarında çoklu değişken tanımlaması yapamayız.Ayrıca değişkene tanımlanır tanımlanmaz değer vermeliyiz. Aslına bakarsanız var ile yapılan değişken tanımlamalarında da değişkenlerin türleri vardır ve bu türler daha sonra değiştirilemez.Tek fark derleyicinin değişkenin tipini değerden anlamasıdır.Yani işlevsel olarak aşağıdaki iki değişken tanımlaması arasında fark yoktur.

            //int a = 5;
            //var a = 5;


















        }

        private static void Örnek()
        {
            throw new NotImplementedException();
        }
    }
}
