using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryAndUnitOfWorkPattern.Entities
{
    [Table("Projeler")]
    public class Proje : BaseEntity
    {
        public Proje()
        {
            this.Personeller = new HashSet<Personel>();
        }
        public int Id { get; set; }
        public string İsim { get; set; }
        public ICollection<Personel> Personeller { get; set; }
    }
}
