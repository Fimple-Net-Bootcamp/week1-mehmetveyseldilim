namespace LibraryManagementConsoleApp.Exceptions
{
    public class MemberIdAlreadyExists : Exception
    {
       
        public MemberIdAlreadyExists(int id) : base($"Member with id {id} already exists")
        {
            
        }


    }
}
