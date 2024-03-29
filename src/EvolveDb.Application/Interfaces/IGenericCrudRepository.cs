﻿using System.Collections.Generic;
using System.Threading.Tasks;
using EvolveDb.Domain;

namespace EvolveDb.Application.Interfaces
{
    public interface IGenericCrudRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        Task<TEntity> GetByIdAsync(TKey id);
        Task<IReadOnlyList<TEntity>> GetAllAsync();
        Task<TEntity> AddAsync(TEntity entity);
        Task<int> UpdateAsync(TEntity entity);
        Task<int> DeleteAsync(TKey id);
    }
}
