﻿
using CajeroAutomatico.Entities.Entities;
using CajeroAutomatico.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CajeroAutomatico.Persistencia.Repositories
{
   public class AtmRepository : Repository<ATM>, IAtmRepository

    {


        public AtmRepository(CajeroAutomaticoDBContext context) : base(context)
        {
  
        }

    }
}
