using CajeroAutomatico.Entities;
using CajeroAutomatico.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Persistence.Repositories
{
    public class DispensadorEfectivoRepository : Repository<DispensadorEfectivo>, IDispensadorEfectivoRepository
    {
        private readonly CajeroAutomaticoContext _context;

        public DispensadorEfectivoRepository(CajeroAutomaticoContext context)
        {
            _context = context;
        }
        private DispensadorEfectivoRepository()
        {

        }
    }
}
