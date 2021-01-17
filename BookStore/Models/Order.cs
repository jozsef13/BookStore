using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Order
    {
        public enum Status
        {
            Placed,
            Approved,
            Delivered
        }

        public enum PaymentMethods
        {
            Paypal,
            Cash,
            Card
        }

        public Guid OrderId { get; set; }
        public Status OrderStatus { get; set; }
        public double TotalPrice { get; set; }
        public DateTime? ShippingDate { get; set; }

        public string UserName { get; set; }
        public BookStoreUser User { get; set; }
        public virtual ICollection<OrderBook> OrderBooks { get; set; }
        public PaymentMethods PaymentMethod { get; set; }
    }
}
