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
using BookStore.Services.Interfaces;

namespace BookStore.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly IAuthorService authorService;
        public AuthorsController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Index()
        {
            List<Author> authors = authorService.GetAllAuthors();
            return View(authors);
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Edit(Guid id)
        {
            var author = authorService.GetAuthorById(id);
            return View(author);
        }

        public IActionResult EditSave([FromForm] Author model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            authorService.Update(model);
            TempData["Success"] = "Author " + model.FirstName + " " + model.LastName + " updated successfully!";
            return Redirect(Url.Action("Index", "Books"));
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public IActionResult Create([FromForm] Author model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            authorService.CreateAuthor(model);
            TempData["Success"] = "Author " + model.FirstName + " " + model.LastName + " added successfully!";
            return Redirect(Url.Action("Index", "Books"));
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = authorService.GetAuthorById(id);
            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult DeleteConfirmed(Guid authorId)
        {
            if (authorId == null)
            {
                return NotFound();
            }

            authorService.Delete(authorId);
            TempData["Success"] = "Author deleted successfully!";
            return Redirect(Url.Action("Index", "Books"));
        }
    }
}
