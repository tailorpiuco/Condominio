using Condominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Juris.Web
{
    public class AuthorizeUser : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var usuario = httpContext.Session != null ? httpContext.Session["Usuario"] as Usuario : null;

            if (usuario == null)
            {
                if (httpContext.Request.IsAjaxRequest())
                {
                    httpContext.Response.Write(new RedirectResult("~/Conta/Login").Url);

                    httpContext.Response.End();
                }                

                return false;
            }

            return true;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session == null || filterContext.HttpContext.Session["Usuario"] == null)
            {
                if (filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    filterContext.HttpContext.Response.Write(new RedirectResult("~/Conta/Login").Url);

                    filterContext.HttpContext.Response.End();
                }
                else
                {
                    var query = filterContext.HttpContext.Request.Url.PathAndQuery;
                    if (query != "/")
                        filterContext.Result = new RedirectResult("~/Conta/Login");
                    else
                        filterContext.HttpContext.Response.Redirect("~/Conta/Login");
                }
            }
            else
            {
                if (filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    filterContext.HttpContext.Response.Write(new RedirectResult("~/Conta/NaoAutorizado").Url);

                    filterContext.HttpContext.Response.End();
                }
                else
                {
                    var query = filterContext.HttpContext.Request.Url.PathAndQuery;
                    if (query != "/")
                        filterContext.Result = new RedirectResult("~/Conta/NaoAutorizado");
                    else
                        filterContext.HttpContext.Response.Redirect("~/Conta/NaoAutorizado");
                }
            }

            base.HandleUnauthorizedRequest(filterContext);
        }
    }
}