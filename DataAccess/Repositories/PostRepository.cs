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
    public class PostRepository : IPostRepository
    {
        private readonly Context _context;

        public PostRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts.ToList();
        }

        public Post GetByUuid(Guid uuid)
        {
            return _context.Posts.FirstOrDefault(x => x.Uuid == uuid);
        }

        public void Add(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }

        public void Update(Post post)
        {
            _context.Posts.Update(post);
            _context.SaveChanges();
        }

        public void Delete(Post post)
        {
            _context.Posts.Remove(post);
            _context.SaveChanges();
        }

        public int Count(Expression<Func<Post, bool>> predicate = null)
        {
            if (predicate == null)
                return _context.Posts.Count();

            return _context.Posts.Count(predicate);
        }

        public IEnumerable<Post> List(Expression<Func<Post, bool>> predicate = null)
        {
            if (predicate == null)
                return _context.Posts.ToList();
            return _context.Posts.Where(predicate).ToList();
        }
    }
}
