﻿using _2015137370_ENT;
using _2015137370_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_PER.Repositories
{
    public class ServicioRepository : Repository<Servicio>, IServicioRepository
    {
        //private readonly DBContext _Context;

        private DBContext _Context;

        public ServicioRepository(DBContext _Context)
        {
            // TODO: Complete member initialization
            this._Context = _Context;
        }
    }
}