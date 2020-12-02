using System;
using System.Collections.Generic;

namespace BookStore.Models
{
    public class Author
    {
        public Guid AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public string About { get; set; }
        public virtual ICollection<Book> WrittenBooks { get; set; }
    }
}