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
    public class TagRepository : ITagRepository
    {
        private readonly Context _context;

        public TagRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<Tag> GetAll()
        {
            return _context.Tags.ToList();
        }

        public Tag GetByUuid(Guid uuid)
        {
            return _context.Tags.FirstOrDefault(x => x.Uuid == uuid);
        }

        public void Add(Tag tag)
        {
            _context.Tags.Add(tag);
            _context.SaveChanges();
        }

        public void Update(Tag tag)
        {
            _context.Tags.Update(tag);
            _context.SaveChanges();
        }

        public void Delete(Tag tag)
        {
            _context.Tags.Remove(tag);
            _context.SaveChanges();
        }

        public int Count(Expression<Func<Tag, bool>> predicate = null)
        {
            if (predicate == null)
                return _context.Tags.Count();

            return _context.Tags.Count(predicate);
        }

        public IEnumerable<Tag> List(Expression<Func<Tag, bool>> predicate = null)
        {
            if (predicate == null)
                return _context.Tags.ToList();
            return _context.Tags.Where(predicate).ToList();
        }
    }
}
