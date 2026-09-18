using System;

class Library
{
    // static keyword
    public static string LibraryName = "City Library";

    public string BookName;

    // Constructor using this keyword
    public Library(string BookName)
    {
        this.BookName = BookName;
    }

    public virtual void Display()
    {
        Console.WriteLine("Library Book: " + BookName);
    }

    // Method for demonstrating new keyword
    public void Show()
    {
        Console.WriteLine("This is the Library Show() method.");
    }
}

class DigitalLibrary : Library
{
    // Constructor
    public DigitalLibrary(string BookName)
        : base(BookName)
    {
        this.BookName = BookName;
    }

    public override void Display()
    {
        // base keyword
        Console.WriteLine("Base Book Name: " + base.BookName);

        // this keyword
        Console.WriteLine("Digital Book Name: " + this.BookName);
    }

    // new keyword
    public new void Show()
    {
        Console.WriteLine("This is the DigitalLibrary Show() method.");
    }
}

class P9
{
    static void Main()
    {
        // static keyword
        Console.WriteLine("Library Name: " + Library.LibraryName);

        DigitalLibrary book = new DigitalLibrary("C# Programming");

        // this and base keywords
        book.Display();

        // new keyword
        book.Show();

        // Calling base class Show()
        Library library = book;
        library.Show();

        Console.WriteLine("=========================");
        Console.WriteLine("Name: Aesh Domadiya");
        Console.WriteLine("Enrollment no.: 24SOECE11008");
    }
}