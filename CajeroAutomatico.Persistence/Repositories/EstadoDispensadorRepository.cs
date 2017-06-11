using CajeroAutomatico.Entities.Entities;
using CajeroAutomatico.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Persistence.Repositories
{
    public class EstadoDispensadorRepository : Repository<EstadoDispensador>, IEstadoDispensadorRepository
    {


        public EstadoDispensadorRepository(CajeroAutomaticoDBContext context) : base(context)
        {


        }


    }
}
