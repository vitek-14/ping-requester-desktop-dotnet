using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingRequester.Data.Base
{
    public class DataObject
    {
        public DataObject()
        {
        }

        protected static bool SetProperty<T>(ref T property, T value)
        {
            if (property == null)
                throw new ArgumentNullException($"Error: {nameof(property)} cannot be null.");
            if (property.Equals(value))
                return false;

            property = value;
            return true;
        }
    }
}
