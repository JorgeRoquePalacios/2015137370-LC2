﻿using _2015137370_ENT;
using _2015137370_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_PER.Repositories
{
    public class EncomiendaRepository : Repository<Encomienda>, IEncomiendaRepository
    {
        public EncomiendaRepository(DbContext context) : base(context)
        {
        }

    }
}
