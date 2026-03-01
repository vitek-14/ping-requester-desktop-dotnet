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

        /// <summary>
        /// Default constructor of the class.
        /// </summary>
        public Settings()
        {
        }

        [JsonPropertyName("show notification")]
        public bool AlertOnSuccess
        {
            get => alertOnSuccess;
            set => SetProperty(ref alertOnSuccess, value);
        }

        [JsonPropertyName("make sound")]
        public bool MakeSound
        {
            get => makeSound;
            set => SetProperty(ref makeSound, value);
        }

        [JsonPropertyName("alert on ping completion")]
        public bool AlertOnPingCompletion
        {
            get => alertOnPingCompletion;
            set => SetProperty(ref alertOnPingCompletion, value);
        }

        [JsonPropertyName("log files path")]
        public string PathToLogFiles
        {
            get => pathToLogFiles;
            set => SetProperty(ref pathToLogFiles, value);
        }

        [JsonPropertyName("ask to save log")]
        public bool AskToSaveLog
        {
            get => askToSaveLog;
            set => SetProperty(ref askToSaveLog, value);
        }

        [JsonPropertyName("time stamp template")]
        public string TimeStampTemplate
        {
            get => timeStampTemplate;
            set => SetProperty(ref timeStampTemplate, value);
        }

        [JsonPropertyName("clear console before pr")]
        public bool ClearConsole
        {
            get => clearConsole;
            set => SetProperty(ref clearConsole, value);
        }
    }
}
