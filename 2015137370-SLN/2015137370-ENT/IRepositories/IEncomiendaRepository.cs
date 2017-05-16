﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_ENT.IRepositories
{
    public interface IEncomiendaRepository : IRepository<Encomienda>
    {

        IEnumerable<Encomienda> GetAdministrativoWhitLugarViaje(int pageIndex, int pageSize);
    }
}