using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();

        DbContext DbContext
        {
            get;
        }
    }
}
