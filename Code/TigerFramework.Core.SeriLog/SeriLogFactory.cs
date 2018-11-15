using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigerFramework.Core.SeriLog
{
    public static class SeriLogFactory
    {
        public static ILogger Create()
        {
            return new LoggerConfiguration()
                    .WriteTo.RollingFile("log-{Date}.txt", fileSizeLimitBytes: 50000000)
                    .CreateLogger();
        }
    }
}
