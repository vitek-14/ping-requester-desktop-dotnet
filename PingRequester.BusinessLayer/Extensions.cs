using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingRequester.BusinessLayer
{
    public static class Extensions
    {
        /// <summary>
        /// Converts to string time stamp according to the given template.
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <param name="template"></param>
        public static string ToTimeStampFormat(this DateTime timeStamp, string template)
        {
            return timeStamp.ToString(template);
        }

        /// <summary>
        /// Tries to parse and covert exact template to the DateTime type.
        /// </summary>
        /// <param name="fullFileName"></param>
        /// <param name="template"></param>
        /// <exception cref="Exception"></exception>
        public static DateTime ToDateTime(this string fullFileName, string template)
        {
            string fileName = Path.GetFileName(fullFileName);
            int start = fileName.IndexOf("_") + 1;
            int end = fileName.LastIndexOf(".");
            string timeStamp = fileName.Substring(start, end - start);

            if (DateTime.TryParseExact(
                timeStamp, 
                template, 
                null, 
                System.Globalization.DateTimeStyles.None, 
                out DateTime dateTime))
            {
                return dateTime;
            }

            throw new Exception("Could not parse timeStamp string format to the DateTime format. Possible issue: Unknown template");
        }
    }
}
