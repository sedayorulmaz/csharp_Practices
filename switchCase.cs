using System;

namespace console_programming
{
    class Program
    {
        static void Main(string[] args)
        {


            //switch-case örneği@
            //Bir ifade üç veya daha fazla koşula göre ayrıştırıldığında genel @
            //olarak if-else 'e alternatif olarak switch case kullanılır.
            

            int month = DateTime.Now.Month;
            switch (month)
            {
                case 1:
                    Console.WriteLine("Aylardan Ocak");
                    break;
                case 2:
                    Console.WriteLine("Aylardan Şubat");
                    break;
                case 3:
                    Console.WriteLine("Aylardan Mart");
                    break;
                case 4:
                    Console.WriteLine("Aylardan Nisan");
                    break;
                case 5:
                    Console.WriteLine("Aylardan Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Aylardan Haziran");
                    break;
                case 7:
                    Console.WriteLine("Aylardan Temmuz");
                    break;
                case 8:
                    Console.WriteLine("Aylardan Ağustos");
                    break;
                case 9:
                    Console.WriteLine("Aylardan Eylül");
                    break;
                case 10:
                    Console.WriteLine("Aylardan Ekim");
                    break;
                case 11:
                    Console.WriteLine("Aylardan Kasım");
                    break;
                case 12:
                    Console.WriteLine("Aylardan Aralık");
                    break;

                default:
                    Console.WriteLine("Hatalı veri girişi");
                    break;
            }
        }


           


        }  

        }
    

