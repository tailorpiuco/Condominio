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
    public class MoradorService : EntityService<Morador>, IMoradorService
    {
        private IUnitOfWork unitOfWork;

        public MoradorService(IUnitOfWork unitOfWork, IGenericRepository<Morador> repository) : base(unitOfWork, repository)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
