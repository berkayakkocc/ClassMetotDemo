using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 11111;//test                                                  
            musteri1.Ad = "Berkaycan";
            musteri1.Soyad = "Akkoç";
            musteri1.Yas = 24;

            
            Musteri musteri2 = new Musteri();
            musteri2.Id = 22222;
            musteri2.Ad = "Altay";
            musteri2.Soyad = "Akkoç";
            musteri2.Yas = 19;

            
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            Console.WriteLine("-------------");

            musteriManager.Ekle(musteri1);
            Console.WriteLine("-------------");
            musteriManager.Sil(musteri2);

        }
    }
}
