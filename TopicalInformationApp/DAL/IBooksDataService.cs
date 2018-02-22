using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopicalInformationApp.Models;

namespace TopicalInformationApp.DAL
{
    public interface IBooksDataService
    {
        List<Book> Read();
        void Write(List<Book> Books);
    }
}