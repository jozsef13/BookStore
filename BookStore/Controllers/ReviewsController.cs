using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookStore.Data;
using BookStore.Models;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace BookStore.Controllers
{
    [Authorize]
    public class ReviewsController : Controller
    {
        private readonly UserManager<BookStoreUser> _userManager;
        private readonly IBookService _bookService;
        private readonly IReviewService _reviewService;
        public ReviewsController(UserManager<BookStoreUser> userManager, IBookService bookService, IReviewService reviewService)
        {
            _userManager = userManager;
            _bookService = bookService;
            _reviewService = reviewService;
        }

        // GET: Reviews/Create
        public IActionResult AddReview(Guid bookId)
        {
            Book book = _bookService.GetBookById(bookId);
            if(book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        public async Task<IActionResult> AddReviewAction(Guid bookId, [FromForm] string reviewTitle, [FromForm] int reviewRating, [FromForm] string reviewText)
        {
            var user = await _userManager.GetUserAsync(User);
            Book book = _bookService.GetBookById(bookId);
            if (book == null)
            {
                return NotFound();
            }

            _reviewService.CreateReview(user, reviewTitle, reviewRating, reviewText, book);

            return View("ThankYou");
        }

        public async Task<IActionResult> UserIndex()
        {
            var user = await _userManager.GetUserAsync(User);
            List<Review> reviews = _reviewService.GetReviewsByUserId(user.Id);
            if (reviews == null || !reviews.Any())
            {
                TempData["Success"] = "You do not have any review!";
                string referer = Request.Headers["Referer"].ToString();
                return Redirect(referer);
            }

            return View("Index", reviews);
        }

        public IActionResult AdminIndex()
        {
            List<Review> orders = _reviewService.GetAll();
            if (orders == null || !orders.Any())
            {
                TempData["Success"] = "There are no reviews!";
                string referer = Request.Headers["Referer"].ToString();
                return Redirect(referer);
            }

            return View("Index", orders);
        }

        public IActionResult Delete(Guid id)
        {
            Review review = _reviewService.GetReviewById(id);
            if(review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        public IActionResult DeleteAction(Guid id)
        {
            Review review = _reviewService.GetReviewById(id);
            if (review == null)
            {
                return NotFound();
            }

            _reviewService.DeleteReview(review);

            TempData["Success"] = "Review deleted successfully!";
            return View("Index");
        }
    }
}
