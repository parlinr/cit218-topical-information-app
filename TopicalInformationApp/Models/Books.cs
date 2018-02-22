using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace TopicalInformationApp.Models
{
    [XmlRoot("books")]
    public class Books
    {
        [XmlElement("book")]
        public List<Book> books;
    }
}