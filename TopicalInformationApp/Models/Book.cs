using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopicalInformationApp.Models
{
    public class Book
    {
        public string title { get; set; }
        public List<string> authors { get; set; }
        public string publicationYear { get; set; }
        public string summary { get; set; }

    }
}