using Enum_e_Composicao.Entites;
using Enum_e_Composicao.Entites.Enums;
using System;

namespace Enum_e_Composicao {
    class Program {
        static void Main(string[] args) {


            Console.WriteLine("Enter cliente data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int quanty = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quanty; i++) {

                Console.WriteLine("Enter #{0} item data:", i);

                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);

                OrderItem item = new OrderItem(quantity, price, product);

                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");

            Console.WriteLine(order);
        }
    }
}
