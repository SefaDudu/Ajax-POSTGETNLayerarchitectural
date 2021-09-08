using FluentValidation;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Busi.ValidationRules.FluentValidation
{
   public  class ProductValidator:AbstractValidator<Product>
    {

        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün Adı Boş Geçilemez");
            RuleFor(p => p.ProductName).Length(2,20).WithMessage("Ürün Adı 2 ila 20 arasında karakter içermelidir");
            //product name boş geçilemez
            //RuleFor(p => p.ProductName).Must(StarwithA); kendi fonksiyonumuzu yazabiliiriz
        }
   

    }
}
