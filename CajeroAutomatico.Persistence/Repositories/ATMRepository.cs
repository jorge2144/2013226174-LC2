using CajeroAutomatico.Entities;
using CajeroAutomatico.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Persistence.Repositories
{
    public class ATMRepository : Repository<ATM>, IATMRepository
    {
        private CajeroAutomaticoContext _context;

        private ATMRepository()
        {

        }
        public ATMRepository(CajeroAutomaticoContext context)
        {
            _context = context;
        }
    }
}
