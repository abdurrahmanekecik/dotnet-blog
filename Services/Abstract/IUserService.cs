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
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        IEnumerable<User> List(Expression<Func<User, bool>> predicate = null);
        User GetByUuid(Guid uuid);
        void Add(User user);
        void Update(User user);
        void Delete(User user);

        int Count(Expression<Func<User, bool>> predicate = null);
    }
}
