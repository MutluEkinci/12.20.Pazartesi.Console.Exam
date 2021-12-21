using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1Hoca
{
    class Program
    {
        static int KelimeSayisiBul(string str)
        {
            return str.Split(' ').Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(KelimeSayisiBul(Console.ReadLine()));
        }
    }
}
