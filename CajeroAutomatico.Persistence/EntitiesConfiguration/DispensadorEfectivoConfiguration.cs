﻿using CajeroAutomatico.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Persistence.EntitiesConfiguration
{
    class DispensadorEfectivoConfiguration : EntityTypeConfiguration<DispensadorEfectivo>
    {
        public DispensadorEfectivoConfiguration()
        {
            //TAble configuration
            ToTable("Dispensador efectivo");
            HasKey(c => c.DispensadorEfectivoId);

            //Retiro
            HasOptional(c => c.Retiro)
                .WithRequired(c => c.DispensadorEfectivo);
        }
    }
}
