using CajeroAutomatico.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Persistence
{
    public class CajeroAutomaticoContext : DbContext

    {
        public DbSet<ATM> ATMs{ get; set; }
        public int MyProperty { get; set; }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }

        internal int SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
