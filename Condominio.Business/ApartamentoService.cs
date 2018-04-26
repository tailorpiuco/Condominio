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
    public class ApartamentoService : EntityService<Apartamento>, IApartamentoService
    {
        private IUnitOfWork unitOfWork;

        public ApartamentoService(IUnitOfWork unitOfWork, IGenericRepository<Apartamento> repository) : base(unitOfWork, repository)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
