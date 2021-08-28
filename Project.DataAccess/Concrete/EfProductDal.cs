using Project.Core.DataAccess.EntityFramework;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using Project.Entities.Context;


namespace Project.DataAccess.Concrete
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ProductDbContext>, IProductDal
    {
    }
}
