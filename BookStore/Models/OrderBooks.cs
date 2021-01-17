using System;

namespace BookStore.Models
{
    public class OrderBook
    {
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }
        public Guid BookId { get; set; }
        public virtual Book Book { get; set; }
        public int BookQuantity { get; set; }
    }
}