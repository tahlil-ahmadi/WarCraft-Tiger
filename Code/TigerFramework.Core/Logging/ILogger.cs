using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigerFramework.Core.Logging
{
    public interface ILogger
    {
        void Error(Exception ex);
        void Debug(string template, params string[] parameters);
        void Warn(string template, params string[] parameters);
    }
}
