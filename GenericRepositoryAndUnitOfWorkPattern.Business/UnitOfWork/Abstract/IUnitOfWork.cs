using GenericRepositoryAndUnitOfWorkPattern.Business.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryAndUnitOfWorkPattern.Business.UnitOfWork.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IProjeRepository ProjeRepository { get; }
        IPersonelRepository PersonelRepository { get; }
        int Complete();
    }
}
