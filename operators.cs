using System;

namespace console_programming
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 15;
            int b = 3;

            //İlişkisel Operatörler

            Console.WriteLine("****İlişkisel Operatörler****");
            bool sonuc =a<b;
            Console.WriteLine(sonuc);

            sonuc = a > b;
            Console.WriteLine(sonuc);

            sonuc = a == b;
            Console.WriteLine(sonuc);

            sonuc = a >= b;
            Console.WriteLine(sonuc);
           


            //Aritmetik Operatörler

            Console.WriteLine("***Aritmetik Operatörler***");

            int x = 10;
            int y = 3;

            int sonuc1 = x + y;
            Console.WriteLine(sonuc1);

            sonuc1 = x - y;
            Console.WriteLine(sonuc1);

            sonuc1 = x * y;
            Console.WriteLine(sonuc1);

            sonuc1 = x / y;
            Console.WriteLine(sonuc1);





            



        }
    }
}
