using System;

class LibraryAccount
{
    // Private data member
    private int issuedBooks;

    // Constructor
    public LibraryAccount()
    {
        issuedBooks = 0;
    }

    // Method to issue a book
    public void IssueBook()
    {
        issuedBooks++;
        Console.WriteLine("Book issued successfully.");
    }

    // Method to return a book
    public void ReturnBook()
    {
        if (issuedBooks > 0)
        {
            issuedBooks--;
            Console.WriteLine("Book returned successfully.");
        }
        else
        {
            Console.WriteLine("No books to return.");
        }
    }

    // Method to display issued books
    public void DisplayBooks()
    {
        Console.WriteLine("Number of issued books: " + issuedBooks);
    }
}

class P10
{
    static void Main()
    {
        // Creating multiple objects
        LibraryAccount account1 = new LibraryAccount();
        LibraryAccount account2 = new LibraryAccount();

        // Account 1
        account1.IssueBook();
        account1.IssueBook();
        account1.DisplayBooks();

        account1.ReturnBook();
        account1.DisplayBooks();

        Console.WriteLine();

        // Account 2
        account2.IssueBook();
        account2.DisplayBooks();

        Console.WriteLine("=========================");
        Console.WriteLine("Name: Aesh Domadiya");
        Console.WriteLine("Enrollment no.: 24SOECE11008");
    }
}