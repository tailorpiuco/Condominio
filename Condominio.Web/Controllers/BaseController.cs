using Condominio.Models;
using Juris.Web;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Condominio.Web.Controllers
{
    [AuthorizeUser]
    public class BaseController : Controller
    {        
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            if (ViewBag.usuarioLogado == null)
            {
                ViewBag.usuarioLogado = this.UsuarioLogado;
            }
        }        

        protected Usuario UsuarioLogado
        {
            get
            {
                return Session["Usuario"] as Usuario;
            }
        }

        protected string RenderPartialView(string viewName, object model)
        {
            ViewData.Model = model;

            using (StringWriter writer = new StringWriter())
            {
                ViewEngineResult viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                ViewContext viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, writer);
                viewResult.View.Render(viewContext, writer);

                return writer.GetStringBuilder().ToString();
            }
        }
    }
}