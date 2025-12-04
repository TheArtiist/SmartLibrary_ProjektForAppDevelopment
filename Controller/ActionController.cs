using SmartLibrary.BookElements;
using SmartLibrary.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLibrary.Controller
{
    public class ActionController
    {
        private List<Books> _books;

        public ActionController(List<Books> books) 
        {
            this._books = books;
        }

        public void Action(int action)
        {
            switch (action)
            {
                //Összes repo-ban lévő könyv listázása
                case 1:
                    foreach (var book in _books)
                    {
                        Console.WriteLine($"{book.title} - {book.author} - {book.pages} - {book.genre}");
                    }
                    break;
                //IT könyvek listázása oldalszám szerint növekvő sorrendben
                case 2:
                    var filtered = _books.Where(b => b.genre == Genre.IT)
                                         .OrderBy(y => y.publicationYear);
                    foreach (var book in filtered)
                    {
                        Console.WriteLine($"{book.title} - {book.author} - {book.pages} - {book.genre}");
                    }
                    break;
                //Könyvek listázása kiadás éve szerint növekvő sorrendben
                case 3:
                    var sorted = _books.OrderBy(b => b.publicationYear);
                    foreach (var book in sorted)
                    {
                        Console.WriteLine($"{book.title} - {book.author} - {book.publicationYear}");
                    }
                    break;
                default:
                    action = -1;
                    break;
            }
        }


    }
}
