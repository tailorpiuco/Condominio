using Condominio.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Models
{
    public class Usuario : BaseEntity, IEntity
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Login { get; set; }

        [MaxLength(50)]
        public string Senha { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }

        public DateTime DataRegistro { get; set; }
    }
}
