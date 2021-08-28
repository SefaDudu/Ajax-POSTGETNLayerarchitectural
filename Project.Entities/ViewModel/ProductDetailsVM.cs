using Project.Entities.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.ViewModel
{
   public class ProductDetailsVM
    {
        public Product Product { get; set; }
        public List<Comment> Comment { get; set; }
    }
}
