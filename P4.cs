using System;

class Product
{
    private int productCode;
    private string productName;
    private double price;

    // Constructor
    public Product(int code, string name, double price)
    {
        productCode = code;
        productName = name;
        this.price = price;
    }

    // Calculate 10% discount
    public double CalculateDiscount()
    {
        return price * 0.10;
    }

    // Calculate final price
    public double CalculateFinalPrice()
    {
        return price - CalculateDiscount();
    }

    // Display product details
    public void DisplayDetails()
    {
        Console.WriteLine("Product Code: " + productCode);
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Discount: " + CalculateDiscount());
        Console.WriteLine("Final Price: " + CalculateFinalPrice());
    }
}

class P4
{
    static void Main()
    {
        Product p = new Product(101, "Laptop", 50000);

        p.DisplayDetails();

        Console.WriteLine("=========================");
        Console.WriteLine("Name: Aesh Domadiya");
        Console.WriteLine("Enrollment no.: 24SOECE11008");
    }
}