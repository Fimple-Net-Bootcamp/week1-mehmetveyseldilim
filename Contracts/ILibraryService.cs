using LibraryManagementConsoleApp.Models;

namespace LibraryManagementConsoleApp.Contracts 
{
    public interface ILibraryService
    {
        
        public void Return(int memberId, int bookId);

        public void Borrow(int memberId, int bookId);

        public void AddBookToLibrary(Book book);

        public void AddMemberToLibrary(Member member);

        public void WriteMembersToConsole();

        public void WriteBooksToConsole();
    }
}