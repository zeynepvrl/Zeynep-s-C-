using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return
{
    class Program
    {
        static void Main(string[] args)
        {
              int number1 = askNumber();
              int number2 = askNumber();
              Console.WriteLine((number1 + number2) / 2);
              Console.ReadLine();           

            
            Console.WriteLine("Doğum tarihiniz::");
            int dogum = Convert.ToInt32(Console.ReadLine());
            int yas = DateTime.Today.Year - dogum;
            Console.WriteLine(yas);
            Console.WriteLine(yas >= 18 ? "adult" : "kid");            
            bool trfl = yas >= 18;
            Console.ReadLine();                             



            
            // int birthYear = askBirthYear();            
            //int age = FndeAge();
            //Console.WriteLine("Your age is:" + age);
            bool resit = resitMi();
            //Console.WriteLine(resit);            
            int a = adding();
            paperColor();
            Console.ReadLine();         
        }

        private static void paperColor()
        {
            if (adding() %2==0 && resitMi() )
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
            }
        }

        private static int adding()
        {
            int yas = FndeAge();
            int x = yas / 10;
            int y = yas % 10;
            return x + y;
            //Console.WriteLine("Yaşın rakamlar toplamı: "+(x + y));
        }

        private static bool resitMi()
        {
            return FndeAge() >= 18;         
        }

        private static int FndeAge()
        {
            return DateTime.Today.Year - askBirthYear();
        }

        private static int askBirthYear()
        {
            Console.Write("Your birth year:");
            return Convert.ToInt32(Console.ReadLine());                        
        }

        private static int askNumber()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

    }



}
