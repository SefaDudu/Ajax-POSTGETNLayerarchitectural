using Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Concrete
{
    public class Product : IEntity
    {
        [Key]
        public int ID { get; set; }
        [MinLength(2),MaxLength(50)]
        public string ProductName { get; set; }
        public ICollection<Comment> comment
        {
            get; set;
        }
    }
  
}
