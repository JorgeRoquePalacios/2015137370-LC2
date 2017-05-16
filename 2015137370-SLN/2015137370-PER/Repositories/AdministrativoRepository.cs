using _2015137370_ENT;
using _2015137370_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137370_PER.Repositories
{
    public class AdministrativoRepository : Repository<Administrativo>, IAdministrativoRepository
    {

        //private readonly DBContext _Context;

        private DBContext _Context;

        public AdministrativoRepository(DBContext _Context)
        {
            // TODO: Complete member initialization
            this._Context = _Context;
        }

        IEnumerable<Administrativo> IAdministrativoRepository.GetAdministrativoWhitVenta(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        void IRepository<Administrativo>.Add(Administrativo entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Administrativo>.AddRange(IEnumerable<Administrativo> entities)
        {
            throw new NotImplementedException();
        }

        Administrativo IRepository<Administrativo>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Administrativo> IRepository<Administrativo>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Administrativo> IRepository<Administrativo>.Find(System.Linq.Expressions.Expression<Func<Administrativo, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<Administrativo>.Update(Administrativo entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Administrativo>.UpdateRange(IEnumerable<Administrativo> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Administrativo>.Delete(Administrativo entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Administrativo>.DeleteRange(IEnumerable<Administrativo> entities)
        {
            throw new NotImplementedException();
        }




    }
}
