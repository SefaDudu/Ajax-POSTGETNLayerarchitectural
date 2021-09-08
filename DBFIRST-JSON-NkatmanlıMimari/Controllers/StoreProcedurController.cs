
using Project.Busi.Abstract;
using Project.Business.Concrete;
using Project.Core.Filters;
using Project.DataAccess.Concrete;
using Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBFIRST_JSON_NkatmanlıMimari.Controllers
{
    public class StoreProcedurController : Controller
    {
        // GET: StoreProcedur
        //ProductManager product;
        //public StoreProcedurController()
        //{
        //    product = new ProductManager(new EfProductDal());
        //}

        IProductService _productService;
        public StoreProcedurController(IProductService productService)
        {
            _productService = productService;
        }



        [HttpGet]
        //[ActFilter] --> log almaya yarıyor.
        public ActionResult Index()
        {
            var model = new ProductListViewModel
            {
                Products = _productService.StoreProcedureList()
            };
            //var result = product.StoreProcedureList();
            return View(model);
        }
    }
}