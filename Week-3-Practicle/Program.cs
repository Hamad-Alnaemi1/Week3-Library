using System.Net.Mail;

class Book
{
   
   //Defining Attributes 
    string Title;
    string Author;
    string ISBN;
   
    
    //adding methods fixes the need to continusouly add the above lines to output.

    void DisplayInfo()
    {
        Console.WriteLine($"Book Title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        Book book = new Book();

        book.Title = "C# for Beginners";
        book.Author = "BillGates";
        book.ISBN = "1234556789";

        //Console.WriteLine($"Book Title: {book.Title}");
        //Console.WriteLine($"Book Author: {book.Author}");
        //Console.WriteLine($"Book ISBN: {book.ISBN}");
        //Console.WriteLine();

        Book book1 = new Book();
        book1.Title = "C# Methods and classes";
        book1.Author = "Microsoft";
        book1.ISBN = "55667778";

        book.DisplayInfo();
        book1.DisplayInfo();


        //Console.WriteLine($"Book Title: {book1.Title}");
        //Console.WriteLine($"Book Author: {book1.Author}");
        //Console.WriteLine($"Book ISBN: {book1.ISBN}");
        //Console.WriteLine();

        
    }
}