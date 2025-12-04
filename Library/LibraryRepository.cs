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
        private IBookReaderFromJson bookReader;

        public LibraryRepository() 
        {
            books = new List<Books>();
        }

        public List<Books> GetAllBooks() => books;

        public void Loader(string path)
        {
            this.bookReader = new BookReaderFromJson(path);
            this.bookReader.readBooksFromJson();
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
