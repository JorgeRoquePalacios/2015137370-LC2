using _2015137370_ENT;
using _2015137370_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_PER.Repositories
{
    public class BusRepository : Repository<Bus>, IBusRepository
    {
        //private readonly DBContext _Context;

        private DBContext _Context;

        public BusRepository(DBContext _Context)
        {
            // TODO: Complete member initialization
            this._Context = _Context;
        }




        IEnumerable<Bus> IBusRepository.GetAdministrativoWhitEncomienda(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.Add(Bus entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.AddRange(IEnumerable<Bus> entities)
        {
            throw new NotImplementedException();
        }

        Bus IRepository<Bus>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Bus> IRepository<Bus>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Bus> IRepository<Bus>.Find(System.Linq.Expressions.Expression<Func<Bus, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.Update(Bus entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.UpdateRange(IEnumerable<Bus> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.Delete(Bus entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.DeleteRange(IEnumerable<Bus> entities)
        {
            throw new NotImplementedException();
        }

    }
}
