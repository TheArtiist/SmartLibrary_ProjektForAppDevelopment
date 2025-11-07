using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLibrary.Exceptions
{
    internal class SerializableException
    {
        public string Message { get; set; }
        public string StackTrace { get; set; }
        
        public SerializableException(Exception ex)
        {
            Message = ex.Message;
            StackTrace = ex.StackTrace;
        }
    }
}
