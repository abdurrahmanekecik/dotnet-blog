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
    public class CommentRepository : ICommentRepository
    {
        private readonly Context _context;

        public CommentRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<Comment> GetAll()
        {
            return _context.Comments.ToList();
        }

        public Comment GetByUuid(Guid uuid)
        {
            return _context.Comments.FirstOrDefault(x => x.Uuid == uuid);
        }

        public void Add(Comment post)
        {
            _context.Comments.Add(post);
            _context.SaveChanges();
        }

        public void Update(Comment post)
        {
            _context.Comments.Update(post);
            _context.SaveChanges();
        }

        public void Delete(Comment post)
        {
            _context.Comments.Remove(post);
            _context.SaveChanges();
        }

        public int Count(Expression<Func<Comment, bool>> predicate = null)
        {
            if (predicate == null)
                return _context.Posts.Count();

            return _context.Comments.Count(predicate);
        }

        public IEnumerable<Comment> List(Expression<Func<Comment, bool>> predicate = null)
        {
            if (predicate == null)
                return _context.Comments.ToList();
            return _context.Posts.Where(predicate).ToList();
        }
    }
}
