using CajeroAutomatico.Entities;
using CajeroAutomatico.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Persistence.Repositories
{
    public class RanuraDepositoRepository : Repository<RanuraDeposito>, IRanuraDepositoRepository
    {
        private readonly CajeroAutomaticoContext _context;

        public RanuraDepositoRepository(CajeroAutomaticoContext context)
        {
            _context = context;
        }
        private RanuraDepositoRepository()
        {

        }
    }
}
