using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Interfaces;
using Entitites;
using Services.Abstract;

namespace Services.Concrete
{
    public class PostCategoryService : IPostCategoryService
    {
        private readonly IPostCategoryRepository _postCategoryRepository;

        public PostCategoryService(IPostCategoryRepository postCategoryRepository)
        {
            _postCategoryRepository = postCategoryRepository;
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryRepository.GetAll();
        }

        public IEnumerable<PostCategory> List(Expression<Func<PostCategory, bool>> predicate = null)
        {
            return _postCategoryRepository.List(predicate);
        }

        public PostCategory GetByUuid(Guid uuid)
        {
            return _postCategoryRepository.GetByUuid(uuid);
        }

        public void Add(PostCategory comment)
        {
            _postCategoryRepository.Add(comment);
        }

        public void Update(PostCategory comment)
        {
            _postCategoryRepository.Update(comment);
        }

        public void Delete(PostCategory comment)
        {
            _postCategoryRepository.Delete(comment);
        }

        public int Count(Expression<Func<PostCategory, bool>> predicate = null)
        {
            return _postCategoryRepository.Count(predicate);
        }
    }
}
