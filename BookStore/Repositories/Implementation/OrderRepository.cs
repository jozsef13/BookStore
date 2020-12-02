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
        public OrderRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}
