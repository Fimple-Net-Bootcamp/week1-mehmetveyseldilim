namespace LibraryManagementConsoleApp.Exceptions
{
    public class BookNotFound : Exception
    {
        public BookNotFound(int id) : base($"Book with id {id} not found")
        {

        }

    }
}
