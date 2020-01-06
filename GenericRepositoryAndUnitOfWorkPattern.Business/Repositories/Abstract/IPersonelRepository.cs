using GenericRepositoryAndUnitOfWorkPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryAndUnitOfWorkPattern.Business.Repositories.Abstract
{
    public interface IPersonelRepository : IRepository<Personel, int>
    {
        IEnumerable<Proje> PersonelinBulunduguProjeleriGetir(int id);
    }
}
