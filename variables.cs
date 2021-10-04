using System;

namespace console_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int deger = 20;
            int deger2 = 298014;

            char karakter = 'A';
            char [] karakterler = { 'D', 'e', 'n', 'y', 'r'};
            
            string str1 = "Bu bir metindir.";
            string str2 = "Cift tırnak arasına yazılmalıdır.";
            
            DateTime date1 = DateTime.Now; 
            string tarih1=DateTime.Now.ToString("dd/mm/yyyy");


            Console.WriteLine(tarih1);
            Console.WriteLine(date1);
            Console.WriteLine(deger + deger2);
            Console.WriteLine(str1 + " " + str2);
            Console.WriteLine(karakter);
            Console.WriteLine(karakterler);
            Console.ReadKey();
        }
    }
}
