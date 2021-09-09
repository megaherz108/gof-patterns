using Iterator.Iterator;
using System;

namespace Iterator
{
    class Program
    {
        static void Main()
        {
            var library = new Library();

            Console.WriteLine("Books by author:");
            OutputBooks(library.GetAuthorEnumerator());

            Console.WriteLine("Books by title:");
            OutputBooks(library.GetTitleEnumerator());

            Console.WriteLine("Books by year:");
            OutputBooks(library.GetYearEnumerator());

            Console.Read();
        }

        private static void OutputBooks(IBookEnumerator enumerator)
        {
            while (enumerator.HasNext())
            {
                Book book = enumerator.Next();
                Console.WriteLine($"{book.Author} \"{book.Title}\", {book.Year}");
            }
            Console.WriteLine();
        }
    }
}
