using System;

namespace console_programming
{
    class Program
    {
        static void Main(string[] args)
        {

            //Tip Dönüşümleri

            //Implicit Conversion (Bilinçsiz Dönüşüm)

            Console.WriteLine("Implicit Conversions");
            byte a = 5;
            sbyte b = 10;
            short c = 30;

            int d = a + b + c;
            Console.WriteLine(d);


            long h = d;
            Console.WriteLine(h);

            float i = h;
            Console.WriteLine(i);

            string kelime = "Merhaba";
            char karakter = 'X';
            object s = kelime + karakter + d;

            Console.WriteLine(s);


            //Explicit Conversion (Bilinçli Dönüşüm)

            Console.WriteLine("Explicit Conversions");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine(y);

            float w = 10.2f;
            byte v = (byte)w;
            Console.WriteLine(v);





            //ToString Methodu

            Console.WriteLine("ToString Methodu");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine(yy);


            //System Convert

            Console.WriteLine("System Convert");













        }
    }
}

