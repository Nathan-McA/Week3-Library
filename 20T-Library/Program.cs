class Book
{
    //Properties
    String Title;
    String Author;
    String ISBN;
    int NoOfPages;

    //Constructor for Book object
    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        NoOfPages = bookNoOfPages;
    }

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
        //Creaste a new instance of the book class
        Book book = new Book("C# for beginners","Bill Gates","1234567", 200);

        //Another instance
        Book book2 = new Book("Visual Studio 2022", "Microsoft", "123", 70);

        // Output book information to the console
        book.DisplayInfo();
        book2.DisplayInfo();
    }
}