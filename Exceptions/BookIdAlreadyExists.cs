namespace LibraryManagementConsoleApp.Exceptions
{
    public class BookIdAlreadyExists : Exception
    {
        public BookIdAlreadyExists(int id) : base($"Book with id {id} already exists")
        {

        }

    }
}
