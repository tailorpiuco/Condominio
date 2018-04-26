using Condominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Condominio.Web.Models
{
    public class MoradorViewModel
    {
        public MoradorViewModel()
        {
            this.Moradores = new List<Morador>();
        }

        public IList<Morador> Moradores { get; set; }
    }
}