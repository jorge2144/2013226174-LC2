using CajeroAutomatico.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Persistence.EntitiesConfiguration
{
    public class ATMConfiguration : EntityTypeConfiguration<ATM>
    {
        public ATMConfiguration()
        {
            //table configuration
            ToTable("ATM");
            HasKey(c => c.ATMId);

            //Relation configuration

            //RelacionTeclado
            HasRequired(c => c.Teclado)
                .WithRequiredPrincipal(c => c.ATM);
            //RelacionPantalla
            HasRequired(c => c.Pantalla)
                .WithRequiredPrincipal(c => c.ATM);

        }
    }
}
