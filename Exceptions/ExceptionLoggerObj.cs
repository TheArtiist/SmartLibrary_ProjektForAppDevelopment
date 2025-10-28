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
            if(exceptions.Count == 0) return;
            
            string filename = $"Exceptions_{DateTime.Now:yyyyMMdd_HHmmss}.json";
            string jsonOutput = JsonSerializer.Serialize(exceptions,new JsonSerializerOptions 
            { 
                WriteIndented = true 
            });

            File.WriteAllText(filename, jsonOutput);
        }
    }
}
