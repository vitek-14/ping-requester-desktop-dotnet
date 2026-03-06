using PingRequester.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PingRequester.Data.DataObjects
{
    /// <summary>
    /// Settings class.
    /// </summary>
    public class Settings : DataObject
    {
        private bool alertOnSuccess;
        private bool makeSound;
        private bool alertOnPingCompletion;
        private string pathToLogFiles;
        private bool askToSaveLog;
        private string timeStampTemplate;
        private bool clearConsole;
        private string consoleColorTheme;

        /// <summary>
        /// Default constructor of the class.
        /// </summary>
        public Settings()
        {
        }

        [JsonPropertyName("show_notification")]
        public bool AlertOnSuccess
        {
            get => alertOnSuccess;
            set => SetProperty(ref alertOnSuccess, value);
        }

        [JsonPropertyName("make_sound")]
        public bool MakeSound
        {
            get => makeSound;
            set => SetProperty(ref makeSound, value);
        }

        [JsonPropertyName("alert_on_ping_completion")]
        public bool AlertOnPingCompletion
        {
            get => alertOnPingCompletion;
            set => SetProperty(ref alertOnPingCompletion, value);
        }

        [JsonPropertyName("log_files_path")]
        public string PathToLogFiles
        {
            get => pathToLogFiles;
            set => SetProperty(ref pathToLogFiles, value);
        }

        [JsonPropertyName("ask_to_save_log")]
        public bool AskToSaveLog
        {
            get => askToSaveLog;
            set => SetProperty(ref askToSaveLog, value);
        }

        [JsonPropertyName("time_stamp_template")]
        public string TimeStampTemplate
        {
            get => timeStampTemplate;
            set => SetProperty(ref timeStampTemplate, value);
        }

        [JsonPropertyName("clear_console_before_pr")]
        public bool ClearConsole
        {
            get => clearConsole;
            set => SetProperty(ref clearConsole, value);
        }

        [JsonPropertyName("console_color_theme")]
        public string ConsoleColorTheme
        {
            get => consoleColorTheme;
            set => SetProperty(ref consoleColorTheme, value);
        }
    }
}
