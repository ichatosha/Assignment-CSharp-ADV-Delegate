using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_CSharp_ADV_Delegate
{
    public delegate string BookInfoDelegate(Book book);

    public class BookProcessor
    {       
            public void ProcessBooks(List<Book> books, BookInfoDelegate bookInfo)
            {
                foreach (var book in books)
                {
                    Console.WriteLine(bookInfo(book));
                }
            }

            public void ProcessBooks(List<Book> books, Func<Book, string> bookInfo)
            {
                foreach (var book in books)
                {
                    Console.WriteLine(bookInfo(book));
                }
            }
    }
}
