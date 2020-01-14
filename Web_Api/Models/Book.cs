using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Api.Models
{
    public class Book
    {
        public string Title { get; set; }
        public int NumberOfPages { get; set; }
        public string Author { get; set; }
    }
}