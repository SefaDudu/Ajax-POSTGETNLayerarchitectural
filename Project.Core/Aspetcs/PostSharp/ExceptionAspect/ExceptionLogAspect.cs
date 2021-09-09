using PostSharp.Aspects;
using Project.Core.CrossCuttingConcerns.Logging.Log4Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Aspetcs.PostSharp.ExceptionAspect
{
    [Serializable]
    public class ExceptionLogAspect:OnExceptionAspect
    {
      readonly  private Type _loggerType;
      private  LoggerService  _loggerService;
        public ExceptionLogAspect(Type loggerType)
        {
            _loggerType = loggerType;
        }

        public override void RuntimeInitialize(MethodBase method)
        {

            if (_loggerType!=null)
            {
                if (_loggerType.BaseType != typeof(LoggerService))
                
                    throw new Exception("Wrong logger type");

                
                _loggerService = (LoggerService)Activator.CreateInstance(_loggerType);
            }
          
            //her şey doğruysa instance oluşsun
           
            base.RuntimeInitialize(method);
        }
        public override void OnException(MethodExecutionArgs args)
        {
            if (_loggerService!=null)
            {
                _loggerService.Error(args.Exception);
            }
            base.OnException(args);
        }
        




        
    }
}
