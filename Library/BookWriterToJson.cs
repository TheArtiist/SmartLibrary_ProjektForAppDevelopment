using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLibrary.Library
{
    internal class BookWriterToJson: IBookWriterToJson
    {
        private string filePath;
        public BookWriterToJson(string filePath)
        {
            this.filePath = filePath;
        }

        public void writeBooksToJson<T>(List<T> books)
        {
            try
            {
                string json = System.Text.Json.JsonSerializer.Serialize(books, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(this.filePath, json);
            }
            catch (Exception e)
            {
                Program.logger.addExcept(e);
            }
        }
    }
}
