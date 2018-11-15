using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigerFramework.Core.Logging;

namespace TigerFramework.Core.SeriLog
{
    public class SerilogAdapter : ILogger
    {
        private Serilog.ILogger _logger;
        public SerilogAdapter(Serilog.ILogger logger)
        {
            this._logger = logger;
        }
        public void Debug(string template, params string[] parameters)
        {
            this._logger.Debug(template, parameters);
        }

        public void Error(Exception ex)
        {
            if (this._logger.IsEnabled(Serilog.Events.LogEventLevel.Error))
            {
                var message = ex.ToString();
                this._logger.Error(message);
            }
        }

        public void Warn(string template, params string[] parameters)
        {
            this._logger.Warning(template, parameters);
        }
    }
}
