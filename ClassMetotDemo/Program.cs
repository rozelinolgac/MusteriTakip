using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri m1 = new Musteri();
            m1.Isim = "Rozelin";
            m1.Soyisim = "Olgac";
            m1.HesapTuru = "Vadesiz";
            m1.Id = 1234;

            Musteri m2 = new Musteri();
            m2.Isim = "Rozelin";
            m2.Soyisim = "Olgac";
            m2.HesapTuru = "Vadesiz";
            m2.Id = 12345;


            Musteri[] array = new Musteri[] {
            m1,m2
            };
            MusteriManager mm = new MusteriManager();
            mm.Add(m2);
            mm.Delete(m2);
            
            mm.Add(m1);
            mm.Delete(m1);
            mm.Listele(array);

        }
    }
}
