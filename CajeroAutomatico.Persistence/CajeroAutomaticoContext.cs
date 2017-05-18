using CajeroAutomatico.Entities;
using CajeroAutomatico.Persistence.EntitiesConfiguration;
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
        public DbSet<BaseDeDatos>BaseDeDatoss { get; set; }
        public DbSet<Cuenta>Cuentas { get; set; }
        public DbSet<DispensadorEfectivo>DispensadorEfectivos { get; set; }
        public DbSet<Pantalla>Pantallas { get; set; }
        public DbSet<RanuraDeposito> RanuraDepositos { get; set; }
        public DbSet<Retiro> Retiros { get; set; }
        public DbSet<Teclado> Teclados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ATMConfiguration());
            modelBuilder.Configurations.Add(new BaseDeDatosConfiguration());
            modelBuilder.Configurations.Add(new CuentaConfiguration());
            modelBuilder.Configurations.Add(new DispensadorEfectivoConfiguration());
            modelBuilder.Configurations.Add(new PantallaConfiguration());
            modelBuilder.Configurations.Add(new RanuraDepositoConfiguration());
            modelBuilder.Configurations.Add(new RetiroConfiguration());
            modelBuilder.Configurations.Add(new TecladoConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        
    }
}
