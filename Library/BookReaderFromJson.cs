using SmartLibrary.BookElements;
using SmartLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SmartLibrary.Library
{
    internal class BookReaderFromJson: IBookReaderFromJson
    {
        private string filePath;
        public BookReaderFromJson(string filePath) 
        {
            this.filePath = filePath;
        }

        public List<Books> readBooksFromJson()
        {
            List<Books> tmp = new List<Books>();

            try
            {
                if (!File.Exists(this.filePath)) throw new CorruptedFileReadingException("Nem található a fájl");

                string json = File.ReadAllText(this.filePath);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
                };
                tmp = JsonSerializer.Deserialize<List<Books>>(json, options);

                if (tmp is null)
                {
                    throw new CorruptedFileReadingException("Hiba történt a beolvasás során");
                }
            }
            catch (CorruptedFileReadingException CorruptedFile)
            {
                Program.logger.addExcept(CorruptedFile);

            }
            catch (Exception exception)
            {
                Program.logger.addExcept(exception);
            }

            return tmp;

            }

    }
}
