using BookStore.Models;
using BookStore.Repositories.Interface;
using BookStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Implementations
{
    public class BookService : IBookService
    {
        private IBookRepository bookRepository;
        private IAuthorRepository authorRepository;
        private IProductTypeRepository typeRepository;
        private ICategoryRepository categoryRepository;
        private IPublisherRepository publisherRepository;

        public BookService(IBookRepository bookRepository, IAuthorRepository authorRepository, IProductTypeRepository typeRepository, ICategoryRepository categoryRepository, IPublisherRepository publisherRepository)
        {
            this.bookRepository = bookRepository;
            this.authorRepository = authorRepository;
            this.typeRepository = typeRepository;
            this.categoryRepository = categoryRepository;
            this.publisherRepository = publisherRepository;
        }

        public void CreateBook(string title, string description, double price, int quantity, string photoPath, int year, ProductTypeEnum typeName,
        string authorFirstName, string authorLastName, CategoryEnum categoryName, string publisherName)
        {
            Author author = authorRepository.GetAuthorByName(authorFirstName, authorLastName);
            if (author == null)
            {
                throw new Exception("The author does not exist!");
            }

            ProductType type = typeRepository.GetProductTypeByName(typeName);
            if(type == null)
            {
                throw new Exception("The product type does not exist!");
            }

            Category category = categoryRepository.GetCategoryByName(categoryName);
            if(category == null)
            {
                throw new Exception("The category does not exist!");
            }

            Publisher publisher = publisherRepository.GetPublisherByName(publisherName);
            if(publisher == null)
            {
                throw new Exception("The publisher does not exist!");
            }

            Book newBook = new Book { BookId = Guid.NewGuid(), Author = author, Description = description, Category = category, CoverPhotoPath = photoPath, Price = price, Publisher = publisher, Title = title, Quantity = quantity, Year = year, Type = type };
            bookRepository.Add(newBook);
        }

        public void Delete(Guid id)
        {
            var book = GetBookById(id);
            bookRepository.Delete(book);
        }

        public List<Book> GetAllBooks()
        {
            List<Book> books = bookRepository.GetAll();
            foreach(Book iBook in books)
            {
                iBook.Author = authorRepository.GetById(iBook.AuthorId);
                iBook.Category = categoryRepository.GetById(iBook.CategoryId);
                iBook.Type = typeRepository.GetById(iBook.ProductTypeId);
                iBook.Publisher = publisherRepository.GetById(iBook.PublisherId);
            }

            return books;
        }

        public Book GetBookById(Guid id)
        {
            Book iBook = bookRepository.GetById(id);
            if(iBook == null)
            {
                throw new Exception("This book does not exist!");
            }

            iBook.Author = authorRepository.GetById(iBook.AuthorId);
            iBook.Category = categoryRepository.GetById(iBook.CategoryId);
            iBook.Type = typeRepository.GetById(iBook.ProductTypeId);
            iBook.Publisher = publisherRepository.GetById(iBook.PublisherId);
            return iBook;
        }

        public List<Book> GetBooksByCategory(Guid id)
        {
            return bookRepository.GetBooksByCategory(id);
        }

        public List<Book> GetBooksByName(string name)
        {
            var searchedBooks = bookRepository.GetBookByName(name);
            if(searchedBooks == null)
            {
                throw new Exception("This book does not exist!");
            }
            return searchedBooks;
        }

        public List<Book> GetBooksByType(Guid id)
        {
            return bookRepository.GetBooksByType(id);
        }

        public Book UpdateBook(Guid bookId, string title, string description, double price, int quantity, string photoPath, int year, ProductTypeEnum typeName, CategoryEnum categoryName)
        {
            var oldBook = GetBookById(bookId);
            if(oldBook != null)
            {
                Author author = authorRepository.GetById(oldBook.AuthorId);
                if (author == null)
                {
                    throw new Exception("The author does not exist!");
                }

                ProductType type = typeRepository.GetProductTypeByName(typeName);
                if (type == null)
                {
                    throw new Exception("The product type does not exist!");
                }

                Category category = categoryRepository.GetCategoryByName(categoryName);
                if (category == null)
                {
                    throw new Exception("The category does not exist!");
                }

                Publisher publisher = publisherRepository.GetById(oldBook.PublisherId);
                if (publisher == null)
                {
                    throw new Exception("The publisher does not exist!");
                }

                oldBook.Author = author;
                oldBook.Title = title;
                oldBook.Category = category;
                oldBook.CoverPhotoPath = photoPath;
                oldBook.Description = description;
                oldBook.Price = price;
                oldBook.Publisher = publisher;
                oldBook.Quantity = quantity;
                oldBook.Type = type;
                oldBook.Year = year;
            }

            bookRepository.Update(oldBook);
            return oldBook;
        }
    }
}
