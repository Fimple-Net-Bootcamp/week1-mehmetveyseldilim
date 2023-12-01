using LibraryManagementConsoleApp.Contracts;
using LibraryManagementConsoleApp.Data;
using LibraryManagementConsoleApp.Exceptions;
using LibraryManagementConsoleApp.Models;

namespace LibraryManagementConsoleApp.Services 
{
    public class MemberService : IMemberService, IWriteable<Member>
    {
        private readonly InMemoryApplicationDB _context;

        public MemberService(InMemoryApplicationDB context) 
        {
            _context = context;
        }

        public void AddMember(Member member) 
        {
            if(DoesMemberExist(member.Id, member.MemberNo)) 
            {
                throw new MemberIdAlreadyExists(member.Id);
            }
            
            _context.Members.Add(member);
            Console.WriteLine("Member added");
        }
        public Member GetMemberById(int memberId)
        {
            var member = _context.Members.FirstOrDefault(x => x.Id == memberId);

            if(member == null) 
            {
                throw new MemberNotFound(memberId);
            }

            return member;
        }
        public void WriteToConsole(Member data)
        {
            Console.WriteLine($"Member Id: {data.Id}, Member Name: {data.Name}, Member LastName: {data.LastName}, Member No: {data.MemberNo}");
            Console.Write("Borrowed Book Ids ==>");

            foreach (var bookId in data.CollectedBooks)
            {
                Console.Write($"Book with Id {bookId.Id}");
            }

            Console.WriteLine();
        }
        public void HaveMemberBorrowBook(Member member, Book book)
        {
            member.CollectedBooks.Add(book);
        }
        public void HaveMemberReturnBook(Member member, Book book)
        {
            member.CollectedBooks.Remove(book);
        }

        private bool DoesMemberExist(int memberId, string memberNo) 
        {
            var flag = _context.Members.Any(x => x.Id == memberId || x.MemberNo == memberNo);

            return flag;
        }

        public IEnumerable<Member> GetAllMembers()
        {
            var members = _context.Members.ToList();

            return members;
        }


    }
}