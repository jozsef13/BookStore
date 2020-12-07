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

        public T Add(T item)
        {
            var entity = context.Add<T>(item);
            context.SaveChanges();
            return entity.Entity;
        }

        public bool Delete(T item)
        {
            context.Remove<T>(item);
            context.SaveChanges();
            return true;
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList<T>();
        }

        public T GetById(Guid id)
        {
            return context.Find<T>(id);
        }

        public T Update(T item)
        {
            var entity = context.Update<T>(item);
            context.SaveChanges();
            return entity.Entity;
        }
    }
}
