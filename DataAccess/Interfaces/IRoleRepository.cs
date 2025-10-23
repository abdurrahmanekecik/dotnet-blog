using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entitites;

namespace DataAccess.Interfaces
{
    public interface IRoleRepository
    {
        IEnumerable<Role> GetAll();
        IEnumerable<Role> List(Expression<Func<Role, bool>> predicate = null);
        Role GetByUuid(Guid uuid);
        void Add(Role role);
        void Update(Role role);
        void Delete(Role role);

        int Count(Expression<Func<Role, bool>> predicate = null);
    }
}
