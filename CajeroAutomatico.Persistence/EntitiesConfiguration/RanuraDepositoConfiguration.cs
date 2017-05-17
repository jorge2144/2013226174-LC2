using CajeroAutomatico.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Persistence.EntitiesConfiguration
{
    class RanuraDepositoConfiguration : EntityTypeConfiguration<RanuraDeposito>
    {
        public RanuraDepositoConfiguration()
        {
            //TAble configuration
            ToTable("Ranura Deposito");
            HasKey(c => c.RanuraDepositoId);
;
        }
    }
}
