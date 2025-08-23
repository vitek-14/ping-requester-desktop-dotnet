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
