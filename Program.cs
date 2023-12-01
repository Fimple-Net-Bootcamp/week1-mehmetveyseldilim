using LibraryManagementConsoleApp.Contracts;
using LibraryManagementConsoleApp.Data;
using LibraryManagementConsoleApp.Exceptions;
using LibraryManagementConsoleApp.Models;
using LibraryManagementConsoleApp.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagementConsoleApp.Program 
{
    public class Program 
    {

        public static void Library() 
        {
            ServiceProvider serviceProvider = new ServiceCollection()   
                                            .AddScoped<IBookService, BookService>()
                                            .AddScoped<IMemberService, MemberService>()
                                            .AddScoped<ILibraryService, LibraryService>()
                                            .AddSingleton<InMemoryApplicationDB>()
                                            .BuildServiceProvider();

            IBookService bookService = serviceProvider.GetService<IBookService>()!;
            IMemberService memberServiceService = serviceProvider.GetService<IMemberService>()!;

            var libraryManagement = new LibraryService(bookService, memberServiceService);

            // Console.WriteLine("--> Listing All Members");
            // libraryManagement.WriteMembersToConsole();
            // Console.WriteLine("--> Listing All Books");
            // libraryManagement.WriteBooksToConsole();

            // When an non-existent member tries to get a book
            // Should Throw Member Not Found
            // libraryManagement.Borrow(-1, 5);

            // When existent member tries to get a non existent book
            // Should Throw Book Not Found
            libraryManagement.Borrow(2, -1);

            // // Adding a Book
            // var book = new Book() 
            // {
            //     Id = 11,
            //     Name = "War and Peace",
            //     PublishedYear = "1815",
            //     Writer = "Tolstoy",
                
            // };
            // libraryManagement.AddBookToLibrary(book);
            // libraryManagement.WriteBooksToConsole();


            // //* Member Should Be Able To Borrow
            // libraryManagement.Borrow(1, 5);
            // libraryManagement.WriteMembersToConsole();

            // //* Members Also Should Be Able To Return
            // libraryManagement.Return(1, 5);
            // libraryManagement.WriteMembersToConsole();
        }


        public static void Main(string[] args)
        {
            try
            {
                Library();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
   
        }
    }
}