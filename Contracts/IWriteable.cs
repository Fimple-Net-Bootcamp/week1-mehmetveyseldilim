namespace LibraryManagementConsoleApp.Contracts 
{
    public interface IWriteable<T>
    {
        public void WriteToConsole(T data);
    }
}