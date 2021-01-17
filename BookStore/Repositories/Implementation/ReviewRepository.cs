using BookStore.Data;
using BookStore.Models;
using BookStore.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories.Implementation
{
    public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(BookStoreDbContext context) : base(context)
        {
        }

        public List<Review> GetAllReviews()
        {
            List<Review> reviews = GetAll();
            foreach (Review review in reviews)
            {
                var user = context.Users.SingleOrDefault(a => a.Id == review.UserName);
                var book = context.Books.SingleOrDefault(b => b.BookId == review.BookId);
                review.Book = book;
                review.User = user;
            }

            return reviews;
        }

        public ICollection<Review> GetReviewsByBookId(Guid bookId)
        {
            ICollection<Review> reviews = context.Reviews.Where(a => a.BookId == bookId).ToList();
            foreach(Review review in reviews)
            {
                var user = context.Users.SingleOrDefault(a => a.Id == review.UserName);
                var book = context.Books.SingleOrDefault(b => b.BookId == review.BookId);
                review.Book = book;
                review.User = user;
            }

            return reviews;
        }

        public List<Review> GetReviewsByUserId(string id)
        {
            List<Review> reviews = context.Reviews.Where(a => a.UserName == id).ToList();
            foreach (Review review in reviews)
            {
                var user = context.Users.SingleOrDefault(a => a.Id == review.UserName);
                var book = context.Books.SingleOrDefault(b => b.BookId == review.BookId);
                review.Book = book;
                review.User = user;
            }

            return reviews;
        }
    }
}
