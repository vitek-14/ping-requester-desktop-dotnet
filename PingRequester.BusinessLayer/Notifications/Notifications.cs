using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;

namespace PingRequester.BusinessLayer
{
    public static class Notifications
    {
        private static ToastContentBuilder GetToastTemplate(bool silentMode)
        {
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Ping-Requester.png");

            return new ToastContentBuilder()
                .AddAudio(new Uri("ms-winsoundevent:Notification.Default"), silent: silentMode)
                .AddAppLogoOverride(new Uri($"file:///{imagePath}"), ToastGenericAppLogoCrop.Default);
        }

        public static void ConnectionSuccessful(bool silentMode)
        {
            var toast = GetToastTemplate(silentMode);

            toast.AddText("Success")
                .AddText("Ping request was successful!")
                .Show();
        }

        public static void PingingFinished(bool silentMode)
        {
            var toast = GetToastTemplate(silentMode);

            toast.AddText("Ping requesting finished")
                .Show();
        }
    }
}
