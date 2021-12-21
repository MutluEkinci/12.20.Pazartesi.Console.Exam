using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3Hoca
{
    class Program
    {
        static string Maskele(string strmesaj,char maske,params char[] karakterler)
        {
            string stryeni = "";
            foreach (var c in karakterler)
            {
               stryeni=strmesaj.Replace(c, maske);
            }
            return stryeni;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Maskele(Console.ReadLine(),'*','a','e','i'));
        }
    }
}
