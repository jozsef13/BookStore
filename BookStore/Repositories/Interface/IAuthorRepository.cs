using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;

namespace BookStore.Repositories.Interface
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorByName(string authorFirstName, string authorLastName);
    }
}
