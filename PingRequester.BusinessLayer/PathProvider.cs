using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingRequester.BusinessLayer
{
    public static class PathProvider
    {
        private static readonly string appName = "PingRequester";

        /// <summary>
        /// Returns a writable file path in the user's local application data directory, copying the file from the
        /// application's base directory if it does not already exist.
        /// </summary>
        /// <param name="relativePath">The relative path of the file to be accessed or copied.</param>
        /// <returns>The full path to the writable file in the local application data directory.</returns>
        public static string GetWritablePath(string relativePath)
        {
            string fileName = Path.GetFileName(relativePath);
            string appDataDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                appName,
                "config"
            );

            if (!Directory.Exists(appDataDir))
                Directory.CreateDirectory(appDataDir);

            string targetPath = Path.Combine(appDataDir, fileName);

            // if AppData does not exists, create it and copy the file to it
            if (!File.Exists(targetPath))
            {
                string sourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                if (File.Exists(sourcePath))
                {
                    File.Copy(sourcePath, targetPath);
                }
            }

            return targetPath;
        }

        /// <summary>
        /// Returns the full file path to the application's database file in the local application data directory,
        /// creating the directory if it does not exist.
        /// </summary>
        /// <returns>The full path to db file within the application's local data folder.</returns>
        public static string GetDatabasePath()
        {
            string appDataRoot = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                appName
            );

            if (!Directory.Exists(appDataRoot)) 
                Directory.CreateDirectory(appDataRoot);

            return Path.Combine(appDataRoot, "ping_requester.db");
        }
    }
}
