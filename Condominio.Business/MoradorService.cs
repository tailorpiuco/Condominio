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
        private IMoradorRepository repository;

        public MoradorService(IUnitOfWork unitOfWork, IMoradorRepository repository) : base(unitOfWork, repository)
        {
            this.unitOfWork = unitOfWork;
            this.repository = repository;
        }

        public void RemoveMoradoresApartamento(int idApartamento)
        {
            var moradores = repository.FindBy(m => m.ApartamentoId == idApartamento);

            foreach(var m in moradores)
            {
                m.ApartamentoId = null;
                repository.Update(m);
            }
        }

        public override void Delete(int id)
        {
            var morador = repository.FindBy(m => m.Id == id, i => i.Apartamento).SingleOrDefault();
            
            if (morador.Responsavel)
            {
                throw new Exception(String.Format("Operação não permitida: O morador é responsável pelo apartamento {0}.", morador.Apartamento.Numero));
            }            

            base.Delete(id);
        }
    }
}
