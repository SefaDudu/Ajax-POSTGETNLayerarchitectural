using Project.Core.DataAccess;
using Project.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess.Abstract
{
     public interface IProductDal:IEntityRepository<Product>
    {
    }
}
