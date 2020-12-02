using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BookStoreUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserPhoto { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string GenderType { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
