using SmartLibrary.BookElements;
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

        public LibraryRepository() { }
        public void Loader(string path)
        {
            using StreamReader reader = new StreamReader(path);
            var json = reader.ReadToEnd();
            var book = JsonSerializer.Deserialize<Books>(json);
            if(book is null)
            {
                throw new Exception("Hiba történt a beolvasás során");
            }
            books.Add(book);

            throw new NotImplementedException();
        }

        public void Saver(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
