using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._20.Pazartesi
{
    class Program
    {
        public static int KelimeSayisiBul(string mesaj,char c =' ')
        {
            int sayac = 1;
            for (int i = 0; i < mesaj.Length; i++)
            {
                if (mesaj[i] == c)
                {
                    sayac++;
                }
            }
            return sayac;
        }
        static void Main(string[] args)
        {
            //Soru1:Parametre olarak string bir ifade gönderilen bir metod ile gelen stringdeki kelime sayısını döndüren metodu yazınız.

            Console.WriteLine(KelimeSayisiBul("mutlu çok mutlu aaa"));
           
        }
    }
}
