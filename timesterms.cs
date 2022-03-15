using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timesterms
{
    class Program
    {
        static void Main(string[] args)
        {
            // PascalCase - camelCase  -  macarnatasyonu   -genel kültür bilgileri
            timesterms();
            Console.ReadLine();

        }

        private static void timesterms()
        {
            DateTime tday = DateTime.Today;
            Console.WriteLine(tday);
            DateTime nw = DateTime.Now;
            Console.WriteLine(nw);
            DateTime diff = Convert.ToDateTime("2019-01-01");   //string i çevirme  //veritabanında yıl ay gün şeklinde tutulur
            Console.WriteLine(diff);

            DateTime graduation = new DateTime(2024, 10, 06);   //yeni tarih atama
            Console.WriteLine("Yılın " + graduation.DayOfYear + ". günü mezun olacaksınız");
            Console.WriteLine(graduation.DayOfWeek);

            TimeSpan remaining = graduation - DateTime.Today;
            Console.WriteLine(remaining);
            Console.WriteLine(remaining.TotalDays);                

            

            var nww = DateTime.Now;
            var finish = new DateTime(2021, 03, 19, 21, 0, 0);
            //var finish = Convert.ToDateTime("2021-03-19 21:00:00");
            TimeSpan ramain = finish - nww;
            Console.WriteLine("Çıkışa " + ramain.Hours +"saat"+ramain.Minutes+"dakika kaldı" );
            Console.WriteLine(ramain.TotalMinutes);
            //Console.WriteLine(ramain.Minutes+ramain.Hours*60);



            DateTime tdy = DateTime.Today;
            DateTime afteramonth = tdy.AddMonths(1);
            DateTime beforeamonth = tdy.AddMonths(-1);
            DateTime afterday = tdy.AddDays(1);
            DateTime beforeday = tdy.AddDays(-1);

            Console.WriteLine("bir ay sonraki tarih:" + afteramonth);
            Console.WriteLine("bir öncesi:" + beforeday);


            DateTime nnw = DateTime.Now;
            Console.WriteLine(nnw);
            Console.WriteLine(nnw.ToLongDateString());
            Console.WriteLine(nnw.ToShortDateString());
            Console.WriteLine(nnw.ToLongTimeString());
            Console.WriteLine(nnw.ToShortTimeString());
            // DateTime now ı string e çevirmek:
            Console.WriteLine(nww.ToString("MM/dd/yyyy MMMM dd - ceynep hh:mm HH:mm"));



            DateTime simdi = DateTime.Now;
            DateTime after10 = simdi.AddDays(10);
            Console.WriteLine(after10.ToString("MM.dd.yyyy"));            //    ToString parantezini boş bırakırsak saat dakika saniyeyi de yazardı

            Console.WriteLine("Doğum tarihinizi giriniz:");
            DateTime birth = Convert.ToDateTime(Console.ReadLine());
            int life = (int)(DateTime.Today - birth).TotalDays;
            Console.WriteLine(birth.DayOfWeek);
            Console.WriteLine(life);
            int year = life / 365;
            Console.WriteLine(year);

            

            Console.WriteLine("Sınav notunuzu giriniz:");
            
            try
            {
                int grade = Convert.ToInt32(Console.ReadLine());
                if (grade >= 0 && grade <= 50)
                {
                    Console.WriteLine("Daha çok çalışmalısınız");
                }
                else if (grade > 59 && grade <= 69)
                {
                    Console.WriteLine("Daha iyi olabilir");
                }
                else if (grade > 70 && grade <= 100)
                {
                    Console.WriteLine("Başarılı");
                }
            }
            catch
            {
                Console.WriteLine("Sayı girmediniz..İşleme devam edilemiyor");
            }

            

            //hata fırlatma

            Console.WriteLine("1 ile 3 arasında bir sayı giriniz:");
            string chhose = Console.ReadLine();
            switch(chhose)
            {
                case "1":
                    {
                        throw new Exception("Beğenmedim");
                        break;
                    }
                case "2":
                    {
                        throw new Exception("Başka bir sayı");
                        break;
                    }
                case "3":
                    {
                        throw new Exception("Böyle sayı mı olur");
                        break;
                    }
            }                                                                









            try
            {
                Console.WriteLine("500 gram kuruyemişi kaç kişiye bölüştüreceksiniz?");
                int persons = Convert.ToInt32(Console.ReadLine());
               //if (persons == 0)
                {
                    throw new DivideByZeroException();
                }
                double amount = 500.0 / persons;
                Console.WriteLine("Kişi başı " + amount + " gram kadar kuru yemiş düşer");
            }
            catch(DivideByZeroException   sıfırhatası)
            {
                Console.WriteLine("0 a bölünme hatası");
            }
            catch(FormatException formathata)
            {
                Console.WriteLine("yanlızca sayı giriniz");
            }
            catch(Exception exc)
            {
                Console.WriteLine("another axception");
            }     */



            
            try
            {
            Console.WriteLine("bir sayı giriniz:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 3)
            {
              throw new Exception("Böyle sayı mı olur");
            }
            }
            catch(Exception hata)     //hatanın bilgilerine ulaşmak için exception kullanacaksınız
            {
                File.AppendAllText("log.txt", Environment.UserName);
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
                File.AppendAllText("log.txt", "/r/n");
                File.AppendAllText("log.txt", hata.Message);
                File.AppendAllText("log.txt", "@");
                File.AppendAllText("log.txt", hata.StackTrace);
                File.AppendAllText("log.txt", Environment.NewLine + "************");
            }

            //diziler (StringS):birbiriyle ilişkili olan verilerin topluluğudur. renkler=yeşil,mav,kırmısı  teksaylar=1.3.5.7.
            //index=sıra ilk elmanın indeksi 0 dır, diziler bellekte ram e kaydedilir


            String[] peoples = { "ali", "can", "tuba", "cansu" };
            int[] zeyn = { 1, 3, 5, 7, 9 };
            char[] character = { 'a', 'b', 'c', 'd', 'e' };
            Console.WriteLine(character[4]);
            Console.WriteLine(zeyn[3]);
            Console.WriteLine(peoples[3]);
            Console.ReadLine();           

            
            string tarih = "29.11.2018";
            string[] parcalar = tarih.Split('.');
            Console.WriteLine(parcalar[2]);
            int index = parcalar.Length - 3;
            Console.WriteLine(parcalar[index]);      

            
           string[] dosyalar = Directory.GetFiles(@"C:\Windows");
           Console.WriteLine("C sürücüsünde " + dosyalar.Length + " dosya var");
           Console.Write("ilk dosya:");
           Console.WriteLine(dosyalar[0]);
           string[] dosyaad = dosyalar[0].Split('\\');
           Console.WriteLine(dosyaad[dosyaad.Length - 1]);                  



            
            string[] questions = { "33 plakalı ilimiz?", "Muzu meşhur olan ilçe?", "Mersin hangi bölgede?" };
            string[] answers = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(questions[i]);
                answers[i] = Console.ReadLine();
            }
            int t = 0;
            int f = 0; 
            if(answers[0]=="mersin")
            {
                t++;
            }
            else
            {
                f++;
            }
            if(answers[1]=="anamur")
            {
                t++;
            }
            else
            {
                f++;
            }
            if (answers[2] == "akdeniz")
            {
                t++;
            }
            else
            {
                f++;
            }
            Console.WriteLine("number of correct answer:"+t);
            Console.WriteLine("number of correct answer::"+f);          


            Console.WriteLine("Yömer Bağ");


        }
    }
}
