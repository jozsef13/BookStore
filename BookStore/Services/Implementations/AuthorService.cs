using BookStore.Models;
using BookStore.Repositories.Interface;
using BookStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Implementations
{
    public class AuthorService : IAuthorService
    {
        private IAuthorRepository authorRepository;
        public AuthorService(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public void CreateAuthor(Author model)
        {
            Author newAuthor = new Author
            {
                AuthorId = Guid.NewGuid(),
                About = model.About,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Nationality = model.Nationality
            };

            authorRepository.Add(model);
        }

        public void Delete(Guid authorId)
        {
            Author author = GetAuthorById(authorId);
            authorRepository.Delete(author);
        }

        public List<Author> GetAllAuthors()
        {
            return authorRepository.GetAll();
        }

        public Author GetAuthorById(Guid id)
        {
            return authorRepository.GetById(id);
        }

        public void Update(Author model)
        {
            if(model == null)
            {
                throw new Exception("Invalid object!");
            }

            authorRepository.Update(model);
        }
    }
}
