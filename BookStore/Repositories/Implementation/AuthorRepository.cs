using BookStore.Data;
using BookStore.Models;
using BookStore.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories.Implementation
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(BookStoreDbContext context) : base(context)
        { }

        public Author GetAuthorByName(string authorFirstName, string authorLastName)
        {
            return context.Authors.SingleOrDefault(a => a.FirstName == authorFirstName && a.LastName == authorLastName);
        }
    }
}
