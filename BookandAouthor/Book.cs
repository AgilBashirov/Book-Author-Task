using System;
using System.Collections.Generic;
using System.Text;

namespace BookandAouthor
{
    public class Book
    {
        public string Name { get; set; }
        public Author BookAuthor { get; set; }
        public double Price { get; set; }

        public Book(string name, Author author, double price)
        {
            Name = name;
            BookAuthor = author;
            Price = price;
        }
    }
}
