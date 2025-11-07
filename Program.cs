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
            Console.WriteLine("Select an action:");
            do
            {
                try {
                    action = Convert.ToInt32(Console.ReadLine() ?? string.Empty);
                }catch(FormatException fm)
                {
                    logger.addExcept(fm); 
                }
                switch (action)
                {
                    case 1:
                        var books = repo.GetAllBooks();
                        foreach (var book in books)
                        {
                            Console.WriteLine($"{book.title} - {book.author} - {book.pages} - {book.genre}");
                        }
                        break;
                    case 2:
                        //ToDo
                        break;
                    default:
                        action = -1;
                        break;
                }

            } while (action == -1);

            logger.writeToFile();
        }
    }
}
