using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Interfaces
{
    public interface IAuthorService
    {
        List<Author> GetAllAuthors();
        void CreateAuthor(Author model);
        Author GetAuthorById(Guid id);
        void Update(Author model);
        void Delete(Guid authorId);
    }
}
