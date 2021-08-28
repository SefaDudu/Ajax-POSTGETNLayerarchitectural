using Project.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Busi.Abstract
{
  public  interface ICommentsService
    {
        IList<Comment> GetList(Expression<Func<Comment, bool>> filter=null);
        Comment GetById(int id);
        void add(Comment comments);
        void delete(Comment comments);
        void update(Comment comments);
    }
}
