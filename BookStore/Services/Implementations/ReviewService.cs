using BookStore.Models;
using BookStore.Repositories.Interface;
using BookStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Implementations
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository reviewRepository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            this.reviewRepository = reviewRepository;
        }

        public void CreateReview(BookStoreUser user, string reviewTitle, int reviewRating, string reviewText, Book book)
        {
            if(user == null)
            {
                throw new Exception("The user is null!");
            }

            if (book == null)
            {
                throw new Exception("The book is null!");
            }

            if (reviewTitle == null)
            {
                throw new Exception("The review title is null!");
            }

            if (reviewRating == 0)
            {
                throw new Exception("The review rating is null!");
            }

            if (reviewText == null)
            {
                throw new Exception("The review text is null!");
            }

            Review review = new Review { ReviewId = Guid.NewGuid(), Book = book, Rating = reviewRating, ReviewText = reviewText, ReviewTitle = reviewTitle, User = user };

            reviewRepository.Add(review);
        }

        public List<Review> GetAll()
        {
            return reviewRepository.GetAllReviews();
        }

        public List<Review> GetReviewsByUserId(string id)
        {
            return reviewRepository.GetReviewsByUserId(id);
        }

        public Review GetReviewById(Guid id)
        {
            return reviewRepository.GetById(id);
        }
        public void DeleteReview(Review review)
        {
            reviewRepository.Delete(review);
        }
    }
}
