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
    public class PersonelRepository : Repository<Personel, int>, IPersonelRepository
    {
        public PersonelRepository(GenericRepositoryAndUnitOfWorkPatternDbContext DbContext) : base(DbContext)
        {

        }
        public IEnumerable<Proje> PersonelinBulunduguProjeleriGetir(int id)
        {
            return DbContext.Personeller.Find(id).Projeler.ToList();
        }
        public GenericRepositoryAndUnitOfWorkPatternDbContext DbContext { get { return _dbContext as GenericRepositoryAndUnitOfWorkPatternDbContext; } }
    }
}
