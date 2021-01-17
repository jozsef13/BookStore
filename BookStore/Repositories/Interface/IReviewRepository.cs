using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories.Interface
{
    public interface IReviewRepository : IRepository<Review>
    {
        ICollection<Review> GetReviewsByBookId(Guid bookId);
        List<Review> GetReviewsByUserId(string id);
        List<Review> GetAllReviews();
    }
}
