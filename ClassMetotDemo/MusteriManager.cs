using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri m)
        {
            Console.WriteLine(m.Id+" Hesap Numaralı müşteri veritabanına eklendi! ");
        }
        public void Delete(Musteri m)
        {
            Console.WriteLine(m.Id+" Hesap Numaralı müşteri veritabanından silindi!");
        }
           
        public void Listele(Musteri [] m)
        {
            Console.WriteLine("Müşteriler Listeleniyor..");
            foreach (var item in m)
            {
                Console.WriteLine("Kullanıcı Adı:" + item.Isim);
                Console.WriteLine("          Soyadı:" + item.Soyisim);
                Console.WriteLine("          HesapNumarası:" + item.Id);
                Console.WriteLine("          HesapTuru:" + item.HesapTuru);
            }
        }
    }



}
