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
    public enum ActionForm { ADD, EDIT }

    public class ApartamentoController : BaseController
    {
        private const string SESSION_MORADORES = "ApartamentoMoradores";

        private IApartamentoService apartamentoService;
        private IMoradorService moradorService;

        public ApartamentoController(IApartamentoService apartamentoService, IMoradorService moradorService)
        {
            this.apartamentoService = apartamentoService;
            this.moradorService = moradorService;
        }
        
        public ActionResult Index()
        {
            return View(apartamentoService.GetAll(a => a.Moradores).ToList());
        }        

        [HttpGet]
        public ActionResult Add()
        {
            var model = new ApartamentoViewModel();
            model.TodosMoradores = moradorService.FindBy(m => m.ApartamentoId == null).OrderBy(m => m.Nome).ToList();

            Session[SESSION_MORADORES] = new List<Morador>();

            ViewBag.Title = "Adicionar Apartamento";

            return View("~/Views/Apartamento/Form.cshtml", model);
        }

        [HttpPost]
        public ActionResult Add(ApartamentoViewModel model)
        {            
            if (this.AddEditApartamento(model, ActionForm.ADD))
            {
                return RedirectToAction("Index");
            }
            
            model.TodosMoradores = moradorService.FindBy(m => m.ApartamentoId == null).OrderBy(m => m.Nome).Except(model.Moradores).ToList();

            ViewBag.Title = "Adicionar Apartamento";

            return View("~/Views/Apartamento/Form.cshtml", model);
        }

        [HttpPost]
        public JsonResult Delete (int id)
        {
            try
            {
                moradorService.RemoveMoradoresApartamento(id);
                apartamentoService.Delete(id);                

                return Json(new { sucesso = true, html = RenderPartialView("~/Views/Apartamento/Tabela.cshtml", apartamentoService.GetAll(a => a.Moradores).ToList()) });
            }
            catch(Exception ex)
            {
                return Json(new { sucesso = false, mensagem = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var entity = apartamentoService.FindBy(a => a.Id == id, p => p.Moradores).SingleOrDefault();

            Session[SESSION_MORADORES] = entity.Moradores.ToList();

            var model = new ApartamentoViewModel
            {
                Bloco = entity.Bloco,
                Id = entity.Id,
                Moradores = entity.Moradores,
                Numero = entity.Numero,      
                TodosMoradores = moradorService.FindBy(m => m.ApartamentoId == null).OrderBy(m => m.Nome).ToList()
            };

            ViewBag.Title = "Editar Apartamento";

            return View("~/Views/Apartamento/Form.cshtml", model);
        }

        [HttpPost]
        public ActionResult Edit(ApartamentoViewModel model)
        {
            if(this.AddEditApartamento(model, ActionForm.EDIT))
            {
                return RedirectToAction("Index");
            }

            ViewBag.Title = "Editar Apartamento";

            return View("~/Views/Apartamento/Form.cshtml", model);
        }

        [HttpPost]
        public JsonResult AddMorador(int id)
        {
            try
            {
                var morador = moradorService.FindBy(m => m.Id == id).SingleOrDefault();
                var listaMoradores = Session[SESSION_MORADORES] as List<Morador>;
                listaMoradores.Add(morador);
                Session[SESSION_MORADORES] = listaMoradores;
                
                var model = new ApartamentoViewModel();
                model.Moradores = listaMoradores;
                model.TodosMoradores = moradorService.FindBy(m => m.ApartamentoId == null).OrderBy(m => m.Nome).Except(listaMoradores).ToList();

                return Json(new { sucesso = true, html = RenderPartialView("~/Views/Apartamento/MoradoresPartial.cshtml", model) });
            }
            catch(Exception ex)
            {
                return Json(new { sucesso = false, mensagem = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult DeleteMorador(int id)
        {
            try
            {
                var listaMoradores = Session[SESSION_MORADORES] as List<Morador>;
                var morador = listaMoradores.Where(m => m.Id == id).SingleOrDefault();
                listaMoradores.Remove(morador);
                Session[SESSION_MORADORES] = listaMoradores;

                var model = new ApartamentoViewModel();
                model.Moradores = listaMoradores;
                model.TodosMoradores = moradorService.FindBy(m => m.ApartamentoId == null).OrderBy(m => m.Nome).Except(listaMoradores).ToList();

                return Json(new { sucesso = true, html = RenderPartialView("~/Views/Apartamento/MoradoresPartial.cshtml", model) });
            }
            catch (Exception ex)
            {
                return Json(new { sucesso = false, mensagem = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult MoradorResponsavel(int id)
        {
            try
            {
                var listaMoradores = Session[SESSION_MORADORES] as List<Morador>;                
                var morador = listaMoradores.Where(m => m.Id == id).SingleOrDefault();
                listaMoradores.Remove(morador);
                listaMoradores.ForEach(l => l.Responsavel = false);

                morador.Responsavel = true;
                listaMoradores.Add(morador);

                Session[SESSION_MORADORES] = listaMoradores;

                return Json(new { sucesso = true });
            }
            catch(Exception ex)
            {
                return Json(new { sucesso = false, mensagem = ex.Message });
            }
        }

        private bool AddEditApartamento(ApartamentoViewModel model, ActionForm action)
        {
            bool isValidMorador = true;
            model.Moradores = Session[SESSION_MORADORES] as List<Morador>;

            if (model.Moradores.Count == 0)
            {
                ModelState.AddModelError("Moradores", "O Apartamento deve ter ao menos 1 morador.");
                isValidMorador = false;
            }

            if (!model.Moradores.Any(m => m.Responsavel))
            {
                ModelState.AddModelError("Moradores", "Algum morador precisa ser o responsável pelo Apartamento.");
                isValidMorador = false;
            }

            if (ModelState.IsValid && isValidMorador)
            {
                Apartamento entity = new Apartamento
                {
                    Bloco = model.Bloco,
                    Numero = model.Numero
                };

                switch (action)
                {
                    case ActionForm.ADD:                        
                        entity = apartamentoService.Insert(entity);
                        break;
                    case ActionForm.EDIT:
                        entity.Id = model.Id.Value;
                        apartamentoService.Update(entity);
                        moradorService.RemoveMoradoresApartamento(entity.Id);
                        break;
                }

                foreach (var morador in model.Moradores)
                {
                    morador.ApartamentoId = entity.Id;
                    moradorService.Update(morador);
                }

                return true;
            }

            return false;
        }
    }
}