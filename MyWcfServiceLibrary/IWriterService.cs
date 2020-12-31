using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWcfServiceLibrary
{
    [ServiceContract]
    public interface IWriterService
    {
        [OperationContract]
        string GetWriter(string name);

        [OperationContract]
        List<Book> GetBooks(string writer);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "MyWcfServiceLibrary.ContractType".
    [DataContract]
    public class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }
}
