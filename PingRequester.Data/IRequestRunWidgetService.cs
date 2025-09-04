using PingRequester.Data.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingRequester.Data
{
    /// <summary>
    /// Interface of the RequestRunWidgetService
    /// </summary>
    public interface IRequestRunWidgetService
    {
        public void OverwriteRequestRunUI(RequestRun requestRun);
    }
}
