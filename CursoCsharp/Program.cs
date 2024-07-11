using System.Globalization;
using CursoCsharp.Entitys;


namespace CursoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> Products = [];

            Console.Write("Enter the number of products: ");
            var Prod = int.Parse(Console.ReadLine());
            char typeProd;
            for (int i = 0; i < Prod; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                typeProd = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.Write("Price: ");
                var price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                switch (typeProd)
                {
                    case 'i':
                        Console.Write("Customs fee: ");
                        var customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Products.Add(new ImportedProduct(name, price, customFee));
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        Products.Add(new UsedProduct(name, price, manufactureDate));
                        break;
                    case 'c':
                        Products.Add(new Product(name, price));
                        break;
                    default:
                        Console.WriteLine("Not is type !");
                        break;
                }
            }
            Console.WriteLine();
            foreach (Product product in Products)
            {
                if (product != null)
                {
                    Console.Write(product.PriceTag());
                }
            }
        }
    }
}
