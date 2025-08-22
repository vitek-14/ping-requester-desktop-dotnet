using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingRequester.App
{
    public class WidgetController
    {
        public static bool GetNumberOfTriesState(bool infiniteLoop)
        {
            return !infiniteLoop;
        }
    }
}
