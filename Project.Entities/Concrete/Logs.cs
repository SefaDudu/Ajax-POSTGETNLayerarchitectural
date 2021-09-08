using Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Concrete
{
    public class Logs:IEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(4000)]
        public string Detail { get; set; }
        public DateTime Date { get; set; }
        [MaxLength(50)]
        public string Audit { get; set; }

    }
}
