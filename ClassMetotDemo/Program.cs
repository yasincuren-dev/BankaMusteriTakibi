using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 0;
            musteri1.MusteriAd = "Yasin";
            musteri1.MusteriSoyad = "Çüren";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 1;
            musteri2.MusteriAd = "Kerem";
            musteri2.MusteriSoyad = "Çüren";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            Console.WriteLine("------------------------------------------");

            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);
            Console.WriteLine("------------------------------------------");

            musteriManager.MusteriSil(musteri1);
        }
    }
}
