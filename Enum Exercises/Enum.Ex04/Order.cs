using System;
using Enum_Ex04.Entities.Enums;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace Enum_Ex04.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Clients Client { get; set; }
        List<OrderItem> ListItems { get; set; } = new List<OrderItem>();

        public Order() { 
        }
        public Order(DateTime moment, OrderStatus status, Clients client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem Item)
        {
            ListItems.Add(Item);
        }

        public void RemoveItem(OrderItem Item)
        {
            ListItems.Remove(Item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem Item in ListItems)
            {
                
                sum += Item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: "+ Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in ListItems)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
