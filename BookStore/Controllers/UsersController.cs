using BookStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class UsersController : Controller
    {
        private readonly UserManager<BookStoreUser> _userManager;
        private readonly SignInManager<BookStoreUser> _signInManager;

        public UsersController(UserManager<BookStoreUser> userManager, SignInManager<BookStoreUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Ban(Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            
            if(user != null)
            {
                await _userManager.SetLockoutEnabledAsync(user, true);
                await _userManager.SetLockoutEndDateAsync(user, DateTime.Today.AddDays(30));
            }

            TempData["Success"] = "The user was banned!";
            string referer = Request.Headers["Referer"].ToString();
            return Redirect(referer);
        }
    }
}
