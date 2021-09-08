using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.CrossCuttingConcerns.Logging
{
   public class LogParameter
    {
        //Log parametrelerini ve içindeki değerleri tutması için oluşturulmuş class
        public string Name { get; set; }
        public string Type { get; set; }
        public Object Value { get; set; }
    }
}
