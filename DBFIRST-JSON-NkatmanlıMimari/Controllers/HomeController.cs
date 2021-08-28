using Project.Busi.Concrete;
using Project.DataAccess.Concrete;
using Project.Entities.Concrete;
using Project.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBFIRST_JSON_NkatmanlıMimari.Controllers
{
    public class HomeController : Controller
    {
        ProductManager manger;
        CommentsManager cmanager;
        public HomeController()
        {
            manger = new ProductManager(new EfProductDal());
            cmanager = new CommentsManager(new EfCommentsDal());
        }

        //public static List<Product> list = new List<Product>() {
        //    new Product(){ ID = 1,ProductName = "Bilgisayar" },
        //    new Product(){ ID = 2,ProductName = "Kitap" },
        //};

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductDetail(int id)
        {
            ProductDetailsVM productDetailsVM = new ProductDetailsVM();
            productDetailsVM.Product = manger.GetById(id);
            productDetailsVM.Comment = cmanager.GetList(x => x.ID == id).ToList();
            return View(productDetailsVM);
        }
        [HttpPost]
        public JsonResult AddComments(Comment comment)
        {
            cmanager.add(comment);
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetProducts()
        {
            return Json(manger.GetList(), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetComments(int id)
        {
            return Json(cmanager.GetList(x => x.product.ID == id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteComments(int id)
        {
            Comment comment = cmanager.GetById(id);
            cmanager.delete(comment);

            return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddProducts(Product Products)
        {
            //list.Add(Products);
            manger.add(Products);
            return Json(true, JsonRequestBehavior.AllowGet);
            //return Json(manger.GetList(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteProducts(Product Products)
        {
            //TODO:Getbyid ile
            //list.Add(Products);
            manger.delete(Products);
            return Json(true, JsonRequestBehavior.AllowGet);
            //return Json(manger.GetList(), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult UpdateProduct(Product Products)
        {

            //list.Add(Products);
            manger.update(Products);
            return Json(true, JsonRequestBehavior.AllowGet);
            //return Json(manger.GetList(), JsonRequestBehavior.AllowGet);
        }

    }
}