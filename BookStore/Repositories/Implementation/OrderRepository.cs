using BookStore.Data;
using BookStore.Models;
using BookStore.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories.Implementation
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        private readonly IBookRepository bookRepository;

        public OrderRepository(BookStoreDbContext context, IBookRepository bookRepository) : base(context)
        {
            this.bookRepository = bookRepository;
        }

        public List<Order> GetByUserId(string id)
        {
            List<Order> orders = context.Orders.Where(a => a.UserName == id).ToList();
            if (orders != null && orders.Any())
            {
                foreach(Order order in orders)
                {
                    ICollection<OrderBook> orderBooks = context.OrderBooks.Where(cb => cb.OrderId == order.OrderId).ToList();
                    foreach (OrderBook orderBook in orderBooks)
                    {
                        var iBook = bookRepository.GetById(orderBook.BookId);
                        orderBook.Book = iBook;
                    }
                    order.OrderBooks = orderBooks;
                }
            }
            return orders;
        }

        public List<Order> GetAllOrders()
        {
            List<Order> orders = GetAll();
            foreach(Order order in orders)
            {
                var user = context.Users.SingleOrDefault(a => a.Id == order.UserName);
                order.User = user;
                ICollection<OrderBook> orderBooks = context.OrderBooks.Where(cb => cb.OrderId == order.OrderId).ToList();
                foreach (OrderBook orderBook in orderBooks)
                {
                    var iBook = bookRepository.GetById(orderBook.BookId);
                    orderBook.Book = iBook;
                }
                order.OrderBooks = orderBooks;
            }
            return orders;
        }

        public Order GetOrderById(Guid id)
        {
            Order order = GetById(id);
            var user = context.Users.SingleOrDefault(a => a.Id == order.UserName);
            order.User = user;
            ICollection<OrderBook> orderBooks = context.OrderBooks.Where(cb => cb.OrderId == order.OrderId).ToList();
            foreach (OrderBook orderBook in orderBooks)
            {
                var iBook = bookRepository.GetById(orderBook.BookId);
                orderBook.Book = iBook;
            }
            order.OrderBooks = orderBooks;

            return order;
        }
    }
}
