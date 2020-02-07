using System;
using System.Collections.Generic;
using System.Text;
using Composition3.Entitites.Enum;

namespace Composition3.Entitites
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> orderItem { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime date, OrderStatus orderStatus)
        {
            Date = date;
            OrderStatus = orderStatus;
        }

        public void AddItem(OrderItem item)
        {
            orderItem.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            orderItem.Remove(item);
        }
        
        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in orderItem)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + OrderStatus);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in orderItem)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total());
            return sb.ToString();
        }

    }
}
