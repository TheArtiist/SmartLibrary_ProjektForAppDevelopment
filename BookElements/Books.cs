using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLibrary.BookElements
{
    internal class Books
    {
        public required string title { get; set; }
        public required string author { get; set; }
        public required int publicationYear { get; set; }
        public required int? pages { get; set; }
        public required int price { get; set; }
        public required Genre genre { get; set; }
    }
}
