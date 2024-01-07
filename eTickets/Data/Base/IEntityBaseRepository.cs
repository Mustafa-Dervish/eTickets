﻿using eTickets.Models;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace eTickets.Data.Base
{
    public interface IEntityBaseRepository<T> where T:class, IEntityBase,new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsunc(int id, T entity);
        Task DeleteAsync(int id);
    }
}
