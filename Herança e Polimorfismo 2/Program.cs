using Herança_e_Polimorfismo_2.Entities;
using System;
using System.Collections.Generic;

namespace Herança_e_Polimorfismo_2 {
    class Program {
        private static void Main(string[] args) {

            List<Product> products = new List<Product>();

            Console.Write("Enter the number of product: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                Console.WriteLine("Product #{0} data:", i);

                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                switch (type) {

                    case 'i':
                        Console.Write("Customs fee: ");
                        double fee = double.Parse(Console.ReadLine());
                        products.Add(new ImportedProduct(name, price, fee));
                        break;

                    case 'c':
                        products.Add(new Product(name, price));
                        break;

                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, manufactureDate));
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine("PRICE TAGS:");

            foreach (Product p in products) {

                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
