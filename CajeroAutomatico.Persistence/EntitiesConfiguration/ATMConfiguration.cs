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

            //DispensadorEfectivo
            HasRequired(c => c.DispensadorEfectivo)
                .WithRequiredPrincipal(c => c.ATM);

            //Retiro
            HasOptional(c => c.Retiro)
                .WithRequired(c => c.ATM);
            //Base de datos
            HasRequired(c => c.BaseDeDatos)
                .WithRequiredPrincipal(c => c.ATM);
            //RanuraDeposito
            HasRequired(c => c.RanuraDeposito)
                .WithRequiredPrincipal(c => c.ATM);

        }
    }
}
