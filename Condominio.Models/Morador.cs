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
    [Table("moradores")]
    public class Morador : BaseEntity, IEntity
    {
        [Key]        
        public int Id { get; set; }        

        public string Nome { get; set; }       
        
        public DateTime DataNascimento { get; set; }
        
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        public string CPF { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        public int? ApartamentoId { get; set; }    
        public Apartamento Apartamento { get; set; }

        //public virtual ICollection<Apartamento> ApartamentosAdministrados { get; set; }        
    }
}
