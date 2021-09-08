using Project.Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Project.Core.Filters
{
    public class ActFilter : FilterAttribute, IActionFilter
    {
        ProductDbContext db = new ProductDbContext();
        //Program Çalıştıktan sonra çalışacak kodlar
        public  void OnActionExecuted(ActionExecutedContext filterContext)
        {
            
            db.ALogs.Add(new Entities.Concrete.ALogs()
            {
                KullaniciAdi = "System",

                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Tarih = DateTime.Now,
                Bilgi = "OnActionExecuted",
            });
            db.SaveChanges();
        }
       
        //Program çalışmadan çalışacak kodlar
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {

            db.ALogs.Add(new Entities.Concrete.ALogs()
            {
                KullaniciAdi = "System",

                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Tarih =DateTime.Now,
                Bilgi= "OnActionExecuting",
            });
            db.SaveChanges();
        }
    }
}
