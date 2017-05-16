using _2015137370_ENT;
using _2015137370_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_PER.Repositories
{
    public class TransporteRepository : Repository<Transporte>, ITransporteRepository
    {
        //private readonly DBContext _Context;

        private DBContext _Context;

        public TransporteRepository(DBContext _Context)
        {
            // TODO: Complete member initialization
            this._Context = _Context;
        }


        IEnumerable<Transporte> ITransporteRepository.GetAdministrativoWhitBus(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        void IRepository<Transporte>.Add(Transporte entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Transporte>.AddRange(IEnumerable<Transporte> entities)
        {
            throw new NotImplementedException();
        }

        Transporte IRepository<Transporte>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Transporte> IRepository<Transporte>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Transporte> IRepository<Transporte>.Find(System.Linq.Expressions.Expression<Func<Transporte, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<Transporte>.Update(Transporte entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Transporte>.UpdateRange(IEnumerable<Transporte> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Transporte>.Delete(Transporte entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Transporte>.DeleteRange(IEnumerable<Transporte> entities)
        {
            throw new NotImplementedException();
        }


    }
}
