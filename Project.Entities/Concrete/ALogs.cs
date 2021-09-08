using Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Concrete
{
   public class ALogs:IEntity
    {
        [Key , Required()]
        public int Id { get; set; }
        [Required()]
        public DateTime Tarih { get; set; }
        [Required()]
        public string KullaniciAdi { get; set; }
        [Required()]
        public string ActionName { get; set; }
        [Required()]
        public string ControllerName { get; set; }
        [Required()]
        public string Bilgi { get; set; }

    }
}
