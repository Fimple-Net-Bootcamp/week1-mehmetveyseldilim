using LibraryManagementConsoleApp.Models;

namespace LibraryManagementConsoleApp.Contracts 
{
    public interface IMemberService: IWriteable<Member>
    {
        void AddMember(Member member);

        Member GetMemberById(int memberId);

        void HaveMemberBorrowBook(Member member, Book book);

        void HaveMemberReturnBook(Member member, Book book);

        IEnumerable<Member> GetAllMembers();
    }
}