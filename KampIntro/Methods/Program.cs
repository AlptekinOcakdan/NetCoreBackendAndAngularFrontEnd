using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Apple";
            product1.Price = 10;
            product1.Description = "Apple from Amasya";
            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Description = "Watermelon from Diyarbakır";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("___________________________________");
            }

            Console.WriteLine("---------------Methods--------------------");
            CardManager cardManager = new CardManager();
            cardManager.Add(product1);
            cardManager.Add2("Armut","Yeşil",12);
            cardManager.Add2("Elma","Yeşil",12);
            cardManager.Add2(product1.Name,product1.Description,product1.Price);
            cardManager.Add2("Fındık","Ordu",12);
        }
    }
}