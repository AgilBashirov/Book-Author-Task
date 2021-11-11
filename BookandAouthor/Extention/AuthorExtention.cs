using System;
using System.Collections.Generic;
using System.Text;

namespace BookandAouthor.Extention
{
    public static partial class Extention
    {

        public static void SetAuthor(this Book book, Author author, Manager manager)
        {
            manager.books.Find(x => x == book).BookAuthor = author;
        }
    }
    
}
