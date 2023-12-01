namespace LibraryManagementConsoleApp.Exceptions
{
    public class MemberNotFound : Exception
    {

        public MemberNotFound(int id) : base($"Member with id {id} not found")
        {

        }

        
    }
}
