using Condominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Condominio.Web.Models
{
    public class ApartamentoViewModel
    {
        public ApartamentoViewModel()
        {
            this.Apartamentos = new List<Apartamento>();
        }

        public int Numero { get; set; }

        public string Bloco { get; set; }

        public int ResponsavelId { get; set; }

        public IList<SelectListItem> ListaResponsaveis
        {
            get
            {
                return (from m in this.Moradores
                        select new SelectListItem
                        {
                            Text = m.Nome,
                            Value = m.Id.ToString()
                        }).ToList();
            }
        }

        public IList<Morador> Moradores { get; set; }

        public IList<Apartamento> Apartamentos { get; set; }
    }
}