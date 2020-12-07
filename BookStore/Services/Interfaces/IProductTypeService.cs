using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Interfaces
{
    public interface IProductTypeService
    {
        List<ProductType> GetAllProductTypes();
    }
}
