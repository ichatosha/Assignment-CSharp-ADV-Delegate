using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_CSharp_ADV_Delegate
{
    public class BookFunctions
    {
        
        public string GetTitle(Book book)
        {
            return book.Title;
        }

        public string GetAuthor(Book book)
        {
            return book.Author;
        }

        public string GetISBN(Book book)
        {
            return book.ISBN;
        }

        public DateTime GetPublicationDate(Book book)
        {
            return book.PublicationDate;
        }
    }
}
