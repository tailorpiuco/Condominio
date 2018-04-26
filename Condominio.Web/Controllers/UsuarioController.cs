using Condominio.Business.Interfaces;
using Condominio.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Condominio.Web.Controllers
{
    public class UsuarioController : BaseController
    {
        private IUsuarioService usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        public ActionResult Index()
        {
            return CarregaUsuarios();
        }

        private ActionResult CarregaUsuarios()
        {
            IList<UsuarioViewModel> listaUsuariosViewModel = new List<UsuarioViewModel>();

            //listaUsuariosViewModel = (from usuario in usuarioService.GetAll(c => c.Cidade).ToList()
            //                          select new UsuarioViewModel()
            //                          {
            //                              Id = usuario.Id,
            //                              Login = usuario.Login,
            //                              Nome = usuario.Nome,
            //                              Perfil = usuario.Perfil,
            //                              Cidade = usuario.Cidade,
            //                              Ativo = usuario.Ativo
            //                          }).ToList();

            return View(listaUsuariosViewModel);
        }
    }
}