using Project.Busi.Abstract;
using Project.Busi.ValidationRules.FluentValidation;
using Project.Core.Aspetcs.PostSharp;
using Project.DataAccess.Abstract;
using Project.DataAccess.Concrete;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PostSharp.Serialization;

using Project.Core.Aspetcs.PostSharp.LogAspect;
using Project.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;

namespace Project.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = new EfProductDal();
    

        }

        //[FluentValidationAspect(typeof(ProductValidator))]
        //[LogAspect(typeof(FileLogger))]

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

        //[CacheAspect()]
        //[LogAspect(typeof(DatabaseLogger))]
        //[LogAspect(typeof(FileLogger))]
        public IList<Product> GetList()
        {
            return _productDal.GetList();
        }
        //[LogAspect(typeof(DatabaseLogger))]
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
