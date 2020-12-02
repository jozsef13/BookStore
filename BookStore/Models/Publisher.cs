using System;
using System.Collections.Generic;

namespace BookStore.Models
{
    public class Publisher
    {
        public Guid PublisherId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}