using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Interfaces;
using Entitites;
using Services.Abstract;

namespace Services.Concrete
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public IEnumerable<Role> GetAll()
        {
            return _roleRepository.GetAll();
        }

        public IEnumerable<Role> List(Expression<Func<Role, bool>> predicate = null)
        {
            return _roleRepository.List(predicate);
        }

        public Role GetByUuid(Guid uuid)
        {
            return _roleRepository.GetByUuid(uuid);
        }

        public void Add(Role role)
        {
            _roleRepository.Add(role);
        }

        public void Update(Role role)
        {
            _roleRepository.Update(role);
        }

        public void Delete(Role role)
        {
            _roleRepository.Delete(role);
        }

        public int Count(Expression<Func<Role, bool>> predicate = null)
        {
            return _roleRepository.Count(predicate);
        }
    }
}
