using Condominio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            this.Moradores = new List<Morador>();
        }

        public int? Id { get; set; }

        [Required]
        [Display(Name = "Número")]
        public int Numero { get; set; }

        [MaxLength(5)]        
        public string Bloco { get; set; }
        
        [Required]
        [Display(Name = "Responsável")]
        [Range(1, int.MaxValue, ErrorMessage = "O campo Responsável é obrigatório.")]
        public int ResponsavelId { get; set; }

        public IList<SelectListItem> ListaResponsaveis
        {
            get
            {
                var lista = new List<SelectListItem>();
                lista.Add(new SelectListItem { Value = "0", Text = "Selecione" });

                foreach(var m in this.Moradores)
                {
                    lista.Add(new SelectListItem { Text = m.Nome, Value = m.Id.ToString() });
                }

                return lista;
            }
        }

        public IList<Morador> Moradores { get; set; }

        public IList<Apartamento> Apartamentos { get; set; }
    }
}