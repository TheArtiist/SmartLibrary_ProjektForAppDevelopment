using SmartLibrary.Exceptions;

namespace SmartLibrary
{
    internal class Program
    {  
        public static ExceptionLoggerObj logger = new ExceptionLoggerObj();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            logger.writeToFile();
        }
    }
}
