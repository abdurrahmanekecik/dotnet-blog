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
    public class PostCategoryRepository : IPostCategoryRepository
    {
        private readonly Context _context;

        public PostCategoryRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _context.PostCategories.ToList();
        }

        public PostCategory GetByUuid(Guid uuid)
        {
            return _context.PostCategories.FirstOrDefault(x => x.Uuid == uuid);
        }

        public void Add(PostCategory post)
        {
            _context.PostCategories.Add(post);
            _context.SaveChanges();
        }

        public void Update(PostCategory post)
        {
            _context.PostCategories.Update(post);
            _context.SaveChanges();
        }

        public void Delete(PostCategory post)
        {
            _context.PostCategories.Remove(post);
            _context.SaveChanges();
        }

        public int Count(Expression<Func<PostCategory, bool>> predicate = null)
        {
            if (predicate == null)
                return _context.PostCategories.Count();

            return _context.PostCategories.Count(predicate);
        }

        public IEnumerable<PostCategory> List(Expression<Func<PostCategory, bool>> predicate = null)
        {
            if (predicate == null)
                return _context.PostCategories.ToList();
            return _context.PostCategories.Where(predicate).ToList();
        }
    }
}
