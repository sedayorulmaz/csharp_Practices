using System;

namespace console_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try Catch Finally ve Mantıksal Hatalar

            // try: hataya sebebiyet verme ihtimali olan kod
            // catch: hatayla karşılaşıldığında ne yapılacağı 
            // finally: hata olsa da olmasa da yapılacak işlem (optional)


            try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı: " + number);
            }

            // Hatalı bir işlem yapıldığında ekrana yazılacak mesaj
            catch (Exception ex)
            {

                Console.WriteLine("Hata: " + ex.Message.ToString());
            }

            // Hata olsa da olmasa da ekrana yazdırılacak olan mesaj
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");

            }


            // ****FORMAT EXCEPTION
            try
            {
                int a = int.Parse("Test");


            }

            // Uygun olmayan bir veri tipi girişi yapıldığı için FormatException hatası dönecek
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun olmayan bir değer girdiniz.");
                Console.WriteLine(ex);
            }

            /* EXCEPTIONS
              
            

            // ****ARGUMENTNULL EXCEPTION

            try
            {
                int a = int.Parse(null);
                
            }

            // Null değer girildiği için  ArgumentNullException hatası dönecek
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş bir değer girdiniz.");
                Console.WriteLine(ex);
            }


            // ****OVERFLOW EXCEPTION

            try
            {
                int a = int.Parse("-6123456789789");

            }

            //Çok büyük ya da çok küçük değer girildiği için OverflowException hatası dönecek
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok büyük ya da çok küçük bir değer girdiniz.");
                Console.WriteLine(ex);



            */
            }

        }
    }

