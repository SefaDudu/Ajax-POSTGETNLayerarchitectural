using Project.Busi.Abstract;
using Project.DataAccess.Abstract;
using Project.DataAccess.Concrete;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Busi.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = new EfProductDal();
           // _productDal = productDal;

        }

        public void add(Product products)
        {
            _productDal.Add(products);
        }

        public void delete(Product products)
        {
            _productDal.Delete(products);
        }

        public Product GetById(int id)
        {
            return _productDal.Get(x=>x.ID == id);
        }

        public IList<Product> GetList()
        {
            return _productDal.GetList();
        }

        public List<Product> StoreProcedureList()
        {
            return _productDal.GetAllStore();
        }

        public void update(Product products)
        {
            _productDal.Update(products);
        }
    }
}
