using SmartLibrary.BookElements;
using SmartLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace SmartLibrary.Library
{
    internal class LibraryRepository : ILibraryRepository
    {
        List<Books> books;

        public LibraryRepository() 
        {
            books = new List<Books>();
        }

        public List<Books> GetAllBooks() => books;

        public void Loader(string path)
        {
            try
            {
                if (!File.Exists(path)) throw new CorruptedFileReadingException("Nem található a fájl");

                string json = File.ReadAllText(path);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
                };
                var loadedBooks = JsonSerializer.Deserialize<List<Books>>(json, options);

                if (loadedBooks is null)
                {
                    throw new CorruptedFileReadingException("Hiba történt a beolvasás során");
                }
                books.AddRange((IEnumerable<Books>)loadedBooks);

            }
            catch (CorruptedFileReadingException CorruptedFile)
            {
                Program.logger.addExcept(CorruptedFile);

            }
            catch (Exception exception)
            {
                Program.logger.addExcept(exception);
                Console.WriteLine(exception.ToString());


            }
        }

        public void Saver(string path)
        {
            try
            {
                string json = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(path,json);
            }catch(Exception e)
            {
                Program.logger.addExcept(e);
            }
        }
    }
}
