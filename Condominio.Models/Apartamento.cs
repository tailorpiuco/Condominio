using Condominio.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Models
{
    [Table("apartamentos")]
    public class Apartamento : BaseEntity, IEntity
    {    
        public int Id { get; set; }
        
        public int Numero { get; set; }
        
        [MaxLength(5)]
        public string Bloco { get; set; }

        //[Required]
        //[ForeignKey("Responsavel")]
        //public int ResponsavelId { get; set; }
        //public virtual Morador Responsavel { get; set; }
            
        public ICollection<Morador> Moradores { get; set; }
    }
}
