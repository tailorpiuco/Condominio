using Condominio.Data.Interfaces;
using Condominio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Condominio.Data.Repositories
{    
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {        
        public UsuarioRepository(DbContext context) : base(context)
        {

        }

        public Usuario RetornaUsuario(Usuario usuario)
        {
            return _dbSet.SingleOrDefault(u => u.Login == usuario.Login && u.Senha == usuario.Senha);
        }
    }
}
