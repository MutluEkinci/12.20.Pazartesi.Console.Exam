using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static string Maske(char c,string mesaj , params char[] karakterler)
        {
            List<char> list = new List<char>();
            foreach (var item in karakterler)
            {
                list.Add(item);
            }
            string strYeni = mesaj;
            for (int i = 0; i < mesaj.Length; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (mesaj[i] == list[j])
                    {
                        strYeni=strYeni.Replace(list[j], c);
                    }
                }
            }
            return strYeni;
        }
        static void Main(string[] args)
        {
            //Soru3:Bir metoda gönderilen string bir ifade içerisinde istenilen kadar karakteri istenilen bir karakter ile maskeleyen metodu yazınız.

            Console.WriteLine(Maske('*', "Bugün hava çok güzel",'a','e'));
        }
    }
}
