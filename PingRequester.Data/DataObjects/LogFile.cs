using PingRequester.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingRequester.Data.DataObjects
{
    public class LogFile : DataObject
    {
        private string path;
        private DateTime lastChange;

        public LogFile()
        {
        }

        public string Path
        {
            get => path;
            set => SetProperty(ref path, value);
        }

        public DateTime LastChange
        {
            get => lastChange;
            set => SetProperty(ref lastChange, value);
        }
    }
}
