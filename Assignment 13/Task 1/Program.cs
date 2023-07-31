using Task_1;

Library library = new Library();

Book book1 = new Book(1, "Book 1", "Author 1");
Book book2 = new Book(2, "Book 2", "Author 2");
Book book3 = new Book(3, "Book 3", "Author 3");

try
{
    library.AddBook(book1);
    library.AddBook(book2);
    library.AddBook(book3);

    library.AddBook(null);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("ArgumentNullException: " + ex.Message);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
}

try
{
    Book retrievedBook = library.GetBook(2);
    Console.WriteLine("Retrieved Book: " + retrievedBook.BookName);
}
catch (BookNotFoundException ex)
{
    Console.WriteLine("BookNotFoundException: " + ex.Message);
}

try
{
    Book nonExistingBook = library.GetBook(10);
}
catch (BookNotFoundException ex)
{
    Console.WriteLine("BookNotFoundException: " + ex.Message);
}

