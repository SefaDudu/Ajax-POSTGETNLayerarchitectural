using Project.Busi.Abstract;
using Project.DataAccess.Abstract;
using Project.DataAccess.Concrete;
using Project.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business.Concrete
{
    public class CommentsManager : ICommentsService
    {
        private  ICommentsDal _commentsDal;
        public CommentsManager(ICommentsDal commentsDal)
        {
            _commentsDal = new EfCommentsDal();

        }
        public void add(Comment comments)
        {
            _commentsDal.Add(comments);
        }

        public void delete(Comment comments)
        {
            _commentsDal.Delete(comments);
        }

        public Comment GetById(int id)
        {
            return _commentsDal.Get(x => x.ID == id);
        }

        public IList<Comment> GetList(Expression<Func<Comment, bool>> filter = null)
        {
            return _commentsDal.GetList(filter);
        }

        public void update(Comment comments)
        {
            _commentsDal.Update(comments);
        }
    }
}
