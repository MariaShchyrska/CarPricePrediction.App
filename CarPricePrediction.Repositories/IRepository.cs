using System;
using System.Collections.Generic;
using CarPricePrediction.Core.Entities;

namespace CarPricePrediction.Repositories
{
    public interface IRepository<TEntity, TKey>
        where TEntity : BaseEntity
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(TKey key);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Save();
    }
}