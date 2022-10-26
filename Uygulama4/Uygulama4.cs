using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama4
{
    class Uygulama4
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Gün giriniz");
            int gün = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ay giriniz");
            int ay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yıl giriniz");
            int yil = Convert.ToInt32(Console.ReadLine());

            switch (ay - 1)
            {
                case (0):
                    Console.WriteLine("Ocak ayındayız");
                    break;
                case (1):
                    Console.WriteLine("Şubat ayındayız");
                    break;
                case (2):
                    Console.WriteLine("Mart ayındayız");
                    break;
                case (3):
                    Console.WriteLine("Nissan ayındayız");
                    break;
                case (4):
                    Console.WriteLine("Mayıs ayındayız");
                    break;
                case (5):
                    Console.WriteLine("Haziran ayındayız");
                    break;
                case (6):
                    Console.WriteLine("Temmuz ayındayız");
                    break;
                case (7):
                    Console.WriteLine("Ağustos ayındayız");
                    break;
                case (8):
                    Console.WriteLine("Eylül ayındayız");
                    break;
                case (9):
                    Console.WriteLine("Ekim ayındayız");
                    break;
                case (10):
                    Console.WriteLine("Kasım ayındayız");
                    break;
                case (11):
                    Console.WriteLine("Aaralık ayındayız");
                    break;
                default:
                    Console.WriteLine("Yanlış ay girdiniz");
                    break;
            }
            Console.ReadLine(); 
        }
    }
}
