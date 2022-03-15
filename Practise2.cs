using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)

        {
           /* Ornek3();
            Console.ReadLine();
            Örnek();
            Console.ReadLine();
            Ornek2();
            Console.ReadLine();
            Ornek5();
            Console.ReadLine();
            Veya();
            Console.ReadLine();
            Vee();
            Console.ReadLine();
            VeeBoo();
            Console.ReadLine();   */
            Vve();
            Console.ReadLine();
            veör();
            Console.ReadLine();
        }

        private static void veör()
        {
            Console.WriteLine("Kaç yaşındasınız?");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age>0&&age<=20)
            {
                Console.WriteLine("Teşekkürler");
            }
            else if (age>20&&age<=50)
            {
                Console.WriteLine("Çalışıyor musunuz?");
                string answer = Console.ReadLine();
                if(answer=="e"||answer=="h")
                {
                    Console.WriteLine("TŞK");
                }
            }
            else
            {
                Console.WriteLine("Teşekkürler..");
            }



            /*Console.WriteLine("Kaç yaşındasınız?");
            int answer = Convert.ToInt32(Console.ReadLine());
            if(answer<20&&answer>50)
            {
                Console.WriteLine("Teşekkürler");
            }
            else
            {
                Console.WriteLine("Çalışıyor musunuz?");
                Console.ReadLine();
                Console.WriteLine("TŞK");
            }  */














        }

        private static void Vve()
        {
            Console.WriteLine("Ayın kaçında doğdunuz?");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hangi ay doğdunuz?");
            string a = Console.ReadLine();
            if(g>=21 && a=="mayıs"||g<=21&&a=="haziran")
            {
                Console.WriteLine("Maalesef ikizler burcusunuz");
            }
            else
            {
                Console.WriteLine("Yaşasın ikizler burcu değilsiniz");
            }
        }

        private static void VeeBoo()
        {
            Console.WriteLine("Şu an çalışıyor musunuz?");
            bool answer = Console.ReadLine() == "e";
            Console.WriteLine("Sayısal bölüm mezunu musunuz?");
            bool ans = Console.ReadLine() == "h";
            if(answer&&ans)
            {
                Console.WriteLine("MT progrsmına katılabilirsiniz");
            }
            else
            {
                Console.WriteLine("Kriterler uygun değil");
            }
           
        }

        private static void Vee()
        {
            Console.WriteLine("Şu an çalışıyor musunuz?");
            string answer = Console.ReadLine();
            Console.WriteLine("Sayısal bölüm mezunu musunuz?");
            string answ = Console.ReadLine();
            if(answer=="h"&&answ=="e")
            {
                Console.WriteLine("MT programına katılabilirsiniz");
            }
            else
            {
                Console.WriteLine("Kriterler uygun değil");
            }
        }

        private static void Veya()
        {
            Console.WriteLine("Kullanıcı adınızı giriniz:");
            string user_name = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz:");
            var password = Console.ReadLine();
            if(user_name=="Ceynep"&& password=="xx45")
            {
                Console.WriteLine("Başarılı giriş");
            }
            else
            {
                Console.WriteLine("Başarısız giriş");
            }
        }

        private static void Ornek5()
        {
            int tru = 0;
            int fls = 0;
            Console.WriteLine("Türkiyenin başkenti neresidir");
            string cvp = Console.ReadLine();
            if (cvp == "ankara" || cvp == "ANKARA")
            {
                tru++;
            }
            else
            {
                fls++;
            }
            Console.WriteLine("Almanya hangi kıtadadır?");
            string cv = Console.ReadLine();
            if (cv == "avrupa")
            {
                tru++;
            }
            else
            {
                fls++;
            }
            Console.WriteLine("Renkleri siyah beyaz olan takım hangisidr ?");
            string cvb = Console.ReadLine();
            if(cvb=="BJK"||cvb=="bjk")
            {
                tru++;
            }
            else
            {
                fls++;
            }
            Console.WriteLine("Doğru sayısı :" + tru);
            Console.WriteLine("Yanlış sayısı :" + fls);

        }

        private static void Ornek2()
        {
            Console.WriteLine("Kare mi daire mi?");
            string choose = Console.ReadLine();                           //Console.ReadLine() zaten string değeri olduğu için convert etmeye gerek yok
            if (choose == "kare")
            {
                Console.WriteLine("Bir kenar uzunluğu giriniz");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a * a);
            }
            else if (choose == "daire")                                       // if else if else de "" kullanılmalıdır yazılan tanımlı değil stringdir
            {
                Console.WriteLine("Bir Yarı çap uzunluğu giriniz");
                int r = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.PI * Math.Pow(r, 2));                  //Math.Pow(a,b) a üssü b değerini sağlar
            }
            else
            {
                Console.WriteLine("Geçerli bir karakter girmediniz");
            }
        }




        private static void Ornek3()
        {
            Console.WriteLine("Yaşınızı giriniz");
            int yas = Convert.ToInt32(Console.ReadLine());
            if (yas >= 18)
            {
                Console.WriteLine("Ehliyet alabilirsiniz..");
            }
            else
            {
                Console.WriteLine("Ehliyet alamazsınız..");
            }
        }

        private static void Örnek()
        {
            if (true)
            {
                Console.WriteLine("Bu kod her zaman çalışır..");
            }
            if (DateTime.Today.Day == 13)
            {
                Console.WriteLine("Bu gün ayın 13'ü indirim günü");
            }
            else if (DateTime.Today.Day == 12)
            {
                Console.WriteLine("Yarın indirim günü");
            }
            else
            {
                Console.WriteLine("İndirim için ayın 13'ünü bekleyin");
            }
        }
    }
}
