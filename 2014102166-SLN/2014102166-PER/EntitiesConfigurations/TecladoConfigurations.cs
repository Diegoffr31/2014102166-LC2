using _2014102166_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102166_PER.EntitiesConfigurations
{
    class TecladoConfigurations: EntityTypeConfiguration<Teclado>
    {
        public TecladoConfigurations()
        {
            //Relations Configurations
            HasRequired(c => c.validarPin)
                .WithRequiredPrincipal(c => c.Teclado);

        }
    }
}
