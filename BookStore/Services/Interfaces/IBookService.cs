using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Interfaces
{
    public interface IBookService
    {
        void CreateBook(string title, string description, double price, int quantity, string photoPath, int year, ProductTypeEnum typeName, 
        string authorFirstName, string authorLastName, CategoryEnum categoryName, string publisherName);
        List<Book> GetAllBooks();
        Book GetBookById(Guid id);
        Book UpdateBook(Guid bookId, string title, string description, double price, int quantity, string photoPath, int year, ProductTypeEnum typeName, CategoryEnum categoryName);
        void Delete(Guid id);
        List<Book> GetBooksByName(string name);
        List<Book> GetBooksByType(Guid id);
        List<Book> GetBooksByCategory(Guid id);
    }
}
