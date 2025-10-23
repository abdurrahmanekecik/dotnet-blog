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
    public interface IUserRoleRepository
    {
        IEnumerable<UserRole> GetAll();
        IEnumerable<UserRole> List(Expression<Func<UserRole, bool>> predicate = null);
        UserRole GetByUuid(Guid uuid);
        void Add(UserRole userRole);
        void Update(UserRole userRole);
        void Delete(UserRole userRole);

        int Count(Expression<Func<UserRole, bool>> predicate = null);
    }
}
