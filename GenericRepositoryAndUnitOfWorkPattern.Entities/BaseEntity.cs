using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryAndUnitOfWorkPattern.Entities
{
   public class BaseEntity
    {
        public BaseEntity()
        {
            this.OlusturulmaTarihi = DateTime.Now;
        }
        public DateTime OlusturulmaTarihi { get; set; }
    }
}
