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
        public Morador()
        {
            this.Responsavel = false;
        }

        [Key]        
        public int Id { get; set; }        

        [Required]
        public string Nome { get; set; }       
        
        [Required]
        [Display(Name = "Data Nascimento")]
        public DateTime DataNascimento { get; set; }
        
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        public int? ApartamentoId { get; set; }    
        public Apartamento Apartamento { get; set; }

        public bool Responsavel { get; set; }

        //public virtual ICollection<Apartamento> ApartamentosAdministrados { get; set; }        
    }
}
