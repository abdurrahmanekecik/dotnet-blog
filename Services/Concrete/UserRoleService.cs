using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Interfaces;
using Entitites;
using Services.Abstract;

namespace Services.Concrete
{
    public class UserRoleService : IUserRoleService
    {
        private readonly IUserRoleRepository _userRole;

        public UserRoleService(IUserRoleRepository roleRepository)
        {
            _userRole = roleRepository;
        }

        public IEnumerable<UserRole> GetAll()
        {
            return _userRole.GetAll();
        }

        public IEnumerable<UserRole> List(Expression<Func<UserRole, bool>> predicate = null)
        {
            return _userRole.List(predicate);
        }

        public UserRole GetByUuid(Guid uuid)
        {
            return _userRole.GetByUuid(uuid);
        }

        public void Add(UserRole role)
        {
            _userRole.Add(role);
        }

        public void Update(UserRole role)
        {
            _userRole.Update(role);
        }

        public void Delete(UserRole role)
        {
            _userRole.Delete(role);
        }

        public int Count(Expression<Func<UserRole, bool>> predicate = null)
        {
            return _userRole.Count(predicate);
        }
    }
}
