using LibraryManagementConsoleApp.Contracts;
using LibraryManagementConsoleApp.Data;
using LibraryManagementConsoleApp.Exceptions;
using LibraryManagementConsoleApp.Models;

namespace LibraryManagementConsoleApp.Services 
{
    public class BookService : IBookService, IWriteable<Book>
    {
        private readonly InMemoryApplicationDB _context;

        public BookService(InMemoryApplicationDB context) 
        {
            _context = context;
        }

        public void AddBook(Book book) 
        {
            if(DoesBookExist(book.Id)) 
            {
                throw new BookIdAlreadyExists(book.Id);
            }

            _context.Books.Add(book);
            Console.WriteLine("Book added");
        }

        public IEnumerable<Book> GetAllBooks()
        {
            var books = _context.Books.ToList();
            
            return books;
        }

        public Book GetBookById(int bookId)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == bookId);

            if(book == null) 
            {
                throw new BookNotFound(bookId);
            }

            return book;
        }

        public void WriteToConsole(Book data)
        {
            Console.WriteLine($"Book Id: {data.Id}, Writer Name : {data.Writer} Book Name: {data.Name}, Publish Year: {data.PublishedYear}");
            
            
        }

        private bool DoesBookExist(int bookId) 
        {
            var flag = _context.Books.Any(x => x.Id == bookId);

            return flag;
        }
    }
}