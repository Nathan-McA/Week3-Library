class Book
{
    String Title;
    String Author;
    String ISBN;
    int NoOfPages;

    void DisplayInfo()
    {
        Console.WriteLine("Book Information");
        Console.WriteLine("----------------");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"No of Pages: {NoOfPages}");
        Console.WriteLine();
    }

    static void Main(String[] args)
    {
        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        Book book = new Book();

        // This information is for one book in our library
        book.Title = "C# for beginners";
        book.Author = "BillGates";
        book.ISBN = "12345678";
        book.NoOfPages = 200;

        // This is another book object.
        // Note that the object name is 'book1' and not 'book'
        Book book2 = new Book();
        book2.Title = "C# Methods and classes";
        book2.Author = "Microsoft";
        book2.ISBN = "55667778";
        book2.NoOfPages = 50;

        // Output book information to the console
        book.DisplayInfo();
        book2.DisplayInfo();
    }
}