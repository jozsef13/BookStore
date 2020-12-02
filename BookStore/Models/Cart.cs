using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Cart
    {
        public Guid CartId { get; set; }
        public double TotalPrice { get; set; }

        public virtual string UserName { get; set; }
        public virtual BookStoreUser User { get; set; }
        public virtual ICollection<CartBook> CartBooks { get; set; }

    }
}
