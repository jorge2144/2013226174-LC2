﻿using CajeroAutomatico.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Persistence.EntitiesConfiguration
{
    class RetiroConfiguration : EntityTypeConfiguration<Retiro>
    {
        public RetiroConfiguration()
        {
            //table configuration
            ToTable("Retiro");
            HasKey(c => c.RetiroId);

        }
    }
}
