using _2015137370_ENT;
using _2015137370_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_PER.Repositories
{
    public class VentaRepository: Repository<Venta>, IVentaRepository
    {
        //private readonly DBContext _Context;

        private DBContext _Context;

        public VentaRepository(DBContext _Context)
        {
            // TODO: Complete member initialization
            this._Context = _Context;
        }


        IEnumerable<Venta> IVentaRepository.GetAdministrativoWhitAdministrativo(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        void IRepository<Venta>.Add(Venta entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Venta>.AddRange(IEnumerable<Venta> entities)
        {
            throw new NotImplementedException();
        }

        Venta IRepository<Venta>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Venta> IRepository<Venta>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Venta> IRepository<Venta>.Find(System.Linq.Expressions.Expression<Func<Venta, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<Venta>.Update(Venta entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Venta>.UpdateRange(IEnumerable<Venta> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Venta>.Delete(Venta entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Venta>.DeleteRange(IEnumerable<Venta> entities)
        {
            throw new NotImplementedException();
        }


    }
}
