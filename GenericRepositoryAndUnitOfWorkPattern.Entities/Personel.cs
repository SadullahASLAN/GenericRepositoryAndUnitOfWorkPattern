using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryAndUnitOfWorkPattern.Entities
{
    [Table("Personeller")]
    public class Personel : BaseEntity
    {
        public Personel()
        {
            this.Projeler = new HashSet<Proje>();
        }
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public ICollection<Proje> Projeler { get; set; }
    }
}
