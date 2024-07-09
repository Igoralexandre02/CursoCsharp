using System.Text;
using System.Globalization;

namespace CursoCsharp.Entitys
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }   

        public virtual string PriceTag()
        {
            var Sb = new StringBuilder();
            Sb.Append(Name + "$" + Price.ToString("F2", CultureInfo.InvariantCulture)); 
            return Sb.ToString();
        }
    }
}
