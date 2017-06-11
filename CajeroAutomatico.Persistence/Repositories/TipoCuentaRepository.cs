using CajeroAutomatico.Entities.Entities;
using CajeroAutomatico.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Persistence.Repositories
{
    public class TipoCuentaRepository : Repository<TipoCuenta>, ITipoCuentaRepository
    {

        public TipoCuentaRepository(CajeroAutomaticoDBContext context) : base(context)
        {


        }


    }
}
