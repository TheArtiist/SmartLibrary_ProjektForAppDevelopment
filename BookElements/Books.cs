using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLibrary.BookElements
{
    internal class Books
    {

        public string title { get; }
        public string author { get; set; }
        public int publicationYear { get; set; }
        public int? pages { get; set; }
        public int price { get; set; }
        public Genre genre { get; set; }

        public Books(string title, string author, int publicationYear, int? pages, int price, Genre genre)
        {
            this.title = title;
            this.author = author;
            this.publicationYear = publicationYear;
            this.pages = pages;
            this.price = price;
            this.genre = genre;
        }
    }
}
