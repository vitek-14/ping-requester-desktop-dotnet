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
        public static void ConnectionSuccessful(bool silentMode)
        {
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Ping-Requester.png");
            Console.WriteLine(imagePath);
            new ToastContentBuilder()
                .AddAudio(new Uri("ms-winsoundevent:Notification.Default"), silent: silentMode)
                .AddText("Success")
                .AddText("Ping request was successful")
                .AddAppLogoOverride(new Uri($"file:///{imagePath}"), ToastGenericAppLogoCrop.Default)
                .Show();
        }
    }
}
