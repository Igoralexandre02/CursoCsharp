using System;
using System.Globalization;
using CursoCsharp.Entities;

namespace CursoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            var number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            var date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Contract value: ");
            var totalValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            var NI = int.Parse(Console.ReadLine());

            var contract = new Contract(number, date, totalValue);

        }
    }
}