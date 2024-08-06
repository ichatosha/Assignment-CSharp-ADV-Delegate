using Assignment_CSharp_ADV_Delegate;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book> { new Book("Title1", "hesham fathy", "ISBN1", new DateTime(2000, 1, 1)),
                                         new Book("Title2", "ahmed ahmed", "ISBN2", new DateTime(2001, 2, 2)),
                                         new Book("Title3", "mohamed mohemed", "ISBN3", new DateTime(2002, 3, 3)) };

            BookProcessor processor = new BookProcessor();
            processor.ProcessBooks(books, delegate (Book book) { return book.ISBN; });

            processor.ProcessBooks(books, BookInfoDelegate)
            processor.ProcessBooks(books, book => book.PublicationDate.ToString());

            processor.ProcessBooks(books, new BookInfoDelegate(BookFunctions.GetTitle));

        }
    }
}
