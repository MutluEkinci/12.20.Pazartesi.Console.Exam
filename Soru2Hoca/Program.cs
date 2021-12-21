using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2Hoca
{
    class Program
    {
        static Dictionary<string,double> SayilarKumesi(int[] sayilar)
        {
            Dictionary<string, double> istatistik = new Dictionary<string, double>();
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }
            istatistik.Add("Adet", sayilar.Length);
            istatistik.Add("Ort.",(double)toplam/sayilar.Length);
            istatistik.Add("Max", sayilar.Max());
            istatistik.Add("Min", sayilar.Min());
            return istatistik;
        }
        
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 5, 8, 9, 4, 5, 3, 15 };
            
            foreach (var item in SayilarKumesi(sayilar))
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
