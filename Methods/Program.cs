using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methodlar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
            //Don't repeat yourself - DRY

            Product urun1 = new Product();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 20;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product urun in urunler) //Product yerine var yazıldığında da çalışır. Program kendi tanır.
            {
                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("-----------Metotlar-----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
        }
    }
}
