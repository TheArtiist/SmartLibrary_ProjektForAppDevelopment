using SmartLibrary.Controller;
using SmartLibrary.Exceptions;
using SmartLibrary.Library;

namespace SmartLibrary
{
    internal class Program
    {  
        public static IExceptionLoggerObj logger = new ExceptionLoggerObj();
        static void Main(string[] args)
        {
            var repo = new LibraryRepository();

            repo.Loader($"C:\\Users\\TheArtist\\Desktop\\Programing\\VisualStudio\\SmartLibrary\\books.json");


            int action = 0;
            var books = repo.GetAllBooks();

            Console.WriteLine("Select an action:");
            
            try {
                action = Convert.ToInt32(Console.ReadLine() ?? string.Empty);
            }catch(FormatException fm)
            {
                logger.addExcept(fm); 
            }

            ActionController ac = new ActionController(books);
            ac.Action(action);

            logger.writeToFile();
        }
    }
}
