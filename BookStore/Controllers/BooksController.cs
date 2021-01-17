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
using Microsoft.AspNetCore.Authorization;
using System.IO;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService authorService;
        private readonly ICategoryService categoryService;
        private readonly IPublisherService publisherService;
        private readonly IProductTypeService productTypeService;
        private readonly IWebHostEnvironment _environment;

        public BooksController(IBookService bookService, IAuthorService authorService, ICategoryService categoryService, IPublisherService publisherService, IProductTypeService productTypeService, IWebHostEnvironment environment)
        {
            _bookService = bookService;
            this.authorService = authorService;
            this.categoryService = categoryService;
            this.publisherService = publisherService;
            this.productTypeService = productTypeService;
            _environment = environment;
        }

        // GET: Books
        public ActionResult Index()
        {
            var model = new BooksViewModel();
            List<Book> books = _bookService.GetAllBooks();
            List<ProductType> productTypes = productTypeService.GetAllProductTypes();
            List<Category> categories = categoryService.GetAllCategories();

            model.Books = books;
            model.Categories = categories;
            model.ProductTypes = productTypes;

            return View("Index", model);
        }

        [HttpGet]
        public IActionResult Details(Guid id)
        {
            var sBook = _bookService.GetBookById(id);
            return View(sBook);
        }

        // GET: Books/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            var model = new CreateBookViewModel();
            List<Author> authors = authorService.GetAllAuthors();
            List<ProductType> productTypes = productTypeService.GetAllProductTypes();
            List<Category> categories = categoryService.GetAllCategories();
            List<Publisher> publishers = publisherService.GetAllPublishers();

            model.Authors = authors;
            model.Categories = categories;
            model.Types = productTypes;
            model.Publishers = publishers;
            model.Book = new Book();

            return View("Create", model);
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public IActionResult Create([FromForm]CreateBookViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            var newFileName = string.Empty;
            if (HttpContext.Request.Form.Files != null)
            {
                var fileName = string.Empty;
                string pathDb = string.Empty;

                var files = HttpContext.Request.Form.Files;
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                        var myUniqueFileName = Convert.ToString(Guid.NewGuid());
                        var fileExtension = Path.GetExtension(fileName);
                        newFileName = myUniqueFileName + fileExtension;
                        fileName = Path.Combine(_environment.WebRootPath, "images") + $@"\{newFileName}";
                        pathDb = "/images/" + newFileName;

                        using (FileStream fs = System.IO.File.Create(fileName))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                            model.Book.CoverPhotoPath = pathDb;
                        }
                    }
                }
            }
            var name = model.Book.Author.FirstName;
            model.Book.Author.FirstName = name.Split(',')[0].Trim();
            model.Book.Author.LastName = name.Split(',')[1].Trim();
            _bookService.CreateBook(model.Book.Title, model.Book.Description, model.Book.Price, model.Book.Quantity, model.Book.CoverPhotoPath,
                model.Book.Year, model.Book.Type.Name, model.Book.Author.FirstName, model.Book.Author.LastName, model.Book.Category.Name, model.Book.Publisher.Name);
            TempData["Success"] = "Book " + model.Book.Title + " added successfully!";
            return Redirect(Url.Action("Index", "Books"));
        }

        // GET: Books/Edit/5
        [Authorize(Roles = "Administrator")]
        public IActionResult Edit(Guid id)
        {
            var model = new CreateBookViewModel();
            List<Author> authors = authorService.GetAllAuthors();
            List<ProductType> productTypes = productTypeService.GetAllProductTypes();
            List<Category> categories = categoryService.GetAllCategories();
            List<Publisher> publishers = publisherService.GetAllPublishers();

            if(id == null)
            {
                return NotFound();
            }

            var iBook = _bookService.GetBookById(id);
            if(iBook == null)
            {
                return NotFound();
            }

            model.Authors = authors;
            model.Categories = categories;
            model.Types = productTypes;
            model.Publishers = publishers;
            model.Book = iBook;

            return View(model);
        }

        // POST: Books/Edit/5
        [Authorize(Roles = "Administrator")]
        public IActionResult EditSave([FromForm] CreateBookViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var newFileName = string.Empty;
            if (HttpContext.Request.Form.Files != null)
            {
                var fileName = string.Empty;
                string pathDb = string.Empty;

                var files = HttpContext.Request.Form.Files;
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                        var myUniqueFileName = Convert.ToString(Guid.NewGuid());
                        var fileExtension = Path.GetExtension(fileName);
                        newFileName = myUniqueFileName + fileExtension;
                        fileName = Path.Combine(_environment.WebRootPath, "images") + $@"\{newFileName}";
                        pathDb = "/images/" + newFileName;

                        using (FileStream fs = System.IO.File.Create(fileName))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                            model.Book.CoverPhotoPath = pathDb;
                        }
                    }
                }
            }
            _bookService.UpdateBook(model.Book.BookId, model.Book.Title, model.Book.Description, model.Book.Price, model.Book.Quantity, model.Book.CoverPhotoPath,
                model.Book.Year, model.Book.Type.Name, model.Book.Category.Name);
            TempData["Success"] = "Book " + model.Book.Title + " updated successfully!";
            return Redirect(Url.Action("Index", "Books"));
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = _bookService.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult DeleteConfirmed(Guid bookId)
        {
            if (bookId == null)
            {
                return NotFound();
            }

            _bookService.Delete(bookId);
            TempData["Success"] = "Book deleted successfully!";
            return Redirect(Url.Action("Index", "Books"));
        }

        public IActionResult Search(string name)
        {
            var model = new BooksViewModel();
            List<Book> books = _bookService.GetBooksByName(name);
            List<ProductType> productTypes = productTypeService.GetAllProductTypes();
            List<Category> categories = categoryService.GetAllCategories();

            model.Books = books;
            model.Categories = categories;
            model.ProductTypes = productTypes;

            return View("Index", model);
        }

        public IActionResult OrderAsc()
        {
            var model = new BooksViewModel();
            List<Book> books = _bookService.GetAllBooks().OrderBy(x => x.Title).ToList();
            List<ProductType> productTypes = productTypeService.GetAllProductTypes();
            List<Category> categories = categoryService.GetAllCategories();

            model.Books = books;
            model.Categories = categories;
            model.ProductTypes = productTypes;

            return View("Index", model);
        }

        public IActionResult OrderDesc()
        {
            var model = new BooksViewModel();
            List<Book> books = _bookService.GetAllBooks().OrderByDescending(x => x.Title).ToList();
            List<ProductType> productTypes = productTypeService.GetAllProductTypes();
            List<Category> categories = categoryService.GetAllCategories();

            model.Books = books;
            model.Categories = categories;
            model.ProductTypes = productTypes;

            return View("Index", model);
        }

        public IActionResult OrderPriceAsc()
        {
            var model = new BooksViewModel();
            List<Book> books = _bookService.GetAllBooks().OrderBy(x => x.Price).ToList();
            List<ProductType> productTypes = productTypeService.GetAllProductTypes();
            List<Category> categories = categoryService.GetAllCategories();

            model.Books = books;
            model.Categories = categories;
            model.ProductTypes = productTypes;

            return View("Index", model);
        }

        public IActionResult OrderPriceDesc()
        {
            var model = new BooksViewModel();
            List<Book> books = _bookService.GetAllBooks().OrderByDescending(x => x.Price).ToList();
            List<ProductType> productTypes = productTypeService.GetAllProductTypes();
            List<Category> categories = categoryService.GetAllCategories();

            model.Books = books;
            model.Categories = categories;
            model.ProductTypes = productTypes;

            return View("Index", model);
        }

        [HttpGet]
        public IActionResult GetByType(Guid id)
        {
            var model = new BooksViewModel();
            List<Book> books = _bookService.GetBooksByType(id);
            List<ProductType> productTypes = productTypeService.GetAllProductTypes();
            List<Category> categories = categoryService.GetAllCategories();

            model.Books = books;
            model.Categories = categories;
            model.ProductTypes = productTypes;

            return View("Index", model);
        }

        [HttpGet]
        public IActionResult GetByCategory(Guid id)
        {
            var model = new BooksViewModel();
            List<Book> books = _bookService.GetBooksByCategory(id);
            List<ProductType> productTypes = productTypeService.GetAllProductTypes();
            List<Category> categories = categoryService.GetAllCategories();

            model.Books = books;
            model.Categories = categories;
            model.ProductTypes = productTypes;

            return View("Index", model);
        }
    }
}
