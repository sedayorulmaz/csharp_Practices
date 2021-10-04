using System;

namespace console_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 2, 55, 66, 17, 14, 6, 25, 9 };
            Console.WriteLine("****SIRASIZ DİZİ ****");
            foreach (var number in Array1)
            {
                Console.WriteLine(number);
            }


            //ArrayMethodları ile sıralama yapabiliriz
            //Sorting işlemi

            Console.WriteLine("****SIRALI DİZİ****");
            Array.Sort(Array1);
            foreach (var number in Array1)
            {
                Console.WriteLine(number);
            }


            //Clear İşlemi
            //Index belirterek dizi içindeki elemanları temizlemeye yarar, temizlenen elemanar varsayılan değerlerine döner
            Console.WriteLine("****ARRAY CLEAR****");
            Array.Clear(Array1, 3, 2);

            foreach (var number in Array1)
            {
                Console.WriteLine(number);
            }


            //Reverse İşlemi
            //Dizinin ortasını belirleyerek elemanlarını aynalar gibi düşünebilirsiniz.
            //Yani dizinin ilk elemanı ile son elemanını yer değiştirir.

            Console.WriteLine("****ARRAY REVERSE****");
            Array.Reverse(Array1);

            foreach (var number in Array1)
            {
                Console.WriteLine(number);
            }



        }
    }


           

}  

        
    

