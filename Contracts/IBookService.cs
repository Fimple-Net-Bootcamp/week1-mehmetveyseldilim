using LibraryManagementConsoleApp.Models;

namespace LibraryManagementConsoleApp.Contracts 
{
    public interface IBookService : IWriteable<Book>
    {
        void AddBook(Book book);

        Book GetBookById(int bookId);

        IEnumerable<Book> GetAllBooks();


    }
}