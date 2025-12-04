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
    internal class LibraryRepository<T> : ILibraryRepository<T> where T : class
    {
        List<T> books;
        private IBookReaderFromJson? bookReader;
        private IBookWriterToJson? bookWriter;

        public LibraryRepository() 
        {
            books = new List<T>();
        }

        public List<T> GetAllBooks() => books;

        public void Loader(string path)
        {
            this.bookReader = new BookReaderFromJson(path);
            this.bookReader.readBooksFromJson();
        }

        public void Saver(string path)
        {
            this.bookWriter = new BookWriterToJson(path);
            this.bookWriter.writeBooksToJson<T>(books);
        }
    }
}
