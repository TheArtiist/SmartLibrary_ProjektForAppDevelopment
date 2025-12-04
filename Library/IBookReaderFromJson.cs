using SmartLibrary.BookElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLibrary.Library
{
    public interface IBookReaderFromJson
    {
        public List<Books> readBooksFromJson();
    }
}
