using CursoCsharp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCsharp.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public Order() { }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Item.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Item.Remove(item);
        }
        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Item)
            {
                if (item != null)
                    sum += item.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Client: " + Client.Name + " (" + Client.BirthDate.ToShortDateString() + ") - " + Client.Email);
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in Item)
            {
                sb.AppendLine(item.Product.Name + ", $" + item.Product.Price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantity: " + item.Quantity + ", SubTotal: $" + item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
