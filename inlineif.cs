using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlineİf
{
    class Program
    {
        static void Main(string[] args)
        {
            İNline();
            Console.ReadLine();
        }

        private static void İNline()
        {   /*
            string sehir = Console.ReadLine();
            string shr = sehir == "İstanbul" ? "34" : sehir == "istanbul" ? "34" : "0";
            Console.WriteLine(shr);
            */
            //  int sayi = 9;
            //  bool katıMi = 9 % 3 == 0 ? true : false;

            /*
            Console.WriteLine("İlk sayıyı giriniz");
            int sayı1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz");
            int sayı2 = Convert.ToInt32(Console.ReadLine());
            string karşlştm = sayı1 > sayı2 ? "ilk sayı ikincisinde büyük" : sayı1 == sayı2 ? "iki sayı birbirine eşit" : "İkinci sayı birincisinden büyük";
            Console.WriteLine(karşlştm);                                      // tek eşittir koyarsan bool değeri saymış olursun hata verir.
            */



            /*
            Console.WriteLine("Vize notunuzu giriniz");
            double vize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final notunuzu giriniz");
            double final = Convert.ToDouble(Console.ReadLine());
            vize = vize * 0.4;
            final = final * 0.6;
            if(vize==0)
            {
                Console.WriteLine("Kaldınız");
            }
            else if((vize+final)>=50)
            {
                Console.WriteLine("Geçtiniz");
            }
            else
            {
                Console.WriteLine("Kaldınız");
            }*/


            /*
            Console.WriteLine("Bir sayı giriniz");
            int sayı = Convert.ToInt32(Console.ReadLine());
            if(sayı%2==0)
            {
                Console.WriteLine(sayı * sayı * sayı);
            }
            else
            {
                Console.WriteLine(sayı*sayı);
            }*/

            /*
            ConsoleColor x = Console.BackgroundColor;
            switch(x)
            {
                case ConsoleColor.Black:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case ConsoleColor.Yellow:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case ConsoleColor.Cyan:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break; 
            }   */
            /*
            Console.WriteLine("Bir dil giriniz (tr, en, de)");
            string language = Console.ReadLine();
            switch(language)
            {
                case "tr":
                    Console.WriteLine("Merhaba");
                    break;
                case "en":
                    Console.WriteLine("Hello");
                    break;
                case "de":
                    Console.WriteLine("Hallo");
                    break;
                default:
                    Console.WriteLine("Tanımlı bir dil girmediniz");
                    break;
            } */


            Console.WriteLine("VÜCUT KİTLE İNDEKSİ HESAPLAMA");
            Console.Write("Cinsiyetinizi giriniz:");
            string gender = Console.ReadLine();
            Console.Write("Kilonuzu giriniz:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Boy uzunluğunuzu giriniz:");
            double length = Convert.ToDouble(Console.ReadLine());
            double meter = length / 100;
            double index = weight / (meter * meter);
            switch (gender)
            {
                case "woman":
                    Console.WriteLine(index < 19 ? "low" : index < 24 ? "ideal" : "high");
                    break;
                case "man":
                    Console.WriteLine(index < 20 ? "low" : index < 25 ? "ideal" : "high");
                    break;
                default:
                    Console.WriteLine("You did not enter a defined gender ");
                    break;
                    Console.WriteLine("Your index is:" + index);


                    /*
                    Console.WriteLine("VÜCUT KİTLE İNDEKSİ HESAPLAMA");
                    Console.Write("Cinsiyetinizi giriniz:");
                    string gender = Console.ReadLine();
                    Console.Write("Kilonuzu giriniz:");
                    double weight = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Boy uzunluğunuzu giriniz:");
                    double length = Convert.ToDouble(Console.ReadLine());
                    double meter = length / 100;
                    double index = weight / (meter * meter);
                    if (gender=="woman" && index<19)
                    {
                        Console.WriteLine("low");
                    }
                    if (gender=="woman"&&index>24)
                    {
                        Console.WriteLine("high");
                    }
                    if (gender=="man"&& index<20)
                    {
                        Console.WriteLine("low");
                    }
                    if (gender=="man"&&index>25)
                    {
                        Console.WriteLine("high");
                    }
                    else
                    {
                        Console.WriteLine("You have got a standart body index");
                    }
                    Console.WriteLine("Your index is:" + index);                 */
            }
        }
    }
}
