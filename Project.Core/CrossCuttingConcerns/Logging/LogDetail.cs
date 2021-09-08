using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.CrossCuttingConcerns.Logging
{
   public class LogDetail
    {
        //class ismi
        public string FullName { get; set; }
        //Classtaki methodun ismi
        public string MethodName { get; set; }
        public List<LogParameter> Parameters { get; set; }


    }
}
