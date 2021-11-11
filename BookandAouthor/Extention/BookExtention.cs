using System;
using System.Collections.Generic;
using System.Text;

namespace BookandAouthor.Extention
{
    public static partial class Extention
    {
        public static Author AddBook(this Author author, Book book, Manager manager)
        {
            manager.books.Add(book);

            return author;
        }
    }
}
