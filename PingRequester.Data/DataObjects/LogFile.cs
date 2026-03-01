using PingRequester.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingRequester.Data.DataObjects
{
    /// <summary>
    /// LogFile class stores metadata of the log file.
    /// </summary>
    public class LogFile : DataObject
    {
        private string path;
        private DateTime timeStamp;

        /// <summary>
        /// Default constructor of the class.
        /// </summary>
        public LogFile()
        {
        }

        public string Path
        {
            get => path;
            set => SetProperty(ref path, value);
        }

        public DateTime TimeStamp
        {
            get => timeStamp;
            set => SetProperty(ref timeStamp, value);
        }
    }
}
