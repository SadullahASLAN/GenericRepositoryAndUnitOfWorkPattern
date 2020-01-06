using GenericRepositoryAndUnitOfWorkPattern.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryAndUnitOfWorkPattern.DataAccess
{
    public class GenericRepositoryAndUnitOfWorkPatternDbContext : DbContext
    {
        public GenericRepositoryAndUnitOfWorkPatternDbContext() : base("Server=.; Database=GenericRepositoryAndUnitOfWorkPatternDb; Integrated Security=True;")
        {

        }

        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Proje> Projeler { get; set; }
    }
}
