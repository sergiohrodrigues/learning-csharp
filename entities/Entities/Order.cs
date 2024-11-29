using entities.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public int MyProperty { get; set; }

        public Order()
        {
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item) { 
            Items.Remove(item); 
        }

        public double Total()
        {
            foreach (OrderItem item in Items)
            {
                return item.SubTotal();
            }
        }
    }
}
