using Iterator.Iterator;
using System;

namespace Iterator
{
    class Library : IBookEnumerable
    {
        private Book[] _books = new Book[]
        {
            new Book
            {
                Author = "Пушкин А.С.",
                Title = "Капитанская дочка",
                Year = 1836
            },
            new Book
            {
                Author = "Ганди М.К.",
                Title = "Моя жизнь",
                Year = 1927
            },
            new Book
            {
                Author = "Джебран Х.Д.",
                Title = "Пророк",
                Year = 1923
            },
            new Book
            {
                Author = "Толстой Л.Н.",
                Title = "Анна Каренина",
                Year = 1875
            }
        };

        public Book this[int index]
        {
            get { return _books[index]; }
        }

        public int Count
        {
            get { return _books.Length; }
        }

        public IBookEnumerator GetAuthorEnumerator()
        {
            // Sort array by author
            Array.Sort(_books,(Book x, Book y) => { return x.Author.CompareTo(y.Author); });

            return new LibraryEnumerator(this);
        }

        public IBookEnumerator GetTitleEnumerator()
        {
            // Sort array by title
            Array.Sort(_books, (Book x, Book y) => { return x.Title.CompareTo(y.Title); });

            return new LibraryEnumerator(this);
        }

        public IBookEnumerator GetYearEnumerator()
        {
            // Sort array by year
            Array.Sort(_books, (Book x, Book y) => { return x.Year.CompareTo(y.Year); });

            return new LibraryEnumerator(this);
        }
    }
}
