using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryAndUnitOfWorkPattern.Business.Repositories.Abstract
{
    public interface IRepository<TEntity, Tkey> where TEntity : class
    {
        TEntity Getir(Tkey id);
        void Ekle(TEntity entity);
        void CokluEkle(IEnumerable<TEntity> entities);
        void Guncelle(TEntity entity);
        void Sil(Tkey id);
        IEnumerable<TEntity> Liste();
    }
}
