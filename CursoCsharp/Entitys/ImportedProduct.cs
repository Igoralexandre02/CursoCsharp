using System.Text;
using System.Globalization;

namespace CursoCsharp.Entitys
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }
        public double TotalPrice()
        {
            return CustomsFee + Price;
        }
        public override string PriceTag()
        {
            base.PriceTag();
            var Sb = new StringBuilder();
            Sb.Append("(Customs Fee: $" + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")");

            return Sb.ToString();
        }
    }
}
