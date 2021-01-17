using BookStore.Data;
using BookStore.Models;
using BookStore.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories.Implementation
{
    public class CartRepository : BaseRepository<Cart>, ICartRepository
    {
        private readonly IBookRepository bookRepository;

        public CartRepository(BookStoreDbContext context, IBookRepository _bookRepository) : base(context)
        {
            bookRepository = _bookRepository;
        }

        public List<Book> getBooksFromCart(Cart oldCart)
        {
            List<CartBook> cartBooks = context.CartBooks.Where(o => o.CartId == oldCart.CartId).ToList();
            List<Book> books = new List<Book>();
            foreach(CartBook cartBook in cartBooks)
            {
                var book = context.Books.SingleOrDefault(a => a.BookId == cartBook.BookId);
                books.Add(book);
            }
            return books;
        }

        public Cart GetByUserId(string id)
        {
            Cart cart = context.Carts.SingleOrDefault(a => a.UserName == id);
            if(cart != null)
            {
                ICollection<CartBook> cartBooks = context.CartBooks.Where(cb => cb.CartId == cart.CartId).ToList();
                foreach(CartBook cartBook in cartBooks)
                {
                    var iBook = bookRepository.GetById(cartBook.BookId);
                    cartBook.Book = iBook;
                }
                cart.CartBooks = cartBooks;
            }
            return cart;
        }

        public CartBook GetCartBookByBookAndCart(Cart oldCart, Book book)
        {
            CartBook cartBook = context.CartBooks.SingleOrDefault(o => o.CartId == oldCart.CartId && o.BookId == book.BookId);
            return cartBook;
        }

        public bool isBookInCart(Book book, Cart oldCart)
        {
            List<CartBook> cartBooks = context.CartBooks.Where(o => o.CartId == oldCart.CartId).ToList();
            foreach(CartBook cartBook in cartBooks)
            {
                if(cartBook.BookId == book.BookId)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
