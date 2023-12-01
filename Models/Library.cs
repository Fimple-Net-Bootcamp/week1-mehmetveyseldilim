namespace LibraryManagementConsoleApp.Models 
{
    public class Library
    {
        public List<Book> Books {get; set;} = new List<Book>();

        private List<Member> Members {get; set;} = new List<Member>(); 

        
    }
}