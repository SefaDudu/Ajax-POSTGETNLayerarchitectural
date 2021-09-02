using Project.Busi.Concrete;
using Project.Core.Filters;
using Project.DataAccess.Concrete;
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
        ProductManager product;
        public StoreProcedurController()
        {
            product = new ProductManager(new EfProductDal());
        }
       
        [HttpGet]
        [ActFilter]
        public ActionResult Index()
        {
            var result = product.StoreProcedureList();
            return View(result);
        }
    }
}