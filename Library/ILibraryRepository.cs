using SmartLibrary.BookElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLibrary.Library
{
    public interface ILibraryRepository<T> where T : class
    {
        public void Loader(string path);
        public void Saver(string fileName);
    }
}
