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

        public LibraryRepository() { }
        public void Loader(string path)
        {
            try { 
            using StreamReader reader = new StreamReader(path);
            var json = reader.ReadToEnd();
            var book = JsonSerializer.Deserialize<Books>(json);
            if(book is null)
            {
                throw new CorruptedFileReadingException("Hiba történt a beolvasás során");
            }
            books.Add(book);
            }catch(CorruptedFileReadingException e)
            {
                //ToDo
            }
            
        }

        public void Saver(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
