using _2014102166_ENT;
using _2014102166_PER.EntitiesConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102166_PER
{
    public class Lc2DbContext : DbContext
    {
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<DispensadorEfectivo> Dispensadores { get; set; }
        public DbSet<Pantalla> Pantallas { get; set; }
        public DbSet<RanuraDeposito> Ranuras { get; set; }
        public DbSet<Teclado> Teclados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CuentaConfigurations());
            modelBuilder.Configurations.Add(new DispensadorConfigurations());
            modelBuilder.Configurations.Add(new PantallaConfigurations());
            modelBuilder.Configurations.Add(new RanuraConfigurations());
            modelBuilder.Configurations.Add(new TecladoConfigurations());
            base.OnModelCreating(modelBuilder); 
        }
    }

}
