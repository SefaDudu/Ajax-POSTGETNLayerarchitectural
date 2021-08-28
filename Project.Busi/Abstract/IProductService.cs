using Project.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Busi.Abstract
{
    public interface IProductService
    {
        IList<Product> GetList();
        Product GetById(int id);
        void add(Product products);
        void delete(Product products);
        void update(Product products);
    
    }
}
