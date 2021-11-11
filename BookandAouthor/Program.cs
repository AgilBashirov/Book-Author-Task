using BookandAouthor.Extention;
using System;

namespace BookandAouthor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Manager manager = new Manager();
            Author author = new Author("George","Orwell");
            Author author2 = new Author("Robert","Greene");

            Book book1 = new Book("1984",author,15);
            Book book2 = new Book("1984",author,15);
            Book book3 = new Book("1984",author,15);


            author.AddBook(book1,manager).AddBook(book2, manager).AddBook(book3, manager);

            book1.SetAuthor(author2, manager);

            Console.WriteLine(book1.BookAuthor.Name);

        }
    }
}
