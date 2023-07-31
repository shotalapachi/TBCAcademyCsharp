using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Book
    {
        private int _bookNumber;
        private string _bookName;
        private string _authorName;

        public Book(int bookNumber, string bookName, string authorName)
        {
            if (bookName == null)
            {
                throw new ArgumentNullException(nameof(bookName));
            }
            else
            {
                this._bookName = bookName;
            }
            if (authorName == null)
            {
                throw new ArgumentNullException(nameof(authorName));
            }
            else
            {
                this._authorName = authorName;
            }
            if (bookNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(bookNumber));
            }
            else
            {
                this._bookNumber = bookNumber;
            }
        }

        public int BookNumber
        {
            get { return _bookNumber; }
            set { _bookNumber = value; }
        }
        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }
        public string AuthorName
        {
            get { return _authorName; }
            set { _authorName = value; }
        }
    }
}
