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
    public class MoradorRepository : GenericRepository<Morador>, IMoradorRepository
    {
        public MoradorRepository(DbContext context) : base(context)
        {
        }
    }
}
