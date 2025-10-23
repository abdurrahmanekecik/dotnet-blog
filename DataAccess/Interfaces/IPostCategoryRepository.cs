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
    public interface IPostCategoryRepository
    {
        IEnumerable<PostCategory> GetAll();
        IEnumerable<PostCategory> List(Expression<Func<PostCategory, bool>> predicate = null);
        PostCategory GetByUuid(Guid uuid);
        void Add(PostCategory postCategory);
        void Update(PostCategory postCategory);
        void Delete(PostCategory postCategory);

        int Count(Expression<Func<PostCategory, bool>> predicate = null);
    }
}
