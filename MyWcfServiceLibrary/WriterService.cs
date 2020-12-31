using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class WriterService : IWriterService
    {
        public string GetWriter(string name)
        {
            return name;
        }

        public List<Book> GetBooks(string writer)
        {
            if (writer == "Shakespeare")
            {
                List<Book> books = new List<Book>() { new Book() { Title = "Macbeth", Price = 2.35 } };
                return books;
            }
            else
                return null;
        }
    }
}
