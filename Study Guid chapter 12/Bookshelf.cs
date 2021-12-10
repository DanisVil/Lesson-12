using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Guid_chapter_12
{
    delegate void SortList(List<Book> books);
    class Bookshelf
    {
        private SortList sort = BooksSorter.SortBookshelfByName;
        private List<Book> books;
        public Bookshelf(int count)
        {
            books = new List<Book>(count);
        }
        public Bookshelf(params Book[] books)
        {
            this.books = new List<Book>(books);
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
        public List<Book> GetBooks()
        {
            return books;
        }
        public void Sort()
        {
            sort(books);
        }
        public override string ToString()
        {
            string output = "";
            foreach(Book book in books)
            {
                output += book.ToString() + "\n";
            }
            return output;
        }
        public void SetSortingMethod(string method)
        {
            if (method.ToLower().Contains("названи"))
            {
                sort = BooksSorter.SortBookshelfByName;
            }
            else if (method.ToLower().Contains("автор"))
            {
                sort = BooksSorter.SortBookshelfByAuthor;
            }
            else if (method.ToLower().Contains("изд"))
            {
                sort = BooksSorter.SortBookshelfByPublisher;
            }
        }
    }
}
