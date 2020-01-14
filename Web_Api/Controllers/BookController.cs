using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_Api.Controllers
{
    public class BookController : ApiController
    {
        public string GetBook(string Title, int NumberOfPages, [FromBody] string Author)
        {
            return string.Format("le livre{0}; Nombre de page{1}; Author{2}", Title, NumberOfPages, Author);
        }

        public string PostBook(string Title, int NumberOfPages, string Author)
        {
            return string.Format("le livre{0}; Nombre de page{1}; Author{2}", Title, NumberOfPages, Author);
        }

        public string GetBook(Book b)
        {
            return string.Format("le livre{0}; Nombre de page{1}; Author{2}", b.Title, b.NumberOfPages, b.Author);
        }

        public string PostBook(Book b)
        {
            return string.Format("le livre{0}; Nombre de page{1}; Author{2}", b.Title, b.NumberOfPages, b.Author);
        }

        public string PostBook(Book b, string Author)
        {
            return string.Format("le livre{0}; Nombre de page{1}; Author{2}", b.Title, b.NumberOfPages, Author);

        }
    }
}
