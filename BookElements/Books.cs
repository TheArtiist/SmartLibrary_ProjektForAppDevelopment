using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SmartLibrary.BookElements
{
    public record Books
    {

        public string title { get; }
        public string author { get; }
        public int publicationYear { get; }
        public int? pages { get; }
        public int price { get; }
        public Genre genre { get; }

        [JsonConstructor]
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
