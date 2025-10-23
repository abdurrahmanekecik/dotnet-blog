using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Interfaces;
using Entitites;

namespace DataAccess.Repositories
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly Context _context;

        public UserRoleRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<UserRole> GetAll()
        {
            return _context.UserRoles.ToList();
        }

        public UserRole GetByUuid(Guid uuid)
        {
            return _context.UserRoles.FirstOrDefault(x => x.Uuid == uuid);
        }

        public void Add(UserRole userRole)
        {
            _context.UserRoles.Add(userRole);
            _context.SaveChanges();
        }

        public void Update(UserRole userRole)
        {
            _context.UserRoles.Update(userRole);
            _context.SaveChanges();
        }

        public void Delete(UserRole userRole)
        {
            _context.UserRoles.Remove(userRole);
            _context.SaveChanges();
        }

        public int Count(Expression<Func<UserRole, bool>> predicate = null)
        {
            if (predicate == null)
                return _context.UserRoles.Count();

            return _context.UserRoles.Count(predicate);
        }

        public IEnumerable<UserRole> List(Expression<Func<UserRole, bool>> predicate = null)
        {
            if (predicate == null)
                return _context.UserRoles.ToList();
            return _context.UserRoles.Where(predicate).ToList();
        }
    }
}
