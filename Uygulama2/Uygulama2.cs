using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2
{
    class Uygulama2
    {
        static void Main(string[] args)
        {
            byte x = 20, y = 13, z = 42;

            Console.WriteLine(23 == 55 && 76 > 45 && 5 < 12);
            Console.WriteLine(23 >= 23 && 45 != 18);
            Console.WriteLine(x > y && z == y && z < x);
            Console.WriteLine(z > x && y < x);
            Console.WriteLine(x != z || y <= z);
            Console.ReadLine();
        }
    }
}
