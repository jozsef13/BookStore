using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories.Interface
{
    public interface IOrderRepository : IRepository<Order>
    {
        List<Order> GetByUserId(string id);
        List<Order> GetAllOrders();
        Order GetOrderById(Guid id);
    }
}
