using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Library
    {
        private List<Book> _books;
        private int _capacity = 10;

        public Library()
        {
            this._books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }
            else if (this._books.Count >= this._capacity)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                this._books.Add(book);
            }
        }
        
        public Book GetBook(int index)
        {
            Book foundBook = _books.FirstOrDefault(book => book.BookNumber == index);
            foundBook = _books.FindLast(book => book.BookNumber == index);
            if(foundBook == null)
            {
                throw new BookNotFoundException();
            }
            else
            {
                return foundBook;
            }
        }
    }
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException() : base("Book not found")
        {
        }
    }
}
