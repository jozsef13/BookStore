using BookStore.Data;
using BookStore.Models;
using BookStore.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories.Implementation
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        private IReviewRepository reviewRepository;

        public BookRepository(BookStoreDbContext context, IReviewRepository reviewRepository) : base(context)
        {
            this.reviewRepository = reviewRepository;
        }

        public List<Book> GetBookByName(string name)
        {
            var returnedBooks = GetAll();

            if(!String.IsNullOrEmpty(name))
            {
                returnedBooks = returnedBooks.Where(s => s.Title.Contains(name, StringComparison.CurrentCultureIgnoreCase)).ToList();
            }

            foreach (Book iBook in returnedBooks)
            {
                iBook.Author = context.Authors.Find(iBook.AuthorId);
                iBook.Category = context.Categories.Find(iBook.CategoryId);
                iBook.Type = context.ProductTypes.Find(iBook.ProductTypeId);
                iBook.Publisher = context.Publishers.Find(iBook.PublisherId);
                iBook.Reviews = reviewRepository.GetReviewsByBookId(iBook.BookId);
            }

            return returnedBooks;
        }

        public List<Book> GetBooksByCategory(Guid id)
        {
            var returnedBooks = context.Books.Where(b => b.CategoryId == id).ToList();

            foreach (Book iBook in returnedBooks)
            {
                iBook.Author = context.Authors.Find(iBook.AuthorId);
                iBook.Category = context.Categories.Find(iBook.CategoryId);
                iBook.Type = context.ProductTypes.Find(iBook.ProductTypeId);
                iBook.Publisher = context.Publishers.Find(iBook.PublisherId);
                iBook.Reviews = reviewRepository.GetReviewsByBookId(iBook.BookId);
            }

            return returnedBooks;
        }

        public List<Book> GetBooksByType(Guid id)
        {
            var returnedBooks = context.Books.Where(b => b.ProductTypeId == id).ToList();

            foreach (Book iBook in returnedBooks)
            {
                iBook.Author = context.Authors.Find(iBook.AuthorId);
                iBook.Category = context.Categories.Find(iBook.CategoryId);
                iBook.Type = context.ProductTypes.Find(iBook.ProductTypeId);
                iBook.Publisher = context.Publishers.Find(iBook.PublisherId);
                iBook.Reviews = reviewRepository.GetReviewsByBookId(iBook.BookId);
            }

            return returnedBooks;
        }
    }
}
