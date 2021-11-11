using System;
using System.Collections.Generic;
using System.Text;

namespace BookandAouthor
{
    public partial class Manager
    {
        public List<Book> books = new List<Book>();
        public List<Author> authors = new List<Author>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void AddAuthor(Author author)
        {
            authors.Add(author);
        }
    }
}
