using Condominio.Business.Interfaces;
using Condominio.Models;
using Condominio.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
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
            model.Apartamentos = apartamentoService.GetAll(a => a.Moradores).ToList();

            return View(model);
        }        

        [HttpGet]
        public ActionResult Add()
        {
            var model = new ApartamentoViewModel();
            model.Moradores = moradorService.GetAll().ToList();

            ViewBag.Title = "Adicionar Apartamento";

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
                    //ResponsavelId = model.ResponsavelId
                };

                apartamentoService.Insert(entity);
                return RedirectToAction("Index");
            }

            model.Moradores = moradorService.GetAll().ToList();
            ViewBag.Title = "Adicionar Apartamento";

            return View("~/Views/Apartamento/Form.cshtml", model);
        }

        [HttpPost]
        public JsonResult Delete (int id)
        {
            try
            {
                apartamentoService.Delete(id);

                var model = new ApartamentoViewModel();
                model.Apartamentos = apartamentoService.GetAll().ToList();

                return Json(new { sucesso = true, html = RenderPartialView("~/Views/Apartamento/Tabela.cshtml", model) });
            }
            catch(Exception ex)
            {
                return Json(new { sucesso = false, mensagem = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var entity = apartamentoService.FindBy(a => a.Id == id).SingleOrDefault();
            var moradores = moradorService.GetAll().ToList();
            var model = new ApartamentoViewModel
            {
                Bloco = entity.Bloco,
                Numero = entity.Numero,
                //ResponsavelId = entity.ResponsavelId,
                Moradores = moradores
            };

            ViewBag.Title = "Editar Apartamento";

            return View("~/Views/Apartamento/Form.cshtml", model);
        }

        [HttpPost]
        public ActionResult Edit(ApartamentoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = new Apartamento
                {
                    Bloco = model.Bloco,
                    Id = model.Id.Value,
                    //ResponsavelId = model.ResponsavelId,
                    Numero = model.Numero                    
                };

                apartamentoService.Update(entity);
                return RedirectToAction("Index");
            }

            ViewBag.Title = "Editar Apartamento";

            return View("~/Views/Apartamento/Form.cshtml", model);
        }
    }
}