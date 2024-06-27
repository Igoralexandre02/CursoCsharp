using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using CursoCsharp.Entities.Enums;
using CursoCsharp.Entities;


namespace CursoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            var status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            var n = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                var nameProd = Console.ReadLine();
                Console.Write("Product price: ");
                var priceProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                var quantProd = int.Parse(Console.ReadLine());

                Product product = new Product(nameProd, priceProd);
                OrderItem orderItem = new OrderItem(quantProd, priceProd, product);
                order.AddItem(orderItem);
            }
            Console.WriteLine();

            Console.WriteLine(order);
        }
    }
}
