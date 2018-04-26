using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Condominio.Web.Models
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Nome { get; set; }                
    }
}