using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SmartLibrary.Exceptions
{
    internal class ExceptionLoggerObj: IExceptionLoggerObj
    {
        List<SerializableException> exceptions;

        public ExceptionLoggerObj()
        {
            exceptions = new List<SerializableException>();
        }

        public void addExcept(Exception e)
        {
            SerializableException ex = new SerializableException(e);
            this.exceptions.Add(ex);
        }

        public void writeToFile()
        {
            if(exceptions.Count == 0) return;
            
            string filename = $"Exceptions_{DateTime.Now:yyyy_MM_dd;HH.mm.ss}.json";
            string jsonOutput = JsonSerializer.Serialize(exceptions,new JsonSerializerOptions 
            { 
                WriteIndented = true 
            });

            File.WriteAllTextAsync(filename, jsonOutput);
        }
    }
}
