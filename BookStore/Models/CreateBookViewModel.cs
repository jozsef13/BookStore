using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class CreateBookViewModel
    {
        public List<Author> Authors { get; set; }
        public List<Category> Categories { get; set; }
        public List<ProductType> Types { get; set; }
        public List<Publisher> Publishers { get; set; }
        public Book Book { get; set; }
    }
}
