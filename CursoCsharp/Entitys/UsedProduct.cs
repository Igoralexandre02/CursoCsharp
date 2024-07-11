using System.Text;
using System.Globalization;

namespace CursoCsharp.Entitys
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string PriceTag()
        {
            var Sb = new StringBuilder();
            Sb.Append(Name + " (Used) $" + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture date: " + ManufactureDate.ToShortDateString() + ")");
            Sb.AppendLine();
            return Sb.ToString();
        }
    }
}
