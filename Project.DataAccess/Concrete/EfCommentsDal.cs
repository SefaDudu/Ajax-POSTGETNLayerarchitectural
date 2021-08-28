using Project.Core.DataAccess.EntityFramework;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using Project.Entities.Context;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess.Concrete
{
    public class EfCommentsDal : EfEntityRepositoryBase<Comment, ProductDbContext>, ICommentsDal
    {
    }
}
