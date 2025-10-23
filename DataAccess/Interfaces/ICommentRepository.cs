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
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetAll();
        IEnumerable<Comment> List(Expression<Func<Comment, bool>> predicate = null);
        Comment GetByUuid(Guid uuid);
        void Add(Comment comment);
        void Update(Comment comment);
        void Delete(Comment comment);

        int Count(Expression<Func<Comment, bool>> predicate = null);
    }
}
