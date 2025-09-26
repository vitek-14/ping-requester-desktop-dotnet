using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;

namespace PingRequester.BusinessLayer
{
    /// <summary>
    /// Static class that handles Windows notification toasts.
    /// </summary>
    public static class Notifications
    {
        /// <summary>
        /// Gets the default structure of the toast.
        /// </summary>
        /// <param name="silentMode"></param>
        /// <returns>ToastContentBuilder</returns>
        private static ToastContentBuilder GetToastTemplate(bool silentMode)
        {
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Ping-Requester.png");

            return new ToastContentBuilder()
                .AddAudio(new Uri("ms-winsoundevent:Notification.Default"), silent: silentMode)
                .AddAppLogoOverride(new Uri($"file:///{imagePath}"), ToastGenericAppLogoCrop.Default);
        }

        /// <summary>
        /// Calls 'Connection Successful' windows toast.
        /// </summary>
        /// <param name="silentMode"></param>
        public static void ConnectionSuccessful(bool silentMode)
        {
            var toast = GetToastTemplate(silentMode);

            toast.AddText("Success")
                .AddText("Ping request was successful!")
                .Show();
        }

        /// <summary>
        /// Calls 'Pinging Finished' windows toast.
        /// </summary>
        /// <param name="silentMode"></param>
        public static void PingingFinished(bool silentMode)
        {
            var toast = GetToastTemplate(silentMode);

            toast.AddText("Ping requesting finished")
                .Show();
        }
    }
}
