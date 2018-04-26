using Condominio.Business.Interfaces;
using Condominio.Data.Interfaces;
using Condominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Business
{
    public class UsuarioService : IUsuarioService
    {
        IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public Usuario RetornaUsuario(Usuario model)
        {
            return _repository.RetornaUsuario(model);
        }
    }
}
