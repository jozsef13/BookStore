using BookStore.Models;
using BookStore.Repositories.Interface;
using BookStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;
        private readonly ICartRepository cartRepository;

        public OrderService(IOrderRepository orderRepository, ICartRepository cartRepository)
        {
            this.orderRepository = orderRepository;
            this.cartRepository = cartRepository;
        }

        public Order Create(Cart cart, string paymentMethod)
        {
            Order.PaymentMethods payment = (Order.PaymentMethods)Enum.Parse(typeof(Order.PaymentMethods), paymentMethod);
            ICollection<OrderBook> orderBooks = new List<OrderBook>();
            ICollection<CartBook> cartBooks = cart.CartBooks;
            foreach(CartBook cartBook in cartBooks)
            {
                OrderBook orderBook = new OrderBook { Book = cartBook.Book, BookId = cartBook.BookId, BookQuantity = cartBook.BookQuantity };
                orderBooks.Add(orderBook);
            }

            Order order = new Order
            {
                OrderId = Guid.NewGuid(),
                OrderStatus = Order.Status.Placed,
                ShippingDate = DateTime.Today.AddDays(3),
                TotalPrice = cart.TotalPrice,
                User = cart.User,
                OrderBooks = orderBooks,
                PaymentMethod = payment
            };

            orderRepository.Add(order);
            cartRepository.Delete(cart);
            return order;
        }

        public List<Order> GetAll()
        {
            return orderRepository.GetAllOrders();
        }

        public Order GetById(Guid id)
        {
            return orderRepository.GetOrderById(id);
        }

        public List<Order> GetOrdersByUserId(string id)
        {
            return orderRepository.GetByUserId(id);
        }

        public Order UpdateOrder(string orderStatus, Order order)
        {
            var newOrder = order;
            newOrder.OrderStatus = (Order.Status)Enum.Parse(typeof(Order.Status), orderStatus);
            orderRepository.Update(newOrder);
            return order;
        }
    }
}
