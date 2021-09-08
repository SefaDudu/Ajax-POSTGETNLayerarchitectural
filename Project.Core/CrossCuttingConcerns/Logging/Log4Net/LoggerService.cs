using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.CrossCuttingConcerns.Logging.Log4Net
{
   [Serializable]
  public class LoggerService
    {
        private ILog _log;
        public LoggerService(ILog log)
        {
            _log = log;

        }
        // kim ne yapmış
        public bool IsInfoEnabled => _log.IsInfoEnabled;
        public bool IsDebugEnabled => _log.IsDebugEnabled;
        public bool IsWarnEnabled => _log.IsWarnEnabled;
        public bool IsFatalEnabled => _log.IsFatalEnabled;
        //hangi hatalar dönmüş
        public bool IsErrorEnabled => _log.IsFatalEnabled;

        public void Info(Object LogMessage)
        {
            if (IsInfoEnabled)
            {
                _log.Info(LogMessage);
            }
        }
        public void Debug(Object LogMessage)
        {
            if (IsDebugEnabled)
            {
                _log.Debug(LogMessage);
            }
        }
        public void Warn(Object LogMessage)
        {
            if (IsWarnEnabled)
            {
                _log.Warn(LogMessage);
            }
        }
        public void Fatal(Object LogMessage)
        {
            if (IsFatalEnabled)
            {
                _log.Fatal(LogMessage);
            }
        }
        public void Error(Object LogMessage)
        {
            if (IsErrorEnabled)
            {
                _log.Error(LogMessage);
            }
        }
    }
}
