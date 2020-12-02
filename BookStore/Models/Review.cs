using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Review
    {
        public Guid ReviewId { get; set; }
        public string ReviewText { get; set; }
        public string ReviewTitle { get; set; }
        private double Rating { get; set; }

        public string UserName { get; set; }
        public BookStoreUser User { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }
    }
}
