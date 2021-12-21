using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static string Tamsayi(params double[] sayilar)
        {
            double toplam = 0;
            double ortalama;
            foreach (var s in sayilar)
            {
                toplam += s;
            }
            ortalama = toplam / sayilar.Count();

            double maxsayi = sayilar.Max();
            double minsayi = sayilar.Min();
            double adet = sayilar.Count();

            return "Ortalama=" + ortalama.ToString() + ";" + "MaxSayi=" + maxsayi.ToString() + ";" + "MinSayı=" + minsayi.ToString() + ";" + "Sayi Adedi=" + adet.ToString() ;

        }
        static void Main(string[] args)
        {
            //Soru2:Bir metoda;istenilen kadar tam sayi gönderildikten sonra o sayıları ortalamasını, max ve min sayıları ve gelen sayıların kaç adet olduğunu döndüren metodu yazınız.

            Console.WriteLine(Tamsayi(4,2,2,56,12,16));
        }
    }
}
