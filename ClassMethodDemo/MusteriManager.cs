using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("musteriler basariyla eklendi." + musteri.AdSoyad);
            
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                
                Console.WriteLine("Musteri Adi Soyadi: " + musteri.AdSoyad);
                Console.WriteLine("Musteri Yasi: " + musteri.VipMi);
                Console.WriteLine("Musteri e-maili: " + musteri.Yas);
            }
        }

        public void Sil(Musteri musteri)
        {
            
            Console.WriteLine("Musteriler basariyla silindi." + musteri.AdSoyad);
        }
    }
}
