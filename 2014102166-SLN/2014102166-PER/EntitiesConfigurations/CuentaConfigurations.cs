using _2014102166_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102166_PER.EntitiesConfigurations
{
    public class CuentaConfigurations: EntityTypeConfiguration<Cuenta>
    {
        public CuentaConfigurations()
        {
            //Relations Configurations
            HasOptional(c => c.mostrarCuenta)

            .WithRequired(c => c.Cuenta);
        }
    }
}
