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
            model.Moradores = moradorService.GetAll().ToList();

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

            foreach (ModelState modelState in ViewData.ModelState.Values)
            {
                foreach (ModelError error in modelState.Errors)
                {
                    string s = error.ErrorMessage;
                }
            }

            if (ModelState.IsValid)
            {
                moradorService.Insert(model);
                RedirectToAction("Index");
            }            

            return View("~/Views/Morador/Form.cshtml", model);
        }

        // GET: Morador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Morador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Morador/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Morador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Morador/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Morador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Morador/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
