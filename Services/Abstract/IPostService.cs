using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entitites;

namespace Services.Abstract
{
    public interface IPostService
    {
        IEnumerable<Post> GetAll();
        IEnumerable<Post> List(Expression<Func<Post, bool>> predicate = null);
        Post GetByUuid(Guid uuid);
        void Add(Post post);
        void Update(Post post);
        void Delete(Post post);

        int Count(Expression<Func<Post, bool>> predicate = null);
    }
}
