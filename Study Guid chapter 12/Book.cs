using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Guid_chapter_12
{
    class Book
    {
        private string name, author, publisher;
        public Book(string author, string name, string publisher)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
        }
        public string Publisher
        {
            get { return publisher; }
        }
        public override string ToString()
        {
            return $"{Author}, {Name}, {Publisher}";
        }
    }
}
