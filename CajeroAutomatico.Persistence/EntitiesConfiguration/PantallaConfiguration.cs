using CajeroAutomatico.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Persistence.EntitiesConfiguration
{
    class PantallaConfiguration : EntityTypeConfiguration<Pantalla>
    {
        PantallaConfiguration()
        {
            //Table configuration
            ToTable("Pantalla");
            HasKey(c => c.PantallaId);
            //Retiro
            HasOptional(c => c.Retiro)
                .WithRequired(c => c.Pantalla);
        }
    }
}
