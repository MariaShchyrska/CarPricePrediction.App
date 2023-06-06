using CarPricePrediction.Core.Context;
using CarPricePrediction.Core.Entities;

namespace CarPricePrediction.Repositories
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : BaseEntity
    {
        protected CarsContext ctx;

        public Repository(CarsContext ctx)
        {
            this.ctx = ctx;
        }

        public void Create(TEntity entity)
        {
            ctx.Set<TEntity>().Add(entity);
            Save();
        }

        public void Delete(TEntity entity)
        {
            ctx.Set<TEntity>().Remove(entity);
            Save();
        }

        public TEntity Get(TKey key)
        {
            return ctx.Set<TEntity>().Find(key);
        }

        public IEnumerable<TEntity> GetAll() => ctx.Set<TEntity>().ToList();

        public void Save()
        {
            ctx.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            ctx.Set<TEntity>().Update(entity);
            Save();
        }
    }
}