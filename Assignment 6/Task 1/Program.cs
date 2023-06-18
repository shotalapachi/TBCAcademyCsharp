using LibrarySystem;

Book book = new Book();
book.Title = "Test";
book.Author = "elguja";
Library library = new Library();
library[3] = book;
Console.WriteLine("number of books: " + library._count);
Book book1 = new Book();
book1.Title = "test1";
book1.Author = "manuchar";
library.AddBook(book1);
Console.WriteLine("number of books: " + library._count);
Book? book2 = library.FindBook("test1");
Console.WriteLine(book2.Author);
Console.WriteLine("number of books: " + library._count);
library.RemoveBook(0);
Console.WriteLine("number of books: " + library._count);