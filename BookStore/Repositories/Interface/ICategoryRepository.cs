﻿using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories.Interface
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetCategoryByName(CategoryEnum categoryName);
    }
}
