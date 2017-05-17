using CajeroAutomatico.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Persistence.EntitiesConfiguration
{
    public class BaseDeDatosConfiguration : EntityTypeConfiguration<BaseDeDatos>
    {
        public BaseDeDatosConfiguration()
        {
            //configuration
            ToTable("BaseDeDatos");
            HasKey(c => c.BaseDeDatosId);
            //Cuenta 
            HasOptional(c => c.Cuenta)
                .WithRequired(c => c.BaseDeDatos);
            //Retiro
            HasOptional(c => c.Retiro)
                .WithRequired(c => c.BaseDeDatos);
        }
        
    }
}
