using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLibrary.Exceptions
{
    internal class ExceptionLoggerObj
    {
        public Type type { get; set; }
        public string message { get; set; }

        public ExceptionLoggerObj(Exception e)
        {
            this.type = e.GetType();
            this.message = e.Message;
        }
    }
}
