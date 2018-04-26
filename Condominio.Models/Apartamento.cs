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
    [Table("Apartamentos")]
    public class Apartamento : BaseEntity, IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Numero { get; set; }
        
        [MaxLength(5)]
        public string Bloco { get; set; }

        [Required]
        [ForeignKey("Responsavel")]
        public int ResponsavelId { get; set; }
        public virtual Morador Responsavel { get; set; }

        public virtual IList<Morador> Moradores { get; set; }

    }
}
