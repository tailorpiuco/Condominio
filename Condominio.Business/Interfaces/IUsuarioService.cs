using Condominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Business.Interfaces
{
    public interface IUsuarioService
    {
        Usuario RetornaUsuario(Usuario model);
    }
}
