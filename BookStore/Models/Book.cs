using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string CoverPhotoPath { get; set; }
        public int Year { get; set; }

        public Guid ProductTypeId { get; set; }
        public ProductType Type { get; set; }
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
        public Guid PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public virtual ICollection<CartBook> CartBooks { get; set; }
        public virtual ICollection<OrderBook> OrderBooks { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
