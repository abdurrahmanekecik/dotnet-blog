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
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;

        public UserRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetByUuid(Guid uuid)
        {
            return _context.Users.FirstOrDefault(x => x.Uuid == uuid);
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void Delete(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public int Count(Expression<Func<User, bool>> predicate = null)
        {
            if (predicate == null)
                return _context.Users.Count();

            return _context.Users.Count(predicate);
        }

        public IEnumerable<User> List(Expression<Func<User, bool>> predicate = null)
        {
            if (predicate == null)
                return _context.Users.ToList();
            return _context.Users.Where(predicate).ToList();
        }
    }
}
