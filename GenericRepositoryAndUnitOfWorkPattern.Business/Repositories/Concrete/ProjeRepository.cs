using GenericRepositoryAndUnitOfWorkPattern.Business.Repositories.Abstract;
using GenericRepositoryAndUnitOfWorkPattern.DataAccess;
using GenericRepositoryAndUnitOfWorkPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryAndUnitOfWorkPattern.Business.Repositories.Concrete
{
    public class ProjeRepository : Repository<Proje, int>, IProjeRepository
    {
        public ProjeRepository(GenericRepositoryAndUnitOfWorkPatternDbContext DbContext) : base(DbContext)
        {

        }
        public IEnumerable<Personel> ProjedekiPersonelleriGetir(int id)
        {
            return DbContext.Projeler.Find(id).Personeller.ToList();
        }

        public GenericRepositoryAndUnitOfWorkPatternDbContext DbContext { get { return _dbContext as GenericRepositoryAndUnitOfWorkPatternDbContext; } }
    }
}

