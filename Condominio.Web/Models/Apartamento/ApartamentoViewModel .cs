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
            this.Moradores = new List<Morador>();
        }

        public int? Id { get; set; }

        [Required]
        [Display(Name = "Número")]
        public int Numero { get; set; }

        [MaxLength(5)]        
        public string Bloco { get; set; }                

        [Required]
        public ICollection<Morador> Moradores { get; set; }    
        public ICollection<Morador> TodosMoradores { get; set; }

        public IList<SelectListItem> MoradoresDropDownList
        {
            get
            {
                var lista = new List<SelectListItem>();
                lista.Add(new SelectListItem { Text = "Selecione", Value = "0" });

                foreach(var m in TodosMoradores)
                {
                    lista.Add(new SelectListItem
                    {
                        Text = m.Nome,
                        Value = m.Id.ToString()
                    });
                }

                return lista;
            }
        }
    }
}