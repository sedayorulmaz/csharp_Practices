using System;

namespace console_programming
{
    class Program
    {
        static void Main(string[] args)
        {


            // if-elseif koşullu durumları
            // koşul kontrol edilecek durumlar için kullanılırlar. 


            // Sistemden saati alıp ilgili saate göre karşılama mesajı döndüren program

            int time = DateTime.Now.Hour;
            if (time>=4 && time<=10)
            {
                //Eğer saat değeri 4'ten büyük-eşit ve 10'dan küçük-eşit ise bu kod bloğu çalışır  
                Console.WriteLine("Günaydın");
            }

            else if (time<=18)
            {
                //Eğer saat değeri üstteki koşula uymuyor fakat 18'den küçük-eşit dönüyorsa bu kod bloğu çalışır
                Console.WriteLine("İyi Günler");
            }

            else
            {
                // İki koşula uymaması halinde else kod bloğu çalışır
                Console.WriteLine("İyi Geceler");

            }


           


        }  

        }
    }

