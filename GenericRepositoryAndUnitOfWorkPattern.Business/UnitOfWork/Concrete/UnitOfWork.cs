using GenericRepositoryAndUnitOfWorkPattern.Business.Repositories.Abstract;
using GenericRepositoryAndUnitOfWorkPattern.Business.Repositories.Concrete;
using GenericRepositoryAndUnitOfWorkPattern.Business.UnitOfWork.Abstract;
using GenericRepositoryAndUnitOfWorkPattern.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryAndUnitOfWorkPattern.Business.UnitOfWork.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private GenericRepositoryAndUnitOfWorkPatternDbContext _dbContext;
        public UnitOfWork(GenericRepositoryAndUnitOfWorkPatternDbContext dbContext)
        {
            _dbContext = dbContext;
            ProjeRepository = new ProjeRepository(_dbContext);
            PersonelRepository = new PersonelRepository(_dbContext);
        }
        public IProjeRepository ProjeRepository { get; private set; }

        public IPersonelRepository PersonelRepository { get; private set; }

        public int Complete()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
