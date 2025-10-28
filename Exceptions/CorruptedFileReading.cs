using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLibrary.Exceptions
{
    [Serializable]
    internal class CorruptedFileReadingException : Exception
    {
        public CorruptedFileReadingException() { }
        public CorruptedFileReadingException(string message) : base(message) { }

        public CorruptedFileReadingException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
