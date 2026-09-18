using System;

class Book
{
    // Properties
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    // Constructor
    public Book(int id, string title, string author, double price)
    {
        BookId = id;
        Title = title;
        Author = author;
        Price = price;
    }

    // Method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine("Book ID: " + BookId);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine();
    }
}

class P5
{
    static void Main()
    {
        // Creating multiple book objects
        Book book1 = new Book(101, "C# Programming", "John Smith", 500);
        Book book2 = new Book(102, "Java Programming", "James Gosling", 600);
        Book book3 = new Book(103, "Python Basics", "Mark Lee", 450);

        // Display details
        book1.DisplayDetails();
        book2.DisplayDetails();
        book3.DisplayDetails();

        Console.WriteLine("=========================");
        Console.WriteLine("Name: Aesh Domadiya");
        Console.WriteLine("Enrollment no.: 24SOECE11008");
    }
}