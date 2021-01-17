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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace BookStore.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly UserManager<BookStoreUser> _userManager;
        private readonly ICartService _cartService;
        private readonly IBookService _bookService;
        private readonly IOrderService _orderService;

        public OrdersController(UserManager<BookStoreUser> userManager, ICartService cartService, IBookService bookService, IOrderService orderService)
        {
            _userManager = userManager;
            _cartService = cartService;
            _bookService = bookService;
            _orderService = orderService;
        }

        // GET: Orders
        public async Task<IActionResult> UserIndex()
        {
            var user = await _userManager.GetUserAsync(User);
            List<Order> orders = _orderService.GetOrdersByUserId(user.Id);
            if(orders == null || !orders.Any())
            {
                TempData["Success"] = "You do not have any orders!";
                string referer = Request.Headers["Referer"].ToString();
                return Redirect(referer);
            }

            return View("Index", orders);
        }

        public IActionResult AdminIndex()
        {
            List<Order> orders = _orderService.GetAll();
            if (orders == null || !orders.Any())
            {
                TempData["Success"] = "There are no orders placed!";
                string referer = Request.Headers["Referer"].ToString();
                return Redirect(referer);
            }

            return View("Index", orders);
        }
        

        public async Task<IActionResult> PlaceOrder([FromForm] string paymentMethod)
        {
            var user = await _userManager.GetUserAsync(User);
            var cart = _cartService.GetCartByUserId(user.Id);
            if (cart == null)
            {
                return NotFound();
            }

            var order = _orderService.Create(cart, paymentMethod);
            if(order == null)
            {
                return NotFound();
            }

            return View("ThankYou");
        }

        public IActionResult Details(Guid id)
        {
            var order = _orderService.GetById(id);
            if(order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        public IActionResult OrderStatus(Guid id)
        {
            var order = _orderService.GetById(id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        public IActionResult Edit(Guid id)
        {
            var order = _orderService.GetById(id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        public IActionResult EditAction(Guid id, [FromForm] string orderStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var order = _orderService.GetById(id);
            if (order == null)
            {
                return NotFound();
            }
            _orderService.UpdateOrder(orderStatus, order);
            TempData["Success"] = "Order updated successfully!";
            return Redirect(Url.Action("AdminIndex", "Orders"));
        }
    }
}
