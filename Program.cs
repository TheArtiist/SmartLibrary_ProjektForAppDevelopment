using SmartLibrary.Exceptions;
using SmartLibrary.Library;

namespace SmartLibrary
{
    internal class Program
    {  
        public static ExceptionLoggerObj logger = new ExceptionLoggerObj();
        static void Main(string[] args)
        {
            var repo = new LibraryRepository();

            repo.Loader("books.json");

            foreach (var book in repo.GetAllBooks())
            {
                Console.WriteLine($"{book.title} - {book.author} - {book.publicationYear} - {book.genre}");
            }

            logger.writeToFile();
        }
    }
}
