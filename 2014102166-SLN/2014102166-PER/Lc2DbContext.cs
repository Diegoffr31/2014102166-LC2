using _2014102166_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102166_PER
{
    class Lc2DbContext: DbContext
    {
        public DbSet<Cuenta> Cuentas { get; set; }
    }
}
