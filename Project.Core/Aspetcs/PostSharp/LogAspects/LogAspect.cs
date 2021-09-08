using PostSharp.Aspects;
using PostSharp.Extensibility;
using Project.Core.CrossCuttingConcerns.Logging;
using Project.Core.CrossCuttingConcerns.Logging.Log4Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Aspetcs.PostSharp.LogAspect
{
    [Serializable]
    [MulticastAttributeUsage(MulticastTargets.Method, TargetExternalMemberAttributes = MulticastAttributes.Instance)]//en tepeye koyduğumuz zaman ctorun etkilenmemesi için
    public class LogAspect : OnMethodBoundaryAspect
    {
        private Type _loggerType;
        LoggerService _loggerService;
        public LogAspect(Type loggerType)
        {
            _loggerType = loggerType;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            //eğer typeof ile gönderilen log kayıt kısmı logger serviceden gelmiyorsa kabul etme
            if (_loggerType.BaseType != typeof(LoggerService))
            {
                throw new Exception("Wrong logger type");

            }
            //her şey doğruysa instance oluşsun
            _loggerService = (LoggerService)Activator.CreateInstance(_loggerType);
            base.RuntimeInitialize(method);
        }
        public override void OnEntry(MethodExecutionArgs args)
        {
            if (!_loggerService.IsInfoEnabled)
            {
                return;
            }

            var logParameters = args.Method.GetParameters().Select((t, i) => new LogParameter
            {
                Name = t.Name,
                Type = t.ParameterType.Name,
                Value = args.Arguments.GetArgument(i)


            });

            var logDetail = new LogDetail
            {
                FullName = args.Method.DeclaringType == null?null: args.Method.DeclaringType.Name,
                MethodName = args.Method.Name,

                Parameters = logParameters.ToList()
            };
            _loggerService.Info(logDetail);





        }




    }
}
