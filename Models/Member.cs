namespace LibraryManagementConsoleApp.Models 
{
    public class Member
    {
        public int Id {get; set;}
        public string Name {get; set;} = "";

        public string LastName {get; set;} = "";

        public string MemberNo {get; set;} = "";

        public List<Book> CollectedBooks {get; set;} = new List<Book>();
    }
}