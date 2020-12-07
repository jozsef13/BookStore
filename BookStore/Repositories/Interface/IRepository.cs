using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories.Interface
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T Add(T item);
        T Update(T item);
        bool Delete(T item);
        T GetById(Guid id);
    }
}
