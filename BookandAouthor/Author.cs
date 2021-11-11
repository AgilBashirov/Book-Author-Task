using System;
using System.Collections.Generic;
using System.Text;

namespace BookandAouthor
{
    public class Author
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Author(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
