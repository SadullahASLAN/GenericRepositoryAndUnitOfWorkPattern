using GenericRepositoryAndUnitOfWorkPattern.Business.Repositories.Abstract;
using GenericRepositoryAndUnitOfWorkPattern.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryAndUnitOfWorkPattern.Business.Repositories.Concrete
{
    public class Repository<TEntity, Tkey> : IRepository<TEntity, Tkey> where TEntity : class
    {
        protected DbContext _dbContext;
        private DbSet<TEntity> _dbSet;
        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }
        public void Ekle(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Guncelle(TEntity entity)
        {
            _dbContext.Entry(entity).CurrentValues.SetValues(entity);
        }

        public IEnumerable<TEntity> Liste()
        {
            return _dbSet.ToList();
        }

        public void Sil(Tkey id)
        {
            _dbSet.Remove(Getir(id));
        }

        public TEntity Getir(Tkey id)
        {
            return _dbSet.Find(id);
        }

        public void CokluEkle(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }
    }
}
