using BookStore.Models;
using BookStore.Repositories.Interface;
using BookStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Implementations
{
    public class ProductTypeService : IProductTypeService
    {
        private IProductTypeRepository productTypeRepository;
        public ProductTypeService(IProductTypeRepository productTypeRepository)
        {
            this.productTypeRepository = productTypeRepository;
        }

        public List<ProductType> GetAllProductTypes()
        {
            return productTypeRepository.GetAll();
        }
    }
}
