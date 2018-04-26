using Condominio.Business.Interfaces;
using Condominio.Models;
using Condominio.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Condominio.Web.Controllers
{
    public class ApartamentoController : BaseController
    {
        private IApartamentoService apartamentoService;
        private IMoradorService moradorService;

        public ApartamentoController(IApartamentoService apartamentoService, IMoradorService moradorService)
        {
            this.apartamentoService = apartamentoService;
            this.moradorService = moradorService;
        }

        public ActionResult Index()
        {
            var model = new ApartamentoViewModel();
            model.Apartamentos = apartamentoService.GetAll().ToList();

            return View(model);
        }

        [HttpGet]
        public ActionResult Add()
        {
            var model = new ApartamentoViewModel();
            model.Moradores = moradorService.GetAll().ToList();

            return View("~/Views/Apartamento/Form.cshtml", model);
        }

        [HttpPost]
        public ActionResult Add(ApartamentoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = new Apartamento
                {
                    Bloco = model.Bloco,
                    Numero = model.Numero,
                    ResponsavelId = model.ResponsavelId
                };

                apartamentoService.Insert(entity);
                RedirectToAction("Index");
            }

            return View("~/Views/Apartamento/Form.cshtml", model);
        }
    }
}