using GenericRepositoryAndUnitOfWorkPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryAndUnitOfWorkPattern.Business.Repositories.Abstract
{
    public interface IProjeRepository : IRepository<Proje, int>
    {
        IEnumerable<Personel> ProjedekiPersonelleriGetir(int id);
    }
}
