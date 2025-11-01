using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entitites;

namespace DataAccess.Interfaces
{
    public interface ITagService
    {
        IEnumerable<Tag> GetAll();
        IEnumerable<Tag> List(Expression<Func<Tag, bool>> predicate = null);
        Tag GetByUuid(Guid uuid);
        void Add(Tag tag);
        void Update(Tag tag);
        void Delete(Tag tag);

        int Count(Expression<Func<Tag, bool>> predicate = null);
    }
}
