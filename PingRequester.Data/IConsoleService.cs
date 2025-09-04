using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingRequester.Data
{
    public interface IConsoleService
    {
        public void LogInfo(string message, bool logInfoLabel = false);
        public void LogWarning(string message, bool logInfoLabelse = false);
        public void LogError(string message, bool logInfoLabel = false);
        public void LogMessage(string message, bool logInfoLabelse = false);
    }
}
