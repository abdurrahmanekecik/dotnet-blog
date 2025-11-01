using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Interfaces;
using Entitites;
using Services.Abstract;

namespace Services.Concrete
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public IEnumerable<Comment> GetAll()
        {
            return _commentRepository.GetAll();
        }

        public IEnumerable<Comment> List(Expression<Func<Comment, bool>> predicate = null)
        {
            return _commentRepository.List(predicate);
        }

        public Comment GetByUuid(Guid uuid)
        {
            return _commentRepository.GetByUuid(uuid);
        }

        public void Add(Comment comment)
        {
            _commentRepository.Add(comment);
        }

        public void Update(Comment comment)
        {
            _commentRepository.Update(comment);
        }

        public void Delete(Comment comment)
        {
            _commentRepository.Delete(comment);
        }

        public int Count(Expression<Func<Comment, bool>> predicate = null)
        {
            return _commentRepository.Count(predicate);
        }
    }
}
