﻿using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategories();
        Task<Category> GetById(int? Id);
        Task<Category> Create(Category category);
        Task<Category> Update(Category category);
        Task<Category> Remove (Category category);
    }
}
