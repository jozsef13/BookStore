using System;
using System.Collections.Generic;

namespace BookStore.Models
{
    public class ProductType
    {
        public Guid ProductTypeId { get; set; }
        public ProductTypeEnum Name { get; set; }

       public virtual ICollection<Book> Books { get; set; }
    }

    public enum ProductTypeEnum
    {
        PhysicalBook,
        Ebook
    }
}