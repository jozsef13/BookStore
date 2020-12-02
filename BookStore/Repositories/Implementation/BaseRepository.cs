using BookStore.Data;
using BookStore.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories.Implementation
{
    public class BaseRepository<T> : IRepository<T> where T:class, new()
    {
        protected readonly BookStoreDbContext context;

        public BaseRepository(BookStoreDbContext context)
        {
            this.context = context;
        }
    }
}
