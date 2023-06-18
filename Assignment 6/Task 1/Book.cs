using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Book
    {
        private string? _title;
        private string? _author;
        private string? _description;
        private DateOnly _year;

        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
        public DateOnly Year { get; set; }
    }
    internal class Library
    {
        private Book[] _books = new Book[10];

        public Book this[int index]
        {
            get { return _books[index]; }
            set { _books[index] = value; }
        }

        public int _count
        { get { return _books.Count(book => book != null); } }

        public void AddBook(Book book)
        {
            int index = Array.IndexOf(_books, null);
            if (index >= 0)
            {
                _books[index] = book;
            }
            else
            {
                Array.Resize(ref _books, _books.Length + 1);
                _books[_books.Length] = book;
            }
        }

        public void RemoveBook(int index)
        {
            _books[index] = new Book();
        }

        public Book? FindBook(string title)
        {
            foreach (Book book in _books)
            {
                if (book.Title == title) return book;
            }
            return null;
        }
    }

}
