using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Adi + " : " + product.Aciklama + " =" +
                    " " + product.Fiyati);
            }
            // encapsulation
            Console.WriteLine("-----------Metotlar-------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Ekle2("Karpuz" ,"diyarbakır karpuzu", 80,15);
        }
    }
}



// Do not repeat yourself--- DRY-- Clean Code - Best Practice