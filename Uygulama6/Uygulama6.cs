using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama6
{
    class Uygulama6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derece giriniz");
            double derece=Convert.ToDouble(Console.ReadLine());

            double radyan = (derece * Math.PI) / 180;

            double gradyan = (derece / 400) * 360;

            Console.WriteLine(derece +" derece = "+radyan+ " radyan "+gradyan+" gradyandır.");
            Console.ReadLine();
        }
    }
}
