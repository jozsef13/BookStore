using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Interfaces
{
    public interface IOrderService
    {
        Order Create(Cart cart, string paymentMethod);
        List<Order> GetOrdersByUserId(string id);
        List<Order> GetAll();
        Order GetById(Guid id);
        Order UpdateOrder(string orderStatus, Order order);
    }
}
