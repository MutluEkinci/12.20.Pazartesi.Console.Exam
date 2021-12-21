using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSINAVHOCA
{
    public enum Cinsiyet { Erkek, Kadın }
    interface IEvcil { }
    class Kişi
    {
        public string KimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
    }
    class Yolcu : Kişi
    {
        public int KoltukNo { get; set; }
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public override string ToString()
        {
            return $"{KimlikNo} {Ad} {Soyad} {Cinsiyet} {KoltukNo} {Nereden} { Nereye}";
        }
    }
    class Personel : Kişi
    {
        public string SicilNo { get; set; }
        public decimal Maas { get; set; }
    }
    class Sofor : Personel
    {
        public string Rapor { get; set; }
    }
    class Muavin : Personel
    {
        public decimal Harcırah { get; set; }
    }
    class Host : Personel
    {
        public string Lojman { get; set; }
    }
    public delegate void OlayYakala();
    class Otobüs
    {
        public string Plaka { get; set; }
        public Sofor[] Sofor { get; set; }
        public Muavin Muavin { get; set; }
        public Host Host { get; set; }
        public List<Yolcu> Yolcular { get; set; }
        public List<Yük> Yükler { get; set; }
        public List<IEvcil> EvcilHayvanlar { get; set; }
        public event OlayYakala OtobüsDoldu;
        public event OlayYakala EvcilHayvanBagajıDoldu;

        public void YolcuEkle(Yolcu yolcu)
        {
            if (Yolcular.Count < 46)
                Yolcular.Add(yolcu);
            else if (OtobüsDoldu != null)
            {
                OtobüsDoldu();
            }
        }
        public void EvcilHayvanEkle(IEvcil evcilhayvan)
        {
            if (EvcilHayvanlar.Count < 3 && ((Bagaj)evcilhayvan).Ağırlık <= 5)
            {
                EvcilHayvanlar.Add(evcilhayvan);
            }
            else if (EvcilHayvanBagajıDoldu != null)
                EvcilHayvanBagajıDoldu();
        }
    }
    class Bagaj
    {
        public int Ağırlık { get; set; }
        public int KoltukNo { get; set; }
    }
    class Yük : Bagaj
    {
        public bool KırılabilenYük { get; set; }
    }
    class Evcilhayvan : Bagaj, IEvcil
    {
        public string AşıDurumu { get; set; }
        public override string ToString()
        {
            return $"{KoltukNo} {Ağırlık} {AşıDurumu}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Otobüs otobüs = new Otobüs();
            otobüs.OtobüsDoldu += Otobüs_OtobüsDoldu;
            otobüs.EvcilHayvanBagajıDoldu += Otobüs_EvcilHayvanBagajıDoldu;





        }

        private static void Otobüs_EvcilHayvanBagajıDoldu()
        {
            Console.WriteLine("Evcil Hayvan Bagajı Doldu.");
        }
        private static void Otobüs_OtobüsDoldu()
        {
            Console.WriteLine("Otobüs Doldu.");
        }
    }
}
