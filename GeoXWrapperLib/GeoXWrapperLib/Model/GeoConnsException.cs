using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperLib.Model
{
    public class GeoConnsException : ApplicationException
    {
        // Default constructor
        public GeoConnsException() : base() { }

        // Constructor that accepts a message
        public GeoConnsException(string message) : base(message) { }

        // Constructor that accepts a message and an inner exception
        public GeoConnsException(string message, Exception inner) : base(message, inner) { }
    }
}
