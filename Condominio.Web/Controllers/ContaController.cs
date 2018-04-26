using System.Web.Mvc;
using System;
using Condominio.Web.Models;
using Condominio.Models;
using Microsoft.AspNet.Identity.Owin;
using Condominio.Business.Interfaces;

namespace Condominio.Web.Controllers
{
    public class ContaController : Controller
    {
        private IUsuarioService _usuarioService = null;

        public ContaController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]       
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = SignInAsync(model.Usuario, model.Senha);

            switch (result)
            {
                case SignInStatus.Success:
                    Usuario user = Session["Usuario"] as Usuario;
                    return Redireciona(returnUrl);                  
                case SignInStatus.LockedOut:
                    ModelState.AddModelError("", "Usuário inativo.");
                    return View(model);
                case SignInStatus.RequiresVerification:
                case SignInStatus.Failure:
                default:
                    ModelState.AddModelError("", "Login inválido ou inexistente.");
                    return View(model);
            }
        }

        public SignInStatus SignInAsync(string login, string senha)
        {
            Usuario usuario = null;

            try
            {
                usuario = new Usuario()
                {
                    Login = login,
                    Senha = senha
                };

                usuario = _usuarioService.RetornaUsuario(usuario);                                
            }
            catch (Exception ex)
            {                
                return SignInStatus.Failure;
            }

            if (usuario == null)
            {
                return SignInStatus.Failure;
            }
            
            Session["Usuario"] = usuario;

            return SignInStatus.Success;
        }

        private ActionResult Redireciona(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}