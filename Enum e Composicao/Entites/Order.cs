using Enum_e_Composicao.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Enum_e_Composicao.Entites {
    class Order {

        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        List<OrderItem> OrderItems = new List<OrderItem>();
        public Client Client = new Client();
        public Order() {
        }

        public Order(DateTime moment, OrderStatus orderStatus, Client client) {
            Moment = moment;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddItem(OrderItem item) {

            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item) {

            OrderItems.Remove(item);
        }

        public double Total() {

            double count = 0.0;

            foreach (OrderItem item in OrderItems) {

                count += item.SubTotal();
            }

            return count;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(OrderStatus.ToString());
            sb.Append("Client: ");
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items:");

            foreach (OrderItem item in OrderItems) {

                sb.AppendLine(item.ToString());
            }

            sb.Append("Total price: $");
            sb.Append(Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
