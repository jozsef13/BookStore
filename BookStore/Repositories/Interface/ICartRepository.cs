using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories.Interface
{
    public interface ICartRepository : IRepository<Cart>
    {
        Cart GetByUserId(string id);
        List<Book> getBooksFromCart(Cart oldCart);
        bool isBookInCart(Book book, Cart oldCart);
        CartBook GetCartBookByBookAndCart(Cart oldCart, Book book);
    }
}
