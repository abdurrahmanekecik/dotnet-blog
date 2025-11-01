using System;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Interfaces;
using Entitites;
using Services.Abstract;

namespace Services.Concrete
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll();
        }

        public IEnumerable<Post> List(Expression<Func<Post, bool>> predicate = null)
        {
            return _postRepository.List(predicate);
        }

        public Post GetByUuid(Guid uuid)
        {
            return _postRepository.GetByUuid(uuid);
        }

        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }

        public void Delete(Post post)
        {
            _postRepository.Delete(post);
        }

        public int Count(Expression<Func<Post, bool>> predicate = null)
        {
            return _postRepository.Count(predicate);
        }
    }
}
