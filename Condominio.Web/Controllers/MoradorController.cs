using Condominio.Business.Interfaces;
using Condominio.Data.Interfaces;
using Condominio.Models;
using Condominio.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Condominio.Web.Controllers
{
    public class MoradorController : BaseController
    {
        private IMoradorService moradorService;        

        public MoradorController(IMoradorService moradorService)
        {
            this.moradorService = moradorService;            
        }
                
        public ActionResult Index()
        {
            var model = new MoradorViewModel();
            model.Moradores = moradorService.GetAll(m => m.Apartamento).ToList();

            return View(model);
        }

        [HttpGet]
        public ActionResult Add()
        {
            ViewBag.Title = "Adicionar Morador";
            return View("~/Views/Morador/Form.cshtml");
        }

        [HttpPost]
        public ActionResult Add(Morador model)
        {
            ViewBag.Title = "Adicionar Morador";

            if (ModelState.IsValid)
            {
                moradorService.Insert(model);
                return RedirectToAction("Index");
            }            

            return View("~/Views/Morador/Form.cshtml", model);
        }
        
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var entity = moradorService.FindBy(m => m.Id == id).SingleOrDefault();
            ViewBag.Title = "Editar Morador";
            return View("~/Views/Morador/Form.cshtml", entity);
        }
        
        [HttpPost]
        public ActionResult Edit(Morador model)
        {
            if (ModelState.IsValid)
            {
                moradorService.Update(model);
                return RedirectToAction("Index");
            }

            ViewBag.Title = "Editar Morador";

            return View("~/Views/Morador/Form.cshtml", model);
        }
        
        [HttpPost]
        public JsonResult Delete(int id)
        {
            try
            {
                moradorService.Delete(id);

                var model = new MoradorViewModel
                {
                    Moradores = moradorService.GetAll().ToList()
                };

                return Json(new { sucesso = true, html = RenderPartialView("~/Views/Morador/Tabela.cshtml", model) });
            }
            catch (Exception ex)
            {
                return Json(new { sucesso = false, mensagem = ex.Message });
            }
        }                
    }
}
