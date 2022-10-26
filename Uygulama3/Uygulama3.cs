using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama3
{
    class Uygulama3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Sayi giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1%sayi2==0)
            {
                Console.WriteLine("Tam bölünür");
            }
            else
            {
                Console.WriteLine("Tam bölünmez");
            }
            
            Console.ReadLine();
        }
    }
}
