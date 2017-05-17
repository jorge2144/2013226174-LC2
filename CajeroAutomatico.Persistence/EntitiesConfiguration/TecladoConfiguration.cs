using CajeroAutomatico.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Persistence.EntitiesConfiguration
{
    class TecladoConfiguration : EntityTypeConfiguration<Teclado>
    {
        public TecladoConfiguration()
        {
            //TableConfiguration
            ToTable("Teclado");
            HasKey(c => c.TecladoId);
        }
    }
}
