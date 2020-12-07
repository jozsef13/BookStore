using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories.Interface
{
    public interface IBookRepository : IRepository<Book>
    {
        List<Book> GetBookByName(string name);
        List<Book> GetBooksByType(Guid id);
        List<Book> GetBooksByCategory(Guid id);
    }
}
