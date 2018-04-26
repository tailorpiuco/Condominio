using Condominio.Models;
using Juris.Web;
using System;
using System.Collections.Generic;
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
                this.ViewBag.usuarioLogado = this.UsuarioLogado;
            }
        }        

        protected Usuario UsuarioLogado
        {
            get
            {
                return Session["Usuario"] as Usuario;
            }
        }
    }
}