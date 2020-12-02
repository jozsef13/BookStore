using System;
using System.Collections.Generic;

namespace BookStore.Models
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public CategoryEnum Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }

    public enum CategoryEnum
    {
        Action,
        Adventure,
        Horror,
        History,
        Crime,
        Drama, 
        Fantasy,
        SF,
        Mystery,
        Poetry,
        Romance,
        Comedy,
        Thriller,
        Biography,
        Autobiography,
        Encyclopedia,
        Health,
        Journal,
        Memoir,
        Philosophy,
        Science,
        Travel
    }
}