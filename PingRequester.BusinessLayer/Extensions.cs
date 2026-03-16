using PingRequester.Data.DataObjects;
using PingRequester.Data.Entities;
using System.Text.RegularExpressions;

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

        /// <summary>
        /// Checks if template used for parsing string to the DateTime type is valid or not.
        /// </summary>
        /// <param name="template"></param>
        public static bool TryParseToDateTime(this string template)
        {
            string allowedPattern = @"^[yMdHmsfFzKtghHk.:\-_ /\\,\[\]]+$";
            string functionalPattern = @"[yMdHmsfFzK]";

            // check if template does not contain any unsupported characters
            if (!Regex.IsMatch(template, allowedPattern))
                return false;
            // check if template contains at least one of the functinoal characters
            if (!Regex.IsMatch(template, functionalPattern))
                return false;

            try
            {
                var x = DateTime.Now.ToString(template);
            }
            catch (FormatException)
            {
                return false;
            }

            return true;
        }

        public static Preferences MapToPreferences(this UserPreferences userPreferences)
        {
            var p = new Preferences();
            p.PingTarget = userPreferences.PingTarget;
            p.Mode = userPreferences.Mode;
            p.RefreshRate = userPreferences.RefreshRate;
            p.InfiniteLoop = userPreferences.InfiniteLoop;
            p.StopWhenSuccess = userPreferences.StopWhenSuccess;
            p.NumberOfPR = userPreferences.PingRequestCount;
            p.Attempts = userPreferences.Attempts;
            p.PacketSize = userPreferences.PacketSize;

            return p;
        }
    }
}
