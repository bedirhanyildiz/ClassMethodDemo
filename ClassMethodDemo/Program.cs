using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();
            Musteri musteri4 = new Musteri();

            MusteriManager musteriManager = new MusteriManager();


            musteri1.AdSoyad = "Gizem Yıldız";
            musteri1.VipMi = true;
            musteri1.Yas = 26;

            musteri2.AdSoyad = "Kuzey Yiğit Yıldız";
            musteri2.VipMi = true;
            musteri2.Yas = 1;

            musteri3.AdSoyad = "Hera Yıldız";
            musteri3.VipMi = true;
            musteri3.Yas = 4;

            musteri4.AdSoyad = "Bedirhan Yıldız";
            musteri4.VipMi = true;
            musteri4.Yas = 26;

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Sil(musteri3);
            musteriManager.Sil(musteri4);







        }
    }
}
