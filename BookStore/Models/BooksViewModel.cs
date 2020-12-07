using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BooksViewModel
    {
        public List<Book> Books { get; set; }
        public List<ProductType> ProductTypes { get; set; }
        public List<Category> Categories { get; set; }
    }
}
