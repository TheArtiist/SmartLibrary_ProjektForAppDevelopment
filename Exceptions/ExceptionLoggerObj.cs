using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SmartLibrary.Exceptions
{
    internal class ExceptionLoggerObj
    {
        List<Exception> exceptions;

        public ExceptionLoggerObj()
        {
            exceptions = new List<Exception>();
        }

        public void addExcept(Exception e)
        {
            this.exceptions.Add(e);
        }

        public void writeToFile()
        {
            string filename = "exceptions";
            string jsonOutput = JsonSerializer.Serialize(exceptions);
            File.WriteAllText(filename, jsonOutput);
        }
    }
}
