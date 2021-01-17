using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using BookStore.Services.Interfaces;

namespace BookStore.Controllers
{
    [Authorize(Roles = "User")]
    public class CartsController : Controller
    {
        private readonly UserManager<BookStoreUser> _userManager;
        private readonly ICartService _cartService;
        private readonly IBookService _bookService;

        public CartsController(UserManager<BookStoreUser> userManager, ICartService cartService,
            IBookService bookService)
        {
            _userManager = userManager;
            _cartService = cartService;
            _bookService = bookService;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var cart = _cartService.GetCartByUserId(user.Id);
            if (cart == null)
            {
                TempData["Success"] = "Cart is empty! Add books to cart!";
                return Redirect(Url.Action("Index", "Books"));
            }

            return View(cart);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddToCart([FromForm] int quantity, Guid bookId)
        {
            var user = await _userManager.GetUserAsync(User);
            var book = _bookService.GetBookById(bookId);
            var oldCart = _cartService.GetCartByUserId(user.Id);
            if (quantity == 0)
            {
                quantity = 1;
            }
            if (oldCart == null)
            {
                var cart = _cartService.Create(user, quantity, book);
                TempData["Success"] = "Added to cart successfully!";
                return Redirect(Url.Action("Index", "Carts"));
            }
            else
            {
                bool isBookInCart = _cartService.SearchBookInCart(book, oldCart);
                if (isBookInCart)
                {
                    _cartService.UpdateQuantityForBook(quantity, oldCart, book);
                }
                else
                {
                    _cartService.AddBookToCart(book, quantity, oldCart);
                }

                TempData["Success"] = "Added to cart successfully!";
                return Redirect(Url.Action("Index", "Carts"));
            }
        }

        public async Task<IActionResult> RemoveBook(Guid bookId)
        {
            var user = await _userManager.GetUserAsync(User);
            var book = _bookService.GetBookById(bookId);
            var oldCart = _cartService.GetCartByUserId(user.Id);

            var newCart = _cartService.RemoveBook(oldCart, book);

            if(newCart == null)
            {
                TempData["Success"] = "You deleted all books from cart successfully!";
                return Redirect(Url.Action("Index", "Home"));
            } else
            {
                TempData["Success"] = "You deleted " + book.Title + " from cart successfully!";
                return Redirect(Url.Action("Index", "Carts"));
            }
        }

        public async Task<IActionResult> RemoveOneBook(Guid bookId)
        {
            var user = await _userManager.GetUserAsync(User);
            var book = _bookService.GetBookById(bookId);
            var oldCart = _cartService.GetCartByUserId(user.Id);

            Cart newCart = _cartService.RemoveOneBook(oldCart, book);
            if (newCart == null)
            {
                TempData["Success"] = "You deleted all books from cart successfully!";
                return Redirect(Url.Action("Index", "Home"));
            }
            else
            {
                TempData["Success"] = "You removed one " + book.Title + " from cart successfully!";
                return Redirect(Url.Action("Index", "Carts"));
            }
        }

        public async Task<IActionResult> AddOneBook(Guid bookId)
        {
            var user = await _userManager.GetUserAsync(User);
            var book = _bookService.GetBookById(bookId);
            var oldCart = _cartService.GetCartByUserId(user.Id);
            _cartService.AddOneBook(oldCart, book);

            TempData["Success"] = "You added one " + book.Title + " to cart successfully!";
            return Redirect(Url.Action("Index", "Carts"));
        }

        public async Task<IActionResult> Checkout()
        {
            var user = await _userManager.GetUserAsync(User);
            var cart = _cartService.GetCartByUserId(user.Id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }
    }
}
