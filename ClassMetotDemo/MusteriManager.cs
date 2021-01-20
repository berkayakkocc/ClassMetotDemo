using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Tüm Musteri Bilgileri");
            Console.WriteLine(musteri.Id);
            Console.WriteLine(musteri.Ad);
            Console.WriteLine(musteri.Soyad);
            Console.WriteLine(musteri.Yas);

        }
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi");
        }
    }
}
