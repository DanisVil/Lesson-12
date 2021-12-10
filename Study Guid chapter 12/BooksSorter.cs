using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Guid_chapter_12
{
    static class BooksSorter
    {
        private static int CompareBooksByName(Book x, Book y)
        {
            if (x.Name.ToLower().Equals(y.Name.ToLower())) return 0;
            ushort minLength = (ushort)Math.Min(x.Name.Length, y.Name.Length);
            ushort iter = 0;
            while (iter < minLength)
            {
                if (x.Name.ToLower()[iter] < y.Name.ToLower()[iter])
                {
                    return -1;
                }
                else if (x.Name.ToLower()[iter] > y.Name.ToLower()[iter])
                {
                    return 1;
                }
                iter++;
            }
            if (x.Name.Length < y.Name.Length)
            {
                return -1;
            }
            return 1;
        }
        private static int CompareBooksByAuthor(Book x, Book y)
        {
            if (x.Author.ToLower().Equals(y.Author.ToLower())) return 0;
            ushort minLength = (ushort)Math.Min(x.Author.Length, y.Author.Length);
            ushort iter = 0;
            while (iter < minLength)
            {
                if (x.Author.ToLower()[iter] < y.Author.ToLower()[iter])
                {
                    return -1;
                }
                else if (x.Author.ToLower()[iter] > y.Author.ToLower()[iter])
                {
                    return 1;
                }
                iter++;
            }
            if (x.Author.Length < y.Author.Length)
            {
                return -1;
            }
            return 1;
        }
        private static int CompareBooksByPublisher(Book x, Book y)
        {
            if (x.Publisher.ToLower().Equals(y.Publisher.ToLower())) return 0;
            ushort minLength = (ushort)Math.Min(x.Publisher.Length, y.Publisher.Length);
            ushort iter = 0;
            while (iter < minLength)
            {
                if (x.Publisher.ToLower()[iter] < y.Publisher.ToLower()[iter])
                {
                    return -1;
                }
                else if (x.Publisher.ToLower()[iter] > y.Publisher.ToLower()[iter])
                {
                    return 1;
                }
                iter++;
            }
            if (x.Publisher.Length < y.Publisher.Length)
            {
                return -1;
            }
            return 1;
        }
        public static void SortBookshelfByName(List<Book> books)
        {
            books.Sort(CompareBooksByName);
        }
        public static void SortBookshelfByAuthor(List<Book> books)
        {
            books.Sort(CompareBooksByAuthor);
        }
        public static void SortBookshelfByPublisher(List<Book> books)
        {
            books.Sort(CompareBooksByPublisher);
        }
    }
}
