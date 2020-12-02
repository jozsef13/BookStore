using System;

namespace BookStore.Models
{
    public class CartBook
    {
        public Guid CartId { get; set; }
        public Cart Cart { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }
    }
}