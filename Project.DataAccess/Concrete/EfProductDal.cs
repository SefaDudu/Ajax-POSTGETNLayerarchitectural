using DataLayer;
using Project.Core.DataAccess.EntityFramework;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using Project.Entities.Context;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Project.DataAccess.Concrete
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ProductDbContext>, IProductDal
    {
        public List<Product> GetAllStore()
        {
            return dbDAL.GetSpList<Product>("MyProcs", null);
        }
    }
}
