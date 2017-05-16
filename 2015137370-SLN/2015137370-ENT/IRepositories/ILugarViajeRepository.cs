using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_ENT.IRepositories
{
    public interface ILugarViajeRepository : IRepository<LugarViaje>
    {

        IEnumerable<Administrativo> GetAdministrativoWhiTransporte(int pageIndex, int pageSize);

        IEnumerable<Administrativo> GetAdministrativoWhitEncomienda(int pageIndex, int pageSize);
    }
}
