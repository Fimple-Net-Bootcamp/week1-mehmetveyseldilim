using LibraryManagementConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace LibraryManagementConsoleApp.Data 
{
    public class InMemoryApplicationDB
    {
        public  List<Book> Books = new List<Book>();

        public  List<Member> Members = new List<Member>();

        public InMemoryApplicationDB()
        {
            SeedBook();
            SeedMember();
        }



        private void SeedBook() 
        {
            var bookList = new List<Book>() 
            {
                new Book { Name = "C# Programlama", Writer = "John Doe", PublishedYear = "2022", Id = 1 },
                new Book { Name = "Algoritma Temelleri", Writer = "Jane Smith", PublishedYear = "2021", Id = 2 },
                new Book { Name = "Python Başlangıç", Writer = "Ahmet Yılmaz", PublishedYear = "2023", Id = 3 },
                new Book { Name = "Veritabanı Yönetimi", Writer = "Mehmet Kara", PublishedYear = "2020", Id = 4 },
                new Book { Name = "Web Programlama", Writer = "Ayşe Ak", PublishedYear = "2022", Id = 5 },
                new Book { Name = "Mobil Uygulama Geliştirme", Writer = "Ali Can", PublishedYear = "2021", Id = 6 },
                new Book { Name = "Algoritma ve Veri Yapıları", Writer = "Nazlı Demir", PublishedYear = "2019", Id = 7 },
                new Book { Name = "Java Temelleri", Writer = "Kaan Oğuz", PublishedYear = "2020", Id = 8 },
                new Book { Name = "Makine Öğrenimi", Writer = "Burak Ercan", PublishedYear = "2023", Id = 9 },
                new Book{ Name = "Network Programlama", Writer = "Zeynep Yıldız", PublishedYear = "2021", Id = 10 }
            };

            Books.AddRange(bookList);
        }

        private void SeedMember() 
        {
            var memberList = new List<Member>() 
            {
                new Member { Name = "Ahmet", LastName = "Yılmaz", MemberNo = "101", Id = 1 },
                new Member { Name = "Ayşe", LastName = "Kara", MemberNo = "102" , Id = 2},
                new Member { Name = "Mehmet", LastName = "Yıldız", MemberNo = "103", Id = 3 },
                new Member { Name = "Zeynep", LastName = "Demir", MemberNo = "104", Id = 4 },
                new Member { Name = "Kaan", LastName = "Oğuz", MemberNo = "105" , Id = 5},

            };

            Members.AddRange(memberList);
        }



    }
}