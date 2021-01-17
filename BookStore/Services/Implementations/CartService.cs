using BookStore.Models;
using BookStore.Repositories.Interface;
using BookStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Implementations
{
    public class CartService : ICartService
    {
        private ICartRepository cartRepository;
        private ICartBookRepository cartBookRepository;

        public CartService(ICartRepository cartRepository, ICartBookRepository cartBookRepository)
        {
            this.cartRepository = cartRepository;
            this.cartBookRepository = cartBookRepository;
        }

        public void AddBookToCart(Book book, int quantity, Cart oldCart)
        {
            oldCart.TotalPrice += Math.Round(book.Price * quantity, 2);
            CartBook cartBook = new CartBook { BookQuantity = quantity, Book = book, Cart = oldCart };
            oldCart.CartBooks.Add(cartBook);
            cartRepository.Update(oldCart);
        }

        public void AddOneBook(Cart oldCart, Book book)
        {
            UpdateQuantityForBook(1, oldCart, book);
        }

        public Cart Create(BookStoreUser user, int quantity, Book book)
        {
            Book cartBook = book;
            if(cartBook == null)
            {
                throw new Exception("Book is not valid!");
            }

            if (quantity == 0)
            {
                throw new Exception("Quantity is not valid!");
            }

            ICollection<CartBook> cartBooks = new List<CartBook>();
            CartBook cartBookObject = new CartBook { Book = cartBook, BookId = cartBook.BookId, BookQuantity = quantity};
            cartBooks.Add(cartBookObject);
            double totalPrice = Math.Round(cartBook.Price * quantity, 2);
            Cart cart = new Cart { CartId = Guid.NewGuid(), CartBooks = cartBooks, TotalPrice = totalPrice, User = user };
            cartRepository.Add(cart);
            return cart;
        }

        public List<Book> GetBooksFromCart(Cart oldCart)
        {
            return cartRepository.getBooksFromCart(oldCart);
        }

        public Cart GetCartByUserId(string id)
        {
            return cartRepository.GetByUserId(id);
        }

        public Cart RemoveBook(Cart oldCart, Book book)
        {
            if(oldCart.CartBooks.Count == 1)
            {
                cartRepository.Delete(oldCart);
                return null;
            } else
            {
                CartBook cartBook = cartRepository.GetCartBookByBookAndCart(oldCart, book);
                oldCart.TotalPrice -= Math.Round(book.Price * cartBook.BookQuantity, 2);
                oldCart.CartBooks.Remove(cartBook);
                cartBookRepository.Delete(cartBook);
                cartRepository.Update(oldCart);
                return oldCart;
            }
        }

        public Cart RemoveOneBook(Cart oldCart, Book book)
        {
            CartBook cartBook = cartRepository.GetCartBookByBookAndCart(oldCart, book);
            Cart newCart = new Cart();
            if (cartBook != null)
            {
                if(cartBook.BookQuantity == 1)
                {
                     newCart = RemoveBook(oldCart, book);
                }
                else
                {
                    UpdateQuantityForBook(-1, oldCart, book);
                    newCart = oldCart;
                }
            }

            return newCart;
        }

        public bool SearchBookInCart(Book book, Cart oldCart)
        {
            return cartRepository.isBookInCart(book, oldCart);
        }

        public void UpdateQuantityForBook(int quantity, Cart oldCart, Book book)
        {
            CartBook cartBook = cartRepository.GetCartBookByBookAndCart(oldCart, book);
            cartBook.BookQuantity += quantity;
            oldCart.TotalPrice += Math.Round(book.Price * quantity, 2);
            oldCart.CartBooks.Add(cartBook);
            cartRepository.Update(oldCart);
        }
    }
}
