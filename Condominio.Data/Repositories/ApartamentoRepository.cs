using Condominio.Data.Interfaces;
using Condominio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Data.Repositories
{
    public class ApartamentoRepository : GenericRepository<Apartamento>, IApartamentoRepository
    {
        public ApartamentoRepository(DbContext context) : base(context)
        {
        }
    }
}
