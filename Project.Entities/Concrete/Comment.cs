using Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Concrete
{
    public class Comment : IEntity
    {
        [Key]
        public int ID { get; set; }
        public String Comments { get; set; }

        //her ürünün birden fazla yorumu olabilir.
        //1 olan buraya çok olana diğer tarafa
        public int ProductId { get; set; }
        public Product product { get; set; }

    }
}
