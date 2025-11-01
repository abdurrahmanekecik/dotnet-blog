using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Interfaces;
using Entitites;
using Services.Abstract;

namespace Services.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public IEnumerable<User> List(Expression<Func<User, bool>> predicate = null)
        {
            return _userRepository.List(predicate);
        }

        public User GetByUuid(Guid uuid)
        {
            return _userRepository.GetByUuid(uuid);
        }

        public void Add(User user)
        {
            _userRepository.Add(user);
        }

        public void Update(User user)
        {
            _userRepository.Update(user);
        }

        public void Delete(User user)
        {
            _userRepository.Delete(user);
        }

        public int Count(Expression<Func<User, bool>> predicate = null)
        {
            return _userRepository.Count(predicate);
        }
    }
}
