using _2014102166_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102166_PER.EntitiesConfigurations
{
    class DispensadorConfigurations : EntityTypeConfiguration<DispensadorEfectivo>
    {
        public DispensadorConfigurations()
        {
            //Relations Configurations
            HasRequired(c => c.Retirodinero)
                .WithRequiredPrincipal(c => c.Dispensador);
        }
    }
}
