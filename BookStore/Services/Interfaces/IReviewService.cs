using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Interfaces
{
    public interface IReviewService
    {
        void CreateReview(BookStoreUser user, string reviewTitle, int reviewRating, string reviewText, Book book);
        List<Review> GetReviewsByUserId(string id);
        List<Review> GetAll();
        Review GetReviewById(Guid id);
        void DeleteReview(Review review);
    }
}
