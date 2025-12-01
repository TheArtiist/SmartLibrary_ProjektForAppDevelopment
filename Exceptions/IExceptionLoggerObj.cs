using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLibrary.Exceptions
{
    public interface IExceptionLoggerObj
    {
        public void addExcept(Exception e);
        public void writeToFile();
    }
}
