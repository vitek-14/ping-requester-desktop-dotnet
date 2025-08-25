using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingRequester.Data.Base
{
    /// <summary>
    /// DataObject class is a parent of all DataObjects classes.
    /// </summary>
    public class DataObject
    {
        /// <summary>
        /// Default constructor of DataObject class.
        /// </summary>
        public DataObject()
        {
        }

        /// <summary>
        /// Sets property.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <returns>Bool describing success of the operation.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        protected bool SetProperty<T>(ref T property, T value)
        {
            if (value == null)
                throw new ArgumentNullException($"Error: {typeof(T).Name} cannot be null.");
            if (EqualityComparer<T>.Default.Equals(property, value))
                return false;

            property = value;
            return true;
        }
    }
}
