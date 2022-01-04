using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //İsminde Manager, Service gibi isimler barındıran Classlar operasyon içerir.

        public void Ekle(Product urun)
        {
            Console.WriteLine(urun.Adi + " Sepete Eklendi!");
        }
        public void Ekle(string urunAdi, string Aciklama, double fiyat) //Yanlış kullanım.
        {
            //Ekstra bir parametre eklemek gerektiğinde -örn:stok adedi- her sayfada değiştirmek gerekecek.
            Console.WriteLine(urunAdi + " Sepete Eklendi!");
        }
    }
}
