using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSINAV
{
    interface IEvcilHayvanAlabilir
    {
    }
    abstract class Otobüsler
    {
        public int OtoID { get; set; }
        public string Plaka { get; set; }
        public ConsoleColor Renk { get; set; }
        public string GittigiSehir { get; set; }

        ArrayList list = new ArrayList();
        public void YolcuEkle(Yolcu yolcu)
        {
            if (list.Count < 46)
                list.Add(yolcu);
            else
                Console.WriteLine("Maksimum yolcu sayısına ulaştınız.");
        }
    }
    class Bagajlar
    {
        public int BagajID { get; set; }
    }
    class BagajEvcilhayvan : Bagajlar,IEvcilHayvanAlabilir 
    {
        List<EvcilHayvan> evcillist = new List<EvcilHayvan>();
        public void EvcilHayvanEkle(EvcilHayvan hayvan)
        {
           if(evcillist.Count<3 ) 
                evcillist.Add(hayvan);
           else
                Console.WriteLine("Maxsimum kapasiteye ulaştınız.");
        }
       
    }
    class BagajNormal:Bagajlar
    {
    }
    class Yolcu
    {
        public int TcNo { get; set; }
        public string YolcuAdSoyad { get; set; }
        public override string ToString()
        {
            return YolcuAdSoyad + " " + TcNo;
        }
    }
    class EvcilHayvan
    {
        public string EvcilHayvanAd { get; set; }
        public int Kilo { get; set; }
        public override string ToString()
        {
            return EvcilHayvanAd + " " + Kilo;
        }
    }
    abstract class Personel
    {
        public int PerID { get; set; }
        public string PerAdSoyad { get; set; }
        public int CalısmaSaati { get; set; }
        public double Maas { get; set; }
        ArrayList kaptanlist = new ArrayList();
        public void KaptanEkle(KaptanSofor sofor)
        {
           if( kaptanlist.Count<2)
                kaptanlist.Add(sofor);
        }
        public void muavin(KaptanSofor sofor)
        {
            list.Add(sofor);
        }


    }
    class KaptanSofor : Personel
    {
        public double Prim { get; set; }
    }
    
    class Muavin : Personel
    {
    }
    class Host : Personel
    {
    }
    class Hostes : Personel
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Soru:Bir otobüs firması 46 kişilik otobüslere sahiptir. Her otobüse 2 kaptanşoför ile bir muavin ve bir tane de host/hostes bulunmaktadır.ayrıca her otobüse 3 tane kilosu 5kg geçmeyecek şekilde 3 evcil hayvan alınamktadır.yolcu ve evcil hayvanların max değeri aşıldığında bunu bildirecek mekanizmayı oluşturunuz.ayrıca evcil hayvanların olduğu bagaj bölgesine normal bagajlar asla konulmamaktadır.bu kriterler doğrultusunda bu brojeyi oop kullanarak modelleyiniz,gerekli sınıfları oluşturunuz,ihtiyaç duyulan başka yapıları kullanınız.Yolcu ve evcil haycan listeleri hazırlayınız.

            
        }
    }
}
