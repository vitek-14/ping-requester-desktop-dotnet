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
        private bool showNotification;
        private bool makeSound;

        /// <summary>
        /// Default constructor of the class.
        /// </summary>
        public Settings()
        {
        }

        [JsonPropertyName("show notification")]
        public bool ShowNotification
        {
            get => showNotification;
            set => SetProperty(ref showNotification, value);
        }

        [JsonPropertyName("make sound")]
        public bool MakeSound
        {
            get => makeSound;
            set => SetProperty(ref makeSound, value);
        }
    }
}
