using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Interfaces
{
    public interface ICartService
    {
        Cart GetCartByUserId(string id);
        Cart Create(BookStoreUser user, int quantity, Book book);
        List<Book> GetBooksFromCart(Cart oldCart);
        bool SearchBookInCart(Book book, Cart oldCart);
        void UpdateQuantityForBook(int quantity, Cart oldCart, Book book);
        void AddBookToCart(Book book, int quantity, Cart oldCart);
        Cart RemoveBook(Cart oldCart, Book book);
        Cart RemoveOneBook(Cart oldCart, Book book);
        void AddOneBook(Cart oldCart, Book book);
    }
}
