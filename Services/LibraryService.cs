using LibraryManagementConsoleApp.Contracts;
using LibraryManagementConsoleApp.Models;

namespace LibraryManagementConsoleApp.Services 
{
    public class LibraryService : ILibraryService
    {
        private readonly IBookService _bookService;
        private readonly IMemberService _memberService;


        public LibraryService(IBookService bookService, IMemberService memberService)
        {
            _bookService = bookService;
            _memberService = memberService;
        }

        public void AddBookToLibrary(Book book)
        {
            _bookService.AddBook(book);
        }

        public void AddMemberToLibrary(Member member)
        {
            _memberService.AddMember(member);
        }

        public void Borrow(int memberId, int bookId)
        {
            // Get member
            var member = _memberService.GetMemberById(memberId);

            // Get book
            var book = _bookService.GetBookById(bookId);

            // Borrow Operation
            _memberService.HaveMemberBorrowBook(member, book);

        }

        public void Return(int memberId, int bookId)
        {
            // Get member
            var member = _memberService.GetMemberById(memberId);

            // Get book
            var book = _bookService.GetBookById(bookId);

            // Borrow Operation
            _memberService.HaveMemberReturnBook(member, book);
        }

        public void WriteBooksToConsole()
        {
            var books = _bookService.GetAllBooks();

            foreach (var book in books)
            {
                _bookService.WriteToConsole(book);
            }
        }

        public void WriteMembersToConsole()
        {
            var members = _memberService.GetAllMembers();

            foreach (var member in members)
            {
                _memberService.WriteToConsole(member);
            }
        }
    }
}