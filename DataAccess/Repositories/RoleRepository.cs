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
    public class RoleRepository : IRoleRepository
    {
        private readonly Context _context;

        public RoleRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<Role> GetAll()
        {
            return _context.Roles.ToList();
        }

        public Role GetByUuid(Guid uuid)
        {
            return _context.Roles.FirstOrDefault(x => x.Uuid == uuid);
        }

        public void Add(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
        }

        public void Update(Role role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
        }

        public void Delete(Role role)
        {
            _context.Roles.Remove(role);
            _context.SaveChanges();
        }

        public int Count(Expression<Func<Role, bool>> predicate = null)
        {
            if (predicate == null)
                return _context.Roles.Count();

            return _context.R.Count(predicate);
        }

        public IEnumerable<Role> List(Expression<Func<Role, bool>> predicate = null)
        {
            if (predicate == null)
                return _context.Roles.ToList();
            return _context.Posts.Where(predicate).ToList();
        }
    }
}
